namespace OPC_DEMO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitMain = new SplitContainer();
            tabMain = new TabControl();
            tabSerial = new TabPage();
            tlpSerial = new TableLayoutPanel();
            label5 = new Label();
            cbStopBits = new ComboBox();
            label4 = new Label();
            cbParity = new ComboBox();
            label3 = new Label();
            cbDataBits = new ComboBox();
            cbBaud = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cbPorts = new ComboBox();
            btnSerialOpenClose = new Button();
            tabSocket = new TabPage();
            tlpSocket = new TableLayoutPanel();
            label6 = new Label();
            tbHost = new TextBox();
            label7 = new Label();
            numPort = new NumericUpDown();
            btnSocketConnectDisconnect = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tlpRight = new TableLayoutPanel();
            grpTxn = new GroupBox();
            tlpTxn = new TableLayoutPanel();
            label17 = new Label();
            tbOriDate = new TextBox();
            tbOriTrace = new TextBox();
            label9 = new Label();
            cbTransType = new ComboBox();
            label8 = new Label();
            tbAmount = new TextBox();
            tlpBtn = new TableLayoutPanel();
            btnCancel = new Button();
            btnSend = new Button();
            label11 = new Label();
            label10 = new Label();
            tbCurrencyCode = new TextBox();
            tbTransactionID = new TextBox();
            label16 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            rtbResponse = new RichTextBox();
            rtbResponseJson = new RichTextBox();
            rtbRequest = new RichTextBox();
            label12 = new Label();
            rtbRequestJson = new RichTextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            tabMain.SuspendLayout();
            tabSerial.SuspendLayout();
            tlpSerial.SuspendLayout();
            tabSocket.SuspendLayout();
            tlpSocket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            tabControl1.SuspendLayout();
            tlpRight.SuspendLayout();
            grpTxn.SuspendLayout();
            tlpTxn.SuspendLayout();
            tlpBtn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(tabMain);
            splitMain.Panel1.Controls.Add(tabControl1);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(tlpRight);
            splitMain.Size = new Size(1927, 1042);
            splitMain.SplitterDistance = 369;
            splitMain.TabIndex = 0;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabSerial);
            tabMain.Controls.Add(tabSocket);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(369, 1042);
            tabMain.TabIndex = 0;
            // 
            // tabSerial
            // 
            tabSerial.Controls.Add(tlpSerial);
            tabSerial.Location = new Point(8, 45);
            tabSerial.Name = "tabSerial";
            tabSerial.Padding = new Padding(3);
            tabSerial.Size = new Size(353, 989);
            tabSerial.TabIndex = 0;
            tabSerial.Text = "Serial";
            tabSerial.UseVisualStyleBackColor = true;
            // 
            // tlpSerial
            // 
            tlpSerial.AutoSize = true;
            tlpSerial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpSerial.ColumnCount = 2;
            tlpSerial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpSerial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpSerial.Controls.Add(label5, 0, 4);
            tlpSerial.Controls.Add(cbStopBits, 1, 4);
            tlpSerial.Controls.Add(label4, 0, 3);
            tlpSerial.Controls.Add(cbParity, 1, 3);
            tlpSerial.Controls.Add(label3, 0, 2);
            tlpSerial.Controls.Add(cbDataBits, 1, 2);
            tlpSerial.Controls.Add(cbBaud, 1, 1);
            tlpSerial.Controls.Add(label2, 0, 1);
            tlpSerial.Controls.Add(label1, 0, 0);
            tlpSerial.Controls.Add(cbPorts, 1, 0);
            tlpSerial.Controls.Add(btnSerialOpenClose, 1, 5);
            tlpSerial.Dock = DockStyle.Fill;
            tlpSerial.Location = new Point(3, 3);
            tlpSerial.Name = "tlpSerial";
            tlpSerial.RowCount = 6;
            tlpSerial.RowStyles.Add(new RowStyle(SizeType.Percent, 17.525774F));
            tlpSerial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4948444F));
            tlpSerial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4948444F));
            tlpSerial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4948444F));
            tlpSerial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4948444F));
            tlpSerial.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4948444F));
            tlpSerial.Size = new Size(347, 983);
            tlpSerial.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(20, 723);
            label5.Name = "label5";
            label5.Size = new Size(115, 31);
            label5.TabIndex = 8;
            label5.Text = "Stop Bits";
            // 
            // cbStopBits
            // 
            cbStopBits.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStopBits.FormattingEnabled = true;
            cbStopBits.Location = new Point(141, 719);
            cbStopBits.Name = "cbStopBits";
            cbStopBits.Size = new Size(203, 39);
            cbStopBits.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(56, 561);
            label4.Name = "label4";
            label4.Size = new Size(79, 31);
            label4.TabIndex = 6;
            label4.Text = "Parity";
            // 
            // cbParity
            // 
            cbParity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParity.FormattingEnabled = true;
            cbParity.Location = new Point(141, 557);
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(203, 39);
            cbParity.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(20, 399);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 4;
            label3.Text = "Data Bits";
            // 
            // cbDataBits
            // 
            cbDataBits.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDataBits.FormattingEnabled = true;
            cbDataBits.Location = new Point(141, 395);
            cbDataBits.Name = "cbDataBits";
            cbDataBits.Size = new Size(203, 39);
            cbDataBits.TabIndex = 2;
            // 
            // cbBaud
            // 
            cbBaud.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBaud.FormattingEnabled = true;
            cbBaud.Location = new Point(141, 233);
            cbBaud.Name = "cbBaud";
            cbBaud.Size = new Size(203, 39);
            cbBaud.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(63, 237);
            label2.Name = "label2";
            label2.Size = new Size(72, 31);
            label2.TabIndex = 2;
            label2.Text = "Baud";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(73, 70);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // cbPorts
            // 
            cbPorts.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPorts.FormattingEnabled = true;
            cbPorts.Location = new Point(141, 66);
            cbPorts.Name = "cbPorts";
            cbPorts.Size = new Size(203, 39);
            cbPorts.TabIndex = 0;
            // 
            // btnSerialOpenClose
            // 
            btnSerialOpenClose.Anchor = AnchorStyles.Left;
            btnSerialOpenClose.Location = new Point(141, 878);
            btnSerialOpenClose.Name = "btnSerialOpenClose";
            btnSerialOpenClose.Size = new Size(150, 46);
            btnSerialOpenClose.TabIndex = 5;
            btnSerialOpenClose.Text = "Open";
            btnSerialOpenClose.UseVisualStyleBackColor = true;
            btnSerialOpenClose.Click += btnSerialOpenClose_Click;
            // 
            // tabSocket
            // 
            tabSocket.Controls.Add(tlpSocket);
            tabSocket.Location = new Point(8, 45);
            tabSocket.Name = "tabSocket";
            tabSocket.Padding = new Padding(3);
            tabSocket.Size = new Size(353, 989);
            tabSocket.TabIndex = 1;
            tabSocket.Text = "Socket";
            tabSocket.UseVisualStyleBackColor = true;
            // 
            // tlpSocket
            // 
            tlpSocket.ColumnCount = 2;
            tlpSocket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpSocket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpSocket.Controls.Add(label6, 0, 0);
            tlpSocket.Controls.Add(tbHost, 1, 0);
            tlpSocket.Controls.Add(label7, 0, 1);
            tlpSocket.Controls.Add(numPort, 1, 1);
            tlpSocket.Controls.Add(btnSocketConnectDisconnect, 1, 2);
            tlpSocket.Dock = DockStyle.Fill;
            tlpSocket.Location = new Point(3, 3);
            tlpSocket.Name = "tlpSocket";
            tlpSocket.RowCount = 3;
            tlpSocket.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tlpSocket.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tlpSocket.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tlpSocket.Size = new Size(347, 983);
            tlpSocket.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(67, 151);
            label6.Name = "label6";
            label6.Size = new Size(68, 31);
            label6.TabIndex = 0;
            label6.Text = "Host";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbHost
            // 
            tbHost.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbHost.Location = new Point(141, 148);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(203, 38);
            tbHost.TabIndex = 0;
            tbHost.Text = "127.0.0.1";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(73, 480);
            label7.Name = "label7";
            label7.Size = new Size(62, 31);
            label7.TabIndex = 2;
            label7.Text = "Port";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numPort
            // 
            numPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numPort.AutoSize = true;
            numPort.Location = new Point(141, 477);
            numPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(203, 38);
            numPort.TabIndex = 1;
            numPort.Value = new decimal(new int[] { 6031, 0, 0, 0 });
            // 
            // btnSocketConnectDisconnect
            // 
            btnSocketConnectDisconnect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSocketConnectDisconnect.AutoSize = true;
            btnSocketConnectDisconnect.Location = new Point(141, 797);
            btnSocketConnectDisconnect.Name = "btnSocketConnectDisconnect";
            btnSocketConnectDisconnect.Size = new Size(203, 46);
            btnSocketConnectDisconnect.TabIndex = 2;
            btnSocketConnectDisconnect.Text = "Connect";
            btnSocketConnectDisconnect.UseVisualStyleBackColor = true;
            btnSocketConnectDisconnect.Click += btnSocketConnectDisconnect_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(240, 314);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(8, 8);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(8, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(0, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 45);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(0, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpRight
            // 
            tlpRight.ColumnCount = 1;
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRight.Controls.Add(grpTxn, 0, 0);
            tlpRight.Controls.Add(tableLayoutPanel1, 0, 1);
            tlpRight.Dock = DockStyle.Fill;
            tlpRight.Location = new Point(0, 0);
            tlpRight.Name = "tlpRight";
            tlpRight.RowCount = 2;
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpRight.Size = new Size(1554, 1042);
            tlpRight.TabIndex = 0;
            // 
            // grpTxn
            // 
            grpTxn.Controls.Add(tlpTxn);
            grpTxn.Dock = DockStyle.Fill;
            grpTxn.Location = new Point(3, 3);
            grpTxn.Name = "grpTxn";
            grpTxn.Size = new Size(1548, 358);
            grpTxn.TabIndex = 0;
            grpTxn.TabStop = false;
            grpTxn.Text = "Transaction";
            // 
            // tlpTxn
            // 
            tlpTxn.AutoSize = true;
            tlpTxn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpTxn.ColumnCount = 4;
            tlpTxn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpTxn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpTxn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpTxn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpTxn.Controls.Add(label17, 2, 1);
            tlpTxn.Controls.Add(tbOriDate, 3, 1);
            tlpTxn.Controls.Add(tbOriTrace, 3, 0);
            tlpTxn.Controls.Add(label9, 0, 1);
            tlpTxn.Controls.Add(cbTransType, 1, 0);
            tlpTxn.Controls.Add(label8, 0, 0);
            tlpTxn.Controls.Add(tbAmount, 1, 1);
            tlpTxn.Controls.Add(tlpBtn, 1, 4);
            tlpTxn.Controls.Add(label11, 0, 2);
            tlpTxn.Controls.Add(label10, 0, 3);
            tlpTxn.Controls.Add(tbCurrencyCode, 1, 2);
            tlpTxn.Controls.Add(tbTransactionID, 1, 3);
            tlpTxn.Controls.Add(label16, 2, 0);
            tlpTxn.Dock = DockStyle.Fill;
            tlpTxn.Location = new Point(3, 34);
            tlpTxn.Name = "tlpTxn";
            tlpTxn.RowCount = 5;
            tlpTxn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTxn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTxn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTxn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTxn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpTxn.Size = new Size(1542, 321);
            tlpTxn.TabIndex = 0;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(773, 80);
            label17.Name = "label17";
            label17.Size = new Size(302, 31);
            label17.TabIndex = 18;
            label17.Text = "Original Date";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbOriDate
            // 
            tbOriDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbOriDate.Location = new Point(1081, 77);
            tbOriDate.Name = "tbOriDate";
            tbOriDate.Size = new Size(458, 38);
            tbOriDate.TabIndex = 16;
            tbOriDate.Text = "0";
            tbOriDate.TextAlign = HorizontalAlignment.Right;
            // 
            // tbOriTrace
            // 
            tbOriTrace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbOriTrace.Location = new Point(1081, 13);
            tbOriTrace.Name = "tbOriTrace";
            tbOriTrace.Size = new Size(458, 38);
            tbOriTrace.TabIndex = 15;
            tbOriTrace.Text = "0";
            tbOriTrace.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(198, 80);
            label9.Name = "label9";
            label9.Size = new Size(107, 31);
            label9.TabIndex = 3;
            label9.Text = "Amount";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbTransType
            // 
            cbTransType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbTransType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTransType.FormattingEnabled = true;
            cbTransType.Items.AddRange(new object[] { "Purchase", "PreAuth", "AuthCompletion", "BalanceInquiry", "Reversal", "Refund", "Settle", "GetPosInfo", "QueryTransaction", "PrintLast", "PrintTotal", "PrintDetail", "PrintParameter", "VerifyCardPan" });
            cbTransType.Location = new Point(311, 12);
            cbTransType.Name = "cbTransType";
            cbTransType.Size = new Size(456, 39);
            cbTransType.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(166, 16);
            label8.Name = "label8";
            label8.Size = new Size(139, 31);
            label8.TabIndex = 0;
            label8.Text = "Trans Type";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbAmount
            // 
            tbAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbAmount.Location = new Point(311, 77);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(456, 38);
            tbAmount.TabIndex = 1;
            tbAmount.Text = "0";
            tbAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // tlpBtn
            // 
            tlpBtn.ColumnCount = 2;
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBtn.Controls.Add(btnCancel, 0, 0);
            tlpBtn.Controls.Add(btnSend, 0, 0);
            tlpBtn.Dock = DockStyle.Fill;
            tlpBtn.Location = new Point(311, 259);
            tlpBtn.Name = "tlpBtn";
            tlpBtn.RowCount = 1;
            tlpBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBtn.Size = new Size(456, 59);
            tlpBtn.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Location = new Point(231, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(222, 41);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSend.AutoSize = true;
            btnSend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSend.Location = new Point(3, 9);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(222, 41);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(121, 144);
            label11.Name = "label11";
            label11.Size = new Size(184, 31);
            label11.TabIndex = 5;
            label11.Text = "Currency Code";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(127, 208);
            label10.Name = "label10";
            label10.Size = new Size(178, 31);
            label10.TabIndex = 7;
            label10.Text = "Transaction ID";
            // 
            // tbCurrencyCode
            // 
            tbCurrencyCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCurrencyCode.Location = new Point(311, 141);
            tbCurrencyCode.Name = "tbCurrencyCode";
            tbCurrencyCode.Size = new Size(456, 38);
            tbCurrencyCode.TabIndex = 2;
            tbCurrencyCode.Text = "0";
            tbCurrencyCode.TextAlign = HorizontalAlignment.Right;
            // 
            // tbTransactionID
            // 
            tbTransactionID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbTransactionID.Location = new Point(311, 205);
            tbTransactionID.Name = "tbTransactionID";
            tbTransactionID.Size = new Size(456, 38);
            tbTransactionID.TabIndex = 3;
            tbTransactionID.Text = "0";
            tbTransactionID.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(773, 16);
            label16.Name = "label16";
            label16.Size = new Size(302, 31);
            label16.TabIndex = 12;
            label16.Text = "Original Trace";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(rtbResponse, 2, 1);
            tableLayoutPanel1.Controls.Add(rtbResponseJson, 3, 1);
            tableLayoutPanel1.Controls.Add(rtbRequest, 1, 1);
            tableLayoutPanel1.Controls.Add(label12, 0, 0);
            tableLayoutPanel1.Controls.Add(rtbRequestJson, 0, 1);
            tableLayoutPanel1.Controls.Add(label13, 2, 0);
            tableLayoutPanel1.Controls.Add(label14, 1, 0);
            tableLayoutPanel1.Controls.Add(label15, 3, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 367);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1548, 672);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // rtbResponse
            // 
            rtbResponse.Dock = DockStyle.Fill;
            rtbResponse.Location = new Point(776, 43);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.ReadOnly = true;
            rtbResponse.Size = new Size(303, 585);
            rtbResponse.TabIndex = 10;
            rtbResponse.Text = "";
            // 
            // rtbResponseJson
            // 
            rtbResponseJson.Dock = DockStyle.Fill;
            rtbResponseJson.Location = new Point(1085, 43);
            rtbResponseJson.Name = "rtbResponseJson";
            rtbResponseJson.ReadOnly = true;
            rtbResponseJson.Size = new Size(460, 585);
            rtbResponseJson.TabIndex = 9;
            rtbResponseJson.Text = "";
            // 
            // rtbRequest
            // 
            rtbRequest.Dock = DockStyle.Fill;
            rtbRequest.Location = new Point(467, 43);
            rtbRequest.Name = "rtbRequest";
            rtbRequest.ReadOnly = true;
            rtbRequest.Size = new Size(303, 585);
            rtbRequest.TabIndex = 1;
            rtbRequest.Text = "";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(3, 4);
            label12.Name = "label12";
            label12.Size = new Size(458, 31);
            label12.TabIndex = 0;
            label12.Text = "Request Json:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtbRequestJson
            // 
            rtbRequestJson.Dock = DockStyle.Fill;
            rtbRequestJson.Location = new Point(3, 43);
            rtbRequestJson.Name = "rtbRequestJson";
            rtbRequestJson.ReadOnly = true;
            rtbRequestJson.Size = new Size(458, 585);
            rtbRequestJson.TabIndex = 0;
            rtbRequestJson.Text = "";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(776, 4);
            label13.Name = "label13";
            label13.Size = new Size(303, 31);
            label13.TabIndex = 1;
            label13.Text = "Receive:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(467, 4);
            label14.Name = "label14";
            label14.Size = new Size(303, 31);
            label14.TabIndex = 6;
            label14.Text = "Send:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(1085, 4);
            label15.Name = "label15";
            label15.Size = new Size(460, 31);
            label15.TabIndex = 7;
            label15.Text = "Receive Json:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.AutoSize = true;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Location = new Point(1085, 634);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(460, 35);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClearRequest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1927, 1042);
            Controls.Add(splitMain);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OPC Serial & Socket Tool";
            Load += Form1_Load;
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabSerial.ResumeLayout(false);
            tabSerial.PerformLayout();
            tlpSerial.ResumeLayout(false);
            tlpSerial.PerformLayout();
            tabSocket.ResumeLayout(false);
            tlpSocket.ResumeLayout(false);
            tlpSocket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            tabControl1.ResumeLayout(false);
            tlpRight.ResumeLayout(false);
            tlpRight.PerformLayout();
            grpTxn.ResumeLayout(false);
            grpTxn.PerformLayout();
            tlpTxn.ResumeLayout(false);
            tlpTxn.PerformLayout();
            tlpBtn.ResumeLayout(false);
            tlpBtn.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private readonly List<byte> _rxBuf = new List<byte>(8192);
        private readonly object _rxLock = new object();

        private SplitContainer splitMain;
        private TabControl tabMain;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabSerial;
        private TabPage tabSocket;
        private TableLayoutPanel tlpSerial;
        private Label label1;
        private Label label6;
        private ComboBox comboBox4;
        private Label label5;
        private ComboBox cbStopBits;
        private Label label4;
        private ComboBox cbParity;
        private Label label3;
        private ComboBox cbDataBits;
        private ComboBox cbBaud;
        private Label label2;
        private ComboBox cbPorts;
        private Button btnSerialOpenClose;
        private TableLayoutPanel tlpSocket;
        private TextBox tbHost;
        private Label label7;
        private NumericUpDown numPort;
        private Button btnSocketConnectDisconnect;
        private TableLayoutPanel tlpRight;
        private GroupBox grpTxn;
        private TableLayoutPanel tlpTxn;
        private Label label8;
        private Label label9;
        private ComboBox cbTransType;
        private TextBox tbAmount;
        private TextBox tbTransactionID;
        private Label label10;
        private TextBox tbCurrencyCode;
        private Label label11;
        private TableLayoutPanel tlpBtn;
        private Button btnCancel;
        private Button btnSend;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label13;
        private Label label12;
        private Button btnClear;
        private RichTextBox rtbRequest;
        private RichTextBox rtbRequestJson;
        private Label label14;
        private RichTextBox rtbResponse;
        private RichTextBox rtbResponseJson;
        private Label label15;
        private Label label17;
        private TextBox tbOriDate;
        private TextBox tbOriTrace;
        private Label label16;
    }
}
