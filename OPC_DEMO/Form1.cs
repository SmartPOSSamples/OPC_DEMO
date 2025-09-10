using SerialProto;
using System.IO.Ports;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

using Wizarpos.Payment.Aidl;  

namespace OPC_DEMO
{
    public partial class Form1 : Form
    {
        private SerialPort _sp;

        private System.Net.Sockets.TcpClient _tcp;
        private NetworkStream _ns;
        private CancellationTokenSource _sockCts;
        private readonly List<byte> _rxBufSock = new List<byte>(8192);
        private readonly object _rxLockSock = new object();
        private bool SocketConnected =>
    _tcp != null && _tcp.Connected && _ns != null && _ns.CanRead && _ns.CanWrite;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSerialUiDefaults();
        }

        private void InitSerialUiDefaults()
        {
            RefreshPorts(selectFirstIfAny: true);

            cbBaud.Items.Clear();
            cbBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" });
            cbBaud.SelectedItem = "115200";

            cbDataBits.Items.Clear();
            cbDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            cbDataBits.SelectedItem = "8";

            cbParity.Items.Clear();
            cbParity.Items.AddRange(new object[] { "None", "Odd", "Even" });
            cbParity.SelectedItem = "None";

            cbStopBits.Items.Clear();
            cbStopBits.Items.AddRange(new object[] { "1", "1.5", "2" });
            cbStopBits.SelectedItem = "1";
        }

        private void RefreshPorts(bool selectFirstIfAny)
        {
            cbPorts.Items.Clear();
            var ports = SerialPort.GetPortNames();
            Array.Sort(ports, StringComparer.OrdinalIgnoreCase);

            if (ports.Length == 0)
            {
                cbPorts.Items.Add("(No Ports)");
                cbPorts.SelectedIndex = 0;
                cbPorts.Enabled = false;
                btnSerialOpenClose.Enabled = false;
                return;
            }

            cbPorts.Enabled = true;
            btnSerialOpenClose.Enabled = true;
            cbPorts.Items.AddRange(ports);
            if (selectFirstIfAny) cbPorts.SelectedIndex = 0;
        }

