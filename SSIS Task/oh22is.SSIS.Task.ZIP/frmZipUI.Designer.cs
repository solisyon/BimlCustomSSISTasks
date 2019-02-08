namespace oh22is.DTS.Task.ZIP
{
    partial class frmZipUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZipUI));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tcConfiguration = new System.Windows.Forms.TabControl();
            this.tpProperties = new System.Windows.Forms.TabPage();
            this.cbAESKeySize = new System.Windows.Forms.ComboBox();
            this.nudZipLevel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbZip64 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFileFolder = new System.Windows.Forms.ComboBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodeplex = new System.Windows.Forms.Label();
            this.llblGitHub = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fileInput = new System.Windows.Forms.OpenFileDialog();
            this.folderInput = new System.Windows.Forms.FolderBrowserDialog();
            this.folderOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.fileOutput = new System.Windows.Forms.SaveFileDialog();
            this.tcConfiguration.SuspendLayout();
            this.tpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZipLevel)).BeginInit();
            this.tpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(266, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tcConfiguration
            // 
            this.tcConfiguration.Controls.Add(this.tpProperties);
            this.tcConfiguration.Controls.Add(this.tpInfo);
            this.tcConfiguration.Location = new System.Drawing.Point(12, 12);
            this.tcConfiguration.Name = "tcConfiguration";
            this.tcConfiguration.SelectedIndex = 0;
            this.tcConfiguration.Size = new System.Drawing.Size(410, 383);
            this.tcConfiguration.TabIndex = 2;
            // 
            // tpProperties
            // 
            this.tpProperties.Controls.Add(this.cbAESKeySize);
            this.tpProperties.Controls.Add(this.nudZipLevel);
            this.tpProperties.Controls.Add(this.label8);
            this.tpProperties.Controls.Add(this.cbZip64);
            this.tpProperties.Controls.Add(this.label7);
            this.tpProperties.Controls.Add(this.label6);
            this.tpProperties.Controls.Add(this.txtPassword);
            this.tpProperties.Controls.Add(this.label5);
            this.tpProperties.Controls.Add(this.cbFileFolder);
            this.tpProperties.Controls.Add(this.btnOutput);
            this.tpProperties.Controls.Add(this.btnInput);
            this.tpProperties.Controls.Add(this.label4);
            this.tpProperties.Controls.Add(this.txtOutput);
            this.tpProperties.Controls.Add(this.label3);
            this.tpProperties.Controls.Add(this.txtInput);
            this.tpProperties.Controls.Add(this.label1);
            this.tpProperties.Controls.Add(this.cbAction);
            this.tpProperties.Location = new System.Drawing.Point(4, 22);
            this.tpProperties.Name = "tpProperties";
            this.tpProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tpProperties.Size = new System.Drawing.Size(402, 357);
            this.tpProperties.TabIndex = 0;
            this.tpProperties.Text = "Properties";
            this.tpProperties.UseVisualStyleBackColor = true;
            // 
            // cbAESKeySize
            // 
            this.cbAESKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAESKeySize.FormattingEnabled = true;
            this.cbAESKeySize.Items.AddRange(new object[] {
            "0",
            "128",
            "256"});
            this.cbAESKeySize.Location = new System.Drawing.Point(87, 171);
            this.cbAESKeySize.Name = "cbAESKeySize";
            this.cbAESKeySize.Size = new System.Drawing.Size(309, 21);
            this.cbAESKeySize.TabIndex = 16;
            // 
            // nudZipLevel
            // 
            this.nudZipLevel.Location = new System.Drawing.Point(87, 120);
            this.nudZipLevel.Margin = new System.Windows.Forms.Padding(2);
            this.nudZipLevel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudZipLevel.Name = "nudZipLevel";
            this.nudZipLevel.Size = new System.Drawing.Size(89, 20);
            this.nudZipLevel.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ZIP Level:";
            // 
            // cbZip64
            // 
            this.cbZip64.AutoSize = true;
            this.cbZip64.Location = new System.Drawing.Point(87, 197);
            this.cbZip64.Margin = new System.Windows.Forms.Padding(2);
            this.cbZip64.Name = "cbZip64";
            this.cbZip64.Size = new System.Drawing.Size(77, 17);
            this.cbZip64.TabIndex = 13;
            this.cbZip64.Text = "Use ZIP64";
            this.cbZip64.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "AES Key Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(87, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(309, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "File/Folder:";
            // 
            // cbFileFolder
            // 
            this.cbFileFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileFolder.FormattingEnabled = true;
            this.cbFileFolder.Items.AddRange(new object[] {
            "FILE",
            "FOLDER"});
            this.cbFileFolder.Location = new System.Drawing.Point(87, 45);
            this.cbFileFolder.Name = "cbFileFolder";
            this.cbFileFolder.Size = new System.Drawing.Size(309, 21);
            this.cbFileFolder.TabIndex = 7;
            this.cbFileFolder.SelectedIndexChanged += new System.EventHandler(this.cbFileFolder_SelectedIndexChanged);
            // 
            // btnOutput
            // 
            this.btnOutput.Enabled = false;
            this.btnOutput.Location = new System.Drawing.Point(357, 96);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(39, 23);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.Location = new System.Drawing.Point(357, 70);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(39, 23);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "...";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(87, 98);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(266, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(87, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(266, 20);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Action:";
            // 
            // cbAction
            // 
            this.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "ZIP",
            "UNZIP"});
            this.cbAction.Location = new System.Drawing.Point(87, 18);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(309, 21);
            this.cbAction.TabIndex = 0;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.pictureBox4);
            this.tpInfo.Controls.Add(this.pictureBox3);
            this.tpInfo.Controls.Add(this.label2);
            this.tpInfo.Controls.Add(this.lblCodeplex);
            this.tpInfo.Controls.Add(this.llblGitHub);
            this.tpInfo.Controls.Add(this.pictureBox2);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Size = new System.Drawing.Size(402, 357);
            this.tpInfo.TabIndex = 2;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::oh22is.DTS.Task.ZIP.Properties.Resources.oh22information_quer_200_transp;
            this.pictureBox4.Location = new System.Drawing.Point(19, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::oh22is.DTS.Task.ZIP.Properties.Resources.logo_solisyon;
            this.pictureBox3.Location = new System.Drawing.Point(206, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "This application was developed in cooperation with";
            // 
            // lblCodeplex
            // 
            this.lblCodeplex.AutoSize = true;
            this.lblCodeplex.Location = new System.Drawing.Point(142, 34);
            this.lblCodeplex.Name = "lblCodeplex";
            this.lblCodeplex.Size = new System.Drawing.Size(161, 26);
            this.lblCodeplex.TabIndex = 5;
            this.lblCodeplex.Text = "This project is hosted on GitHub \r\nand licensed under MS-PL.";
            // 
            // llblGitHub
            // 
            this.llblGitHub.AutoSize = true;
            this.llblGitHub.Location = new System.Drawing.Point(142, 70);
            this.llblGitHub.Name = "llblGitHub";
            this.llblGitHub.Size = new System.Drawing.Size(153, 13);
            this.llblGitHub.TabIndex = 4;
            this.llblGitHub.TabStop = true;
            this.llblGitHub.Text = "https://github.com/TEitelberg/";
            this.llblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGitHub_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::oh22is.DTS.Task.ZIP.Properties.Resources.GitHub;
            this.pictureBox2.Location = new System.Drawing.Point(15, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // fileInput
            // 
            this.fileInput.Filter = "All files|*.*";
            // 
            // fileOutput
            // 
            this.fileOutput.Filter = "ZIP file|*.zip";
            // 
            // frmZipUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 430);
            this.Controls.Add(this.tcConfiguration);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(448, 469);
            this.MinimumSize = new System.Drawing.Size(448, 469);
            this.Name = "frmZipUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSIS ZIP Task";
            this.Load += new System.EventHandler(this.frmZipUI_Load);
            this.tcConfiguration.ResumeLayout(false);
            this.tpProperties.ResumeLayout(false);
            this.tpProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZipLevel)).EndInit();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tcConfiguration;
        private System.Windows.Forms.TabPage tpProperties;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label lblCodeplex;
        internal System.Windows.Forms.LinkLabel llblGitHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFileFolder;
        private System.Windows.Forms.OpenFileDialog fileInput;
        private System.Windows.Forms.FolderBrowserDialog folderInput;
        private System.Windows.Forms.FolderBrowserDialog folderOutput;
        private System.Windows.Forms.SaveFileDialog fileOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbZip64;
        private System.Windows.Forms.NumericUpDown nudZipLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAESKeySize;
    }
}