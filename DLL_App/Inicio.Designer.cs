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
            combType = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            txtboxResp = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 69);
            label1.Name = "label1";
            label1.Size = new Size(140, 47);
            label1.TabIndex = 0;
            label1.Text = "AMI DLL";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(240, 43, 83);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(524, 418);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(97, 44);
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
            label2.Location = new Point(37, 31);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
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
            combPorts.Location = new Point(106, 31);
            combPorts.Name = "combPorts";
            combPorts.Size = new Size(183, 31);
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
            btnOpen.Location = new Point(318, 27);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(65, 36);
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
            btnClose.Location = new Point(406, 27);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(65, 36);
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
            label3.Location = new Point(370, 317);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
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
            combCommands.Location = new Point(370, 361);
            combCommands.Name = "combCommands";
            combCommands.Size = new Size(178, 31);
            combCommands.TabIndex = 7;
            combCommands.SelectedIndexChanged += combCommands_SelectedIndexChanged;
            // 
            // combType
            // 
            combType.BackColor = Color.FromArgb(22, 21, 35);
            combType.DropDownStyle = ComboBoxStyle.DropDownList;
            combType.FlatStyle = FlatStyle.Flat;
            combType.Font = new Font("Franklin Gothic Book", 10.8F);
            combType.ForeColor = Color.White;
            combType.FormattingEnabled = true;
            combType.Location = new Point(73, 361);
            combType.Name = "combType";
            combType.Size = new Size(178, 31);
            combType.TabIndex = 8;
            combType.SelectedIndexChanged += combType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(73, 317);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 9;
            label4.Text = "Cmd Type";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 21, 34);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(combPorts);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Location = new Point(52, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 93);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 52, 75);
            panel2.Location = new Point(42, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 11);
            panel2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(64, 475);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 13;
            label5.Text = "Response";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(55, 52, 75);
            panel3.Controls.Add(txtboxResp);
            panel3.Location = new Point(42, 516);
            panel3.Name = "panel3";
            panel3.Size = new Size(592, 110);
            panel3.TabIndex = 13;
            // 
            // txtboxResp
            // 
            txtboxResp.BackColor = Color.FromArgb(55, 52, 75);
            txtboxResp.BorderStyle = BorderStyle.None;
            txtboxResp.Font = new Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxResp.ForeColor = Color.White;
            txtboxResp.Location = new Point(22, 23);
            txtboxResp.Name = "txtboxResp";
            txtboxResp.Size = new Size(518, 21);
            txtboxResp.TabIndex = 14;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 31, 45);
            ClientSize = new Size(682, 667);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(combType);
            Controls.Add(panel1);
            Controls.Add(combCommands);
            Controls.Add(label3);
            Controls.Add(btnSend);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private ComboBox combType;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private TextBox txtboxResp;
    }
}
