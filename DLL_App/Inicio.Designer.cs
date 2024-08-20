namespace DLL_App
{
    partial class Interfaz
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
			label1 = new Label();
			btnSend = new Button();
			label2 = new Label();
			combPorts = new ComboBox();
			btnOpen = new Button();
			btnClose = new Button();
			label3 = new Label();
			combCommands = new ComboBox();
			panel1 = new Panel();
			btnHandshake = new Button();
			btnReloadPorts = new Button();
			combBaudRate = new ComboBox();
			label4 = new Label();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			label5 = new Label();
			panel3 = new Panel();
			txtboxResp = new TextBox();
			lblParamValue = new Label();
			panelParamValue = new Panel();
			textboxParamValue = new TextBox();
			lblMessages = new Label();
			btnDefaultAddressing = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel3.SuspendLayout();
			panelParamValue.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(128, 52);
			label1.Name = "label1";
			label1.Size = new Size(189, 37);
			label1.TabIndex = 0;
			label1.Text = "EZM AMI TOOL";
			// 
			// btnSend
			// 
			btnSend.BackColor = Color.FromArgb(240, 43, 83);
			btnSend.FlatAppearance.BorderSize = 0;
			btnSend.FlatStyle = FlatStyle.Flat;
			btnSend.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSend.ForeColor = Color.White;
			btnSend.Location = new Point(445, 363);
			btnSend.Margin = new Padding(3, 2, 3, 2);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(85, 33);
			btnSend.TabIndex = 5;
			btnSend.Text = "Send";
			btnSend.UseVisualStyleBackColor = false;
			btnSend.Click += btnSend_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
			label2.ForeColor = Color.White;
			label2.Location = new Point(32, 17);
			label2.Name = "label2";
			label2.Size = new Size(41, 21);
			label2.TabIndex = 1;
			label2.Text = "Port";
			// 
			// combPorts
			// 
			combPorts.BackColor = Color.FromArgb(22, 21, 35);
			combPorts.DropDownStyle = ComboBoxStyle.DropDownList;
			combPorts.FlatStyle = FlatStyle.Flat;
			combPorts.Font = new Font("Franklin Gothic Book", 10.8F);
			combPorts.ForeColor = Color.White;
			combPorts.FormattingEnabled = true;
			combPorts.Location = new Point(32, 44);
			combPorts.Margin = new Padding(3, 2, 3, 2);
			combPorts.Name = "combPorts";
			combPorts.Size = new Size(132, 26);
			combPorts.TabIndex = 2;
			combPorts.SelectedIndexChanged += combPorts_SelectedIndexChanged;
			// 
			// btnOpen
			// 
			btnOpen.BackColor = Color.FromArgb(240, 43, 83);
			btnOpen.FlatAppearance.BorderSize = 0;
			btnOpen.FlatStyle = FlatStyle.Flat;
			btnOpen.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Bold);
			btnOpen.ForeColor = Color.White;
			btnOpen.Location = new Point(359, 43);
			btnOpen.Margin = new Padding(3, 2, 3, 2);
			btnOpen.Name = "btnOpen";
			btnOpen.Size = new Size(57, 27);
			btnOpen.TabIndex = 3;
			btnOpen.Text = "Open";
			btnOpen.UseVisualStyleBackColor = false;
			btnOpen.Click += btnOpen_Click;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.FromArgb(240, 43, 83);
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Bold);
			btnClose.ForeColor = Color.White;
			btnClose.Location = new Point(436, 43);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(57, 27);
			btnClose.TabIndex = 4;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = false;
			btnClose.Click += btnClose_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(69, 288);
			label3.Name = "label3";
			label3.Size = new Size(86, 21);
			label3.TabIndex = 6;
			label3.Text = "Command";
			// 
			// combCommands
			// 
			combCommands.BackColor = Color.FromArgb(22, 21, 35);
			combCommands.DropDownStyle = ComboBoxStyle.DropDownList;
			combCommands.FlatStyle = FlatStyle.Flat;
			combCommands.Font = new Font("Franklin Gothic Book", 10.8F);
			combCommands.ForeColor = Color.White;
			combCommands.FormattingEnabled = true;
			combCommands.Location = new Point(69, 321);
			combCommands.Margin = new Padding(3, 2, 3, 2);
			combCommands.Name = "combCommands";
			combCommands.Size = new Size(198, 26);
			combCommands.TabIndex = 7;
			combCommands.SelectedIndexChanged += combCommands_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(22, 21, 34);
			panel1.Controls.Add(btnDefaultAddressing);
			panel1.Controls.Add(btnHandshake);
			panel1.Controls.Add(btnReloadPorts);
			panel1.Controls.Add(combBaudRate);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(btnClose);
			panel1.Controls.Add(btnOpen);
			panel1.Controls.Add(combPorts);
			panel1.Controls.Add(label2);
			panel1.ForeColor = Color.FromArgb(0, 0, 0, 0);
			panel1.Location = new Point(37, 137);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(518, 118);
			panel1.TabIndex = 10;
			// 
			// btnHandshake
			// 
			btnHandshake.BackColor = Color.FromArgb(240, 43, 83);
			btnHandshake.FlatAppearance.BorderSize = 0;
			btnHandshake.FlatStyle = FlatStyle.Flat;
			btnHandshake.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Bold);
			btnHandshake.ForeColor = Color.White;
			btnHandshake.Location = new Point(32, 79);
			btnHandshake.Margin = new Padding(3, 2, 3, 2);
			btnHandshake.Name = "btnHandshake";
			btnHandshake.Size = new Size(222, 27);
			btnHandshake.TabIndex = 8;
			btnHandshake.Text = "Do Handshake";
			btnHandshake.UseVisualStyleBackColor = false;
			btnHandshake.Click += btnHandshake_Click;
			// 
			// btnReloadPorts
			// 
			btnReloadPorts.BackColor = Color.FromArgb(240, 43, 83);
			btnReloadPorts.FlatAppearance.BorderSize = 0;
			btnReloadPorts.FlatStyle = FlatStyle.Flat;
			btnReloadPorts.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Bold);
			btnReloadPorts.ForeColor = Color.White;
			btnReloadPorts.Image = (Image)resources.GetObject("btnReloadPorts.Image");
			btnReloadPorts.Location = new Point(143, 17);
			btnReloadPorts.Margin = new Padding(3, 2, 3, 2);
			btnReloadPorts.Name = "btnReloadPorts";
			btnReloadPorts.Size = new Size(21, 21);
			btnReloadPorts.TabIndex = 7;
			btnReloadPorts.UseVisualStyleBackColor = false;
			btnReloadPorts.Click += btnReloadPorts_Click;
			// 
			// combBaudRate
			// 
			combBaudRate.BackColor = Color.FromArgb(22, 21, 35);
			combBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
			combBaudRate.FlatStyle = FlatStyle.Flat;
			combBaudRate.Font = new Font("Franklin Gothic Book", 10.8F);
			combBaudRate.ForeColor = Color.White;
			combBaudRate.FormattingEnabled = true;
			combBaudRate.Location = new Point(188, 44);
			combBaudRate.Margin = new Padding(3, 2, 3, 2);
			combBaudRate.Name = "combBaudRate";
			combBaudRate.Size = new Size(136, 26);
			combBaudRate.TabIndex = 6;
			combBaudRate.SelectedIndexChanged += combBaudRate_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(188, 17);
			label4.Name = "label4";
			label4.Size = new Size(80, 21);
			label4.TabIndex = 5;
			label4.Text = "Baudrate";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(56, 50);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(55, 47);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(55, 52, 75);
			panel2.Location = new Point(37, 108);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(518, 8);
			panel2.TabIndex = 12;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
			label5.ForeColor = Color.White;
			label5.Location = new Point(56, 403);
			label5.Name = "label5";
			label5.Size = new Size(84, 21);
			label5.TabIndex = 13;
			label5.Text = "Response";
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(55, 52, 75);
			panel3.Controls.Add(txtboxResp);
			panel3.Location = new Point(37, 434);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(518, 82);
			panel3.TabIndex = 13;
			// 
			// txtboxResp
			// 
			txtboxResp.BackColor = Color.FromArgb(55, 52, 75);
			txtboxResp.BorderStyle = BorderStyle.None;
			txtboxResp.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtboxResp.ForeColor = Color.White;
			txtboxResp.Location = new Point(9, 22);
			txtboxResp.Margin = new Padding(3, 2, 3, 2);
			txtboxResp.Name = "txtboxResp";
			txtboxResp.Size = new Size(498, 17);
			txtboxResp.TabIndex = 14;
			// 
			// lblParamValue
			// 
			lblParamValue.AutoSize = true;
			lblParamValue.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
			lblParamValue.ForeColor = Color.White;
			lblParamValue.Location = new Point(297, 288);
			lblParamValue.Name = "lblParamValue";
			lblParamValue.Size = new Size(106, 21);
			lblParamValue.TabIndex = 14;
			lblParamValue.Text = "Param Value";
			// 
			// panelParamValue
			// 
			panelParamValue.BackColor = Color.FromArgb(55, 52, 75);
			panelParamValue.Controls.Add(textboxParamValue);
			panelParamValue.Location = new Point(297, 321);
			panelParamValue.Margin = new Padding(3, 2, 3, 2);
			panelParamValue.Name = "panelParamValue";
			panelParamValue.Size = new Size(233, 26);
			panelParamValue.TabIndex = 15;
			// 
			// textboxParamValue
			// 
			textboxParamValue.BackColor = Color.FromArgb(55, 52, 75);
			textboxParamValue.BorderStyle = BorderStyle.None;
			textboxParamValue.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textboxParamValue.ForeColor = Color.White;
			textboxParamValue.Location = new Point(5, 5);
			textboxParamValue.Margin = new Padding(3, 2, 3, 2);
			textboxParamValue.Name = "textboxParamValue";
			textboxParamValue.Size = new Size(222, 17);
			textboxParamValue.TabIndex = 15;
			// 
			// lblMessages
			// 
			lblMessages.AutoSize = true;
			lblMessages.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
			lblMessages.ForeColor = Color.Gray;
			lblMessages.Location = new Point(56, 13);
			lblMessages.Name = "lblMessages";
			lblMessages.Size = new Size(0, 21);
			lblMessages.TabIndex = 8;
			lblMessages.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnDefaultAddressing
			// 
			btnDefaultAddressing.BackColor = Color.FromArgb(240, 43, 83);
			btnDefaultAddressing.FlatAppearance.BorderSize = 0;
			btnDefaultAddressing.FlatStyle = FlatStyle.Flat;
			btnDefaultAddressing.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Bold);
			btnDefaultAddressing.ForeColor = Color.White;
			btnDefaultAddressing.Location = new Point(274, 79);
			btnDefaultAddressing.Margin = new Padding(3, 2, 3, 2);
			btnDefaultAddressing.Name = "btnDefaultAddressing";
			btnDefaultAddressing.Size = new Size(219, 27);
			btnDefaultAddressing.TabIndex = 9;
			btnDefaultAddressing.Text = "Default Addressing";
			btnDefaultAddressing.UseVisualStyleBackColor = false;
			btnDefaultAddressing.Click += btnDefaultAddressing_Click;
			// 
			// Interfaz
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(33, 31, 45);
			ClientSize = new Size(588, 539);
			Controls.Add(lblMessages);
			Controls.Add(panelParamValue);
			Controls.Add(lblParamValue);
			Controls.Add(panel3);
			Controls.Add(label5);
			Controls.Add(panel2);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Controls.Add(combCommands);
			Controls.Add(label3);
			Controls.Add(btnSend);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			Name = "Interfaz";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DLL App";
			Load += Interfaz_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panelParamValue.ResumeLayout(false);
			panelParamValue.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Button btnSend;
        private Label label2;
        private ComboBox combPorts;
        private Button btnOpen;
        private Button btnClose;
        private Label label3;
        private ComboBox combCommands;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private TextBox txtboxResp;
        private Label label4;
        private ComboBox combBaudRate;
        private Label lblParamValue;
        private Panel panelParamValue;
        private TextBox textboxParamValue;
        private Button btnReloadPorts;
        private Label lblMessages;
        private Button btnHandshake;
		private Button btnDefaultAddressing;
	}
}