        private void btnSerialOpenClose_Click(object sender, EventArgs e)
        {

            if (_sp == null || !_sp.IsOpen)
            {
                if (string.IsNullOrWhiteSpace(cbPorts.Text) || cbPorts.Text == "(No Ports)")
                {
                    MessageBox.Show("No serial port selected.");
                    return;
                }

                try
                {
                    var parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
                    var stop = cbStopBits.Text == "1" ? StopBits.One
                               : cbStopBits.Text == "1.5" ? StopBits.OnePointFive
                               : StopBits.Two;

                    _sp = new SerialPort
                    {
                        PortName = cbPorts.Text,
                        BaudRate = int.Parse(cbBaud.Text),
                        DataBits = int.Parse(cbDataBits.Text),
                        Parity = parity,
                        StopBits = stop,
                        ReadTimeout = 500,
                        WriteTimeout = 500
                    };
                    _sp.DataReceived += Sp_DataReceived;
                    _sp.Open();

                    btnSerialOpenClose.Text = "Close";
                    SetSerialUiEnabled(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Open failed: " + ex.Message);
                    btnSerialOpenClose.Text = "Open";
                }
            }

            else
            {
                try { _sp.Close(); }
                catch { /* 忽略 */ }
                finally
                {
                    try { _sp.Dispose(); } catch { }
                    _sp = null;

                    btnSerialOpenClose.Text = "Open";
                    SetSerialUiEnabled(true);
                }
            }
        }

        private void SetSerialUiEnabled(bool enabled)
        {
            cbPorts.Enabled = enabled;
            cbBaud.Enabled = enabled;
            cbDataBits.Enabled = enabled;
            cbParity.Enabled = enabled;
            cbStopBits.Enabled = enabled;
        }

        // 可选：接收事件
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int n = _sp.BytesToRead;
                if (n <= 0) return;

                byte[] chunk = new byte[n];
                _sp.Read(chunk, 0, n);

                lock (_rxLock)
                {
                    _rxBuf.AddRange(chunk);
                    ProcessRxBuffer(); // 解析并打印到 rtbResponse
                }
            }
            catch
            {
                // 忽略单次接收异常，避免影响后续解析
            }
        }


        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                bool serialReady = _sp != null && _sp.IsOpen;
                bool socketReady = SocketConnected;

                if (!serialReady && !socketReady)
                {
                    MessageBox.Show("Neither serial port nor socket is available. Please open serial or connect socket.");
                    return;
                }

                // 1) 发送握手帧（无 JSON）
                var handshakeData = NormalSerialProtocol.PackData(
                    Encoding.ASCII.GetBytes("1234"),   // content
                    1122,                              // seq
                    ProtocolConsts.CTRL_HANDSHAKE_REQ  // ctrl
                );
                handshakeData.Version = 2;
                var handshakeBytes = handshakeData.GenerateBytes();

                if (serialReady)
                    _sp.Write(handshakeBytes, 0, handshakeBytes.Length);
                else
                    await _ns.WriteAsync(handshakeBytes, 0, handshakeBytes.Length);

                LogRequest(handshakeBytes, null);

                await Task.Delay(50);

                // 2) 发送交易请求（有 JSON）
                var now = DateTime.Now;
                var req = new GlobalAidlRequest
                {
                    TransType = cbTransType.Text,
                    TransIndexCode = tbTransactionID.Text,
                    TransAmount = tbAmount.Text,
                    CurrencyCode = tbCurrencyCode.Text,
                    OriTraceNum = tbOriTrace.Text,
                    OriTransDate = tbOriDate.Text,
                    ReqTransDate = now.ToString("yyMMdd"),
                    ReqTransTime = now.ToString("HHmmss"),
                    SkipConfirmProcedure = true,
                    EnableReceipt = true
                };

                string json = req.ToJson(false);
                var txData = NormalSerialProtocol.PackData(
                    Encoding.UTF8.GetBytes(json),
                    123,
                    ProtocolConsts.CTRL_FROM_CASHIER
                );
                txData.Version = 2;
                var txBytes = txData.GenerateBytes();

                if (serialReady)
                    _sp.Write(txBytes, 0, txBytes.Length);
                else
                    await _ns.WriteAsync(txBytes, 0, txBytes.Length);

                LogRequest(txBytes, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Send failed: " + ex.Message);
            }
        }



        private void ProcessRxBuffer()
        {
            while (true)
            {
                // 1) 寻找 STX
                int start = _rxBuf.IndexOf(0x02); // STX
                if (start < 0)
                {
                    // 缓冲里没有 STX，清空
                    _rxBuf.Clear();
                    return;
                }

                // 丢弃 STX 之前的杂数据
                if (start > 0) _rxBuf.RemoveRange(0, start);

                // 2) 最小长度校验：头(1+1+4+2) + 尾(1+1) = 10
                if (_rxBuf.Count < 10) return; // 等更多数据

                int i = 0;
                byte stx = _rxBuf[i++];        // 0x02
                byte version = _rxBuf[i++];    // version
                                               // ctrl[4]
                byte c0 = _rxBuf[i++], c1 = _rxBuf[i++], c2 = _rxBuf[i++], c3 = _rxBuf[i++];
                int len = (_rxBuf[i++] << 8) | _rxBuf[i++]; // content length (BE)

                int total = 1 + 1 + 4 + 2 + len + 1 + 1; // STX..BCC
                if (_rxBuf.Count < total) return;        // 半包，等更多数据

                // 3) 取整帧
                byte[] frame = _rxBuf.GetRange(0, total).ToArray();

                // 4) 校验 ETX
                if (frame[total - 2] != 0x03)
                {
                    // 非法帧：丢弃第一个字节，继续找下一帧
                    _rxBuf.RemoveAt(0);
                    continue;
                }

                // 5) 校验 BCC（XOR version..ETX）
                byte calc = 0x00;
                for (int k = 1; k <= total - 2; k++) calc ^= frame[k];
                byte bcc = frame[total - 1];
                bool bccOk = (calc == bcc);

                // 6) 提取 content 并尝试当作 UTF-8 JSON 打印
                int contentOffset = 1 + 1 + 4 + 2;
                string json = string.Empty;
                try
                {
                    json = Encoding.UTF8.GetString(frame, contentOffset, len);
                    // 简单判断是否像 JSON（可选）
                    if (!(json.StartsWith("{") || json.StartsWith("["))) json = string.Empty;
                }
                catch { /* 非 UTF-8 就不打印 JSON */ }

                // 7) 打印

                LogReceive(frame, json);

                // 如果 BCC 校验失败
                if (!bccOk)
                {
                    AppendRtbSafe(rtbRequest, $"{DateTime.Now:HH:mm:ss.fff} RX WARN: BCC mismatch (calc={calc:X2}, recv={bcc:X2})\r\n");
                }

                // 8) 丢弃本帧，并继续解析后续（处理粘包）
                _rxBuf.RemoveRange(0, total);
            }
        }


        private void TryLog(string text)
        {
            try
            {
                if (rtbRequestJson != null)
                {
                    if (InvokeRequired) { BeginInvoke(new Action<string>(TryLog), text); return; }
                    rtbRequestJson.AppendText($"{DateTime.Now:HH:mm:ss} {text}\r\n");
                }
            }
            catch { /* logfile exception */ }
        }


        private static string ToHex(byte[] data)
        {
            if (data == null) return "";
            char[] c = new char[data.Length * 2];
            int i = 0;
            foreach (var b in data)
            {
                int hi = (b >> 4) & 0xF, lo = b & 0xF;
                c[i++] = (char)(hi < 10 ? hi + '0' : hi - 10 + 'A');
                c[i++] = (char)(lo < 10 ? lo + '0' : lo - 10 + 'A');
            }
            return new string(c);
        }

        // 线程安全打印到 RichTextBox
        private void AppendRtbSafe(RichTextBox rtb, string text)
        {
            if (rtb == null) return;
            if (InvokeRequired) { BeginInvoke(new Action<RichTextBox, string>(AppendRtbSafe), rtb, text); return; }
            rtb.AppendText(text);
            rtb.AppendText(Environment.NewLine + Environment.NewLine);
            rtb.ScrollToCaret();
        }

        private void LogRequest(byte[] frame, string jsonOrNull)
        {
            string ts = DateTime.Now.ToString("HH:mm:ss.fff");
            AppendRtbSafe(rtbRequest, $"{ts} HEX: {ToHex(frame)}\r\n");
            if (!string.IsNullOrEmpty(jsonOrNull))
            {
                var pretty = PrettyJson(jsonOrNull);
                AppendRtbSafe(rtbRequestJson, $"{ts} JSON:\r\n{pretty}\r\n");
            }
        }

        private void LogReceive(byte[] frame, string jsonOrNull)
        {
            string ts = DateTime.Now.ToString("HH:mm:ss.fff");
            AppendRtbSafe(rtbResponse, $"{ts} HEX: {ToHex(frame)}\r\n");
            if (!string.IsNullOrEmpty(jsonOrNull))
            {
                var pretty = PrettyJson(jsonOrNull);
                AppendRtbSafe(rtbResponseJson, $"{ts} JSON:\r\n{pretty}\r\n");
            }
        }

        private static string PrettyJson(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return raw;
            try
            {
                using var doc = JsonDocument.Parse(raw);
                var opt = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                return JsonSerializer.Serialize(doc.RootElement, opt);
            }
            catch
            {
                // 不是合法 JSON，就按原样打印
                return raw;
            }
        }

        private void btnClearRequest_Click(object sender, EventArgs e)
        {
            rtbRequestJson.Clear();
            rtbRequestJson.SelectionStart = 0;
            rtbRequestJson.ScrollToCaret();

            rtbRequest.Clear();
            rtbRequest.SelectionStart = 0;
            rtbRequest.ScrollToCaret();

            rtbResponse.Clear();
            rtbResponse.SelectionStart = 0;
            rtbResponse.ScrollToCaret();

            rtbResponseJson.Clear();
            rtbResponseJson.SelectionStart = 0;
            rtbResponseJson.ScrollToCaret();
        }

        private async void btnSocketConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (!SocketConnected)
            {
                // Connect
                string host = tbHost.Text.Trim();
                int port = (int)numPort.Value;

                if (string.IsNullOrWhiteSpace(host))
                {
                    MessageBox.Show("Host is empty.");
                    return;
                }

                try
                {
                    btnSocketConnectDisconnect.Enabled = false;
                    btnSocketConnectDisconnect.Text = "Connecting...";

                    _tcp = new System.Net.Sockets.TcpClient();
                    _tcp.NoDelay = true; // 减少延迟
                    await _tcp.ConnectAsync(host, port);

                    _ns = _tcp.GetStream();
                    _sockCts = new CancellationTokenSource();

                    // 启动异步接收循环
                    _ = Task.Run(() => SocketReceiveLoop(_sockCts.Token));

                    btnSocketConnectDisconnect.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connect failed: " + ex.Message);
                    await SafeSocketCloseAsync();
                    btnSocketConnectDisconnect.Text = "Connect";
                }
                finally
                {
                    btnSocketConnectDisconnect.Enabled = true;
                }
            }
            else
            {
                // Disconnect
                await SafeSocketCloseAsync();
                btnSocketConnectDisconnect.Text = "Connect";
            }
        }

        private async Task SafeSocketCloseAsync()
        {
            try { _sockCts?.Cancel(); } catch { }
            try
            {
                if (_ns != null)
                {
                    await _ns.FlushAsync();
                    _ns.Close();
                }
            }
            catch { /* ignore */ }

            try { _ns?.Dispose(); } catch { }
            _ns = null;

            try { _tcp?.Close(); } catch { }
            try { _tcp?.Dispose(); } catch { }
            _tcp = null;

            _sockCts = null;

            lock (_rxLockSock) { _rxBufSock.Clear(); }
        }


        private async Task SocketReceiveLoop(CancellationToken ct)
        {
            var buf = new byte[4096];
            try
            {
                while (!ct.IsCancellationRequested && SocketConnected)
                {
                    int n = 0;
                    try
                    {
                        n = await _ns.ReadAsync(buf.AsMemory(0, buf.Length), ct);
                    }
                    catch (OperationCanceledException) { break; }

                    if (n <= 0) break; // 断开

                    lock (_rxLockSock)
                    {
                        _rxBufSock.AddRange(buf.AsSpan(0, n).ToArray());
                        ProcessRxBufferSock(); // 与串口相同的解析逻辑，写到 Receive 区域
                    }
                }
            }
            catch
            {
                // 忽略循环内异常，交给上层关闭
            }
            finally
            {
                await SafeSocketCloseAsync();
                if (InvokeRequired) BeginInvoke(() => btnSocketConnectDisconnect.Text = "Connect");
                else btnSocketConnectDisconnect.Text = "Connect";
            }
        }

        private void ProcessRxBufferSock()
        {
            while (true)
            {
                int start = _rxBufSock.IndexOf(0x02); // STX
                if (start < 0)
                {
                    _rxBufSock.Clear();
                    return;
                }
                if (start > 0) _rxBufSock.RemoveRange(0, start);

                if (_rxBufSock.Count < 10) return;

                int i = 0;
                byte stx = _rxBufSock[i++];      // 0x02
                byte version = _rxBufSock[i++];  // version
                byte c0 = _rxBufSock[i++], c1 = _rxBufSock[i++], c2 = _rxBufSock[i++], c3 = _rxBufSock[i++];
                int len = (_rxBufSock[i++] << 8) | _rxBufSock[i++];

                int total = 1 + 1 + 4 + 2 + len + 1 + 1;
                if (_rxBufSock.Count < total) return;

                byte[] frame = _rxBufSock.GetRange(0, total).ToArray();

                if (frame[total - 2] != 0x03)
                {
                    _rxBufSock.RemoveAt(0);
                    continue;
                }

                byte calc = 0x00;
                for (int k = 1; k <= total - 2; k++) calc ^= frame[k];
                byte bcc = frame[total - 1];
                bool bccOk = (calc == bcc);

                int contentOffset = 1 + 1 + 4 + 2;
                string json = string.Empty;
                try
                {
                    json = Encoding.UTF8.GetString(frame, contentOffset, len);
                    if (!(json.StartsWith("{") || json.StartsWith("["))) json = string.Empty;
                }
                catch { }

                LogReceive(frame, json);

                if (!bccOk)
                {
                    AppendRtbSafe(rtbRequest, $"{DateTime.Now:HH:mm:ss.fff} SOCK WARN: BCC mismatch (calc={calc:X2}, recv={bcc:X2})");
                }

                _rxBufSock.RemoveRange(0, total);
            }
        }


        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            try
            {
                // 串口清理
                if (_sp != null && _sp.IsOpen)
                {
                    try { _sp.Close(); } catch { }
                    try { _sp.Dispose(); } catch { }
                    _sp = null;
                }

                // Socket 清理
                await SafeSocketCloseAsync();
            }
            catch { /* ignore */ }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                bool serialReady = _sp != null && _sp.IsOpen;
                bool socketReady = SocketConnected;

                if (!serialReady && !socketReady)
                {
                    MessageBox.Show("Neither serial port nor socket is available. Please open serial or connect socket.");
                    return;
                }

                
                var cancelData = NormalSerialProtocol.PackData(
                    null, 
                    2233,                              // seq
                    ProtocolConsts.CTRL_CANCEL_REQUEST  // ctrl
                );
                cancelData.Version = 2;
                var cancelBytes = cancelData.GenerateBytes();

               
                _sp.Write(cancelBytes, 0, cancelBytes.Length);
                

                LogRequest(cancelBytes, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Send failed: " + ex.Message);
            }
        }
    }



}
