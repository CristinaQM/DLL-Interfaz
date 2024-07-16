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
            label1 = new Label();
            label2 = new Label();
            combPorts = new ComboBox();
            btnOpen = new Button();
            btnClose = new Button();
            btnInit = new Button();
            label3 = new Label();
            combCommands = new ComboBox();
            combType = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 0;
            label1.Text = "AMI DLL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 104);
            label2.Name = "label2";
            label2.Size = new Size(41, 23);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // combPorts
            // 
            combPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            combPorts.FormattingEnabled = true;
            combPorts.Location = new Point(137, 105);
            combPorts.Name = "combPorts";
            combPorts.Size = new Size(151, 28);
            combPorts.TabIndex = 2;
            combPorts.SelectedIndexChanged += combPorts_SelectedIndexChanged;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(309, 104);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(63, 29);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(378, 104);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(63, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnInit
            // 
            btnInit.Location = new Point(309, 375);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(122, 44);
            btnInit.TabIndex = 5;
            btnInit.Text = "Init";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 159);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 6;
            label3.Text = "Command";
            // 
            // combCommands
            // 
            combCommands.DropDownStyle = ComboBoxStyle.DropDownList;
            combCommands.FormattingEnabled = true;
            combCommands.Location = new Point(410, 159);
            combCommands.Name = "combCommands";
            combCommands.Size = new Size(151, 28);
            combCommands.TabIndex = 7;
            // 
            // combType
            // 
            combType.DropDownStyle = ComboBoxStyle.DropDownList;
            combType.FormattingEnabled = true;
            combType.Location = new Point(137, 159);
            combType.Name = "combType";
            combType.Size = new Size(151, 28);
            combType.TabIndex = 8;
            combType.SelectedIndexChanged += combType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 159);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 9;
            label4.Text = "Cmd Type";
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(label4);
            Controls.Add(combType);
            Controls.Add(combCommands);
            Controls.Add(label3);
            Controls.Add(btnInit);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(combPorts);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Interfaz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DLL App";
            Load += Interfaz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox combPorts;
        private Button btnOpen;
        private Button btnClose;
        private Button btnInit;
        private Label label3;
        private ComboBox combCommands;
        private ComboBox combType;
        private Label label4;
    }
}
