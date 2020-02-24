namespace Bewerbung
{
    partial class Form1
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
            this.txtJobTitel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPortal = new System.Windows.Forms.TextBox();
            this.btnParseURL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesrip = new System.Windows.Forms.TextBox();
            this.dtApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.btnCreateResume = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chbCertificates = new System.Windows.Forms.CheckBox();
            this.chbCoverLetter = new System.Windows.Forms.CheckBox();
            this.chbResume = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.txtCetrficatesPath = new System.Windows.Forms.TextBox();
            this.txtCoverLetterPath = new System.Windows.Forms.TextBox();
            this.txtResumePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBaseFolderPath = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJobTitel
            // 
            this.txtJobTitel.Location = new System.Drawing.Point(96, 41);
            this.txtJobTitel.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobTitel.Name = "txtJobTitel";
            this.txtJobTitel.Size = new System.Drawing.Size(533, 23);
            this.txtJobTitel.TabIndex = 0;
            this.txtJobTitel.Text = "C# Developer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Titel";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 379);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExportPDF);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtPortal);
            this.tabPage1.Controls.Add(this.btnParseURL);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtDesrip);
            this.tabPage1.Controls.Add(this.dtApplicationDate);
            this.tabPage1.Controls.Add(this.txtCompanyAddress);
            this.tabPage1.Controls.Add(this.btnCreateResume);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCompanyEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtURL);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCompanyName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtJobTitel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bewerbung Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(394, 285);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(76, 30);
            this.btnExportPDF.TabIndex = 21;
            this.btnExportPDF.Text = "Export PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.BtnExportPDF_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Portal";
            // 
            // txtPortal
            // 
            this.txtPortal.Location = new System.Drawing.Point(96, 250);
            this.txtPortal.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortal.Name = "txtPortal";
            this.txtPortal.Size = new System.Drawing.Size(234, 23);
            this.txtPortal.TabIndex = 19;
            // 
            // btnParseURL
            // 
            this.btnParseURL.Location = new System.Drawing.Point(565, 4);
            this.btnParseURL.Name = "btnParseURL";
            this.btnParseURL.Size = new System.Drawing.Size(74, 30);
            this.btnParseURL.TabIndex = 18;
            this.btnParseURL.Text = "Parse";
            this.btnParseURL.UseVisualStyleBackColor = true;
            this.btnParseURL.Click += new System.EventHandler(this.btnParseURL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 222);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Descrip";
            // 
            // txtDesrip
            // 
            this.txtDesrip.Location = new System.Drawing.Point(96, 219);
            this.txtDesrip.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesrip.Name = "txtDesrip";
            this.txtDesrip.Size = new System.Drawing.Size(533, 23);
            this.txtDesrip.TabIndex = 15;
            // 
            // dtApplicationDate
            // 
            this.dtApplicationDate.Location = new System.Drawing.Point(478, 289);
            this.dtApplicationDate.Name = "dtApplicationDate";
            this.dtApplicationDate.Size = new System.Drawing.Size(151, 23);
            this.dtApplicationDate.TabIndex = 14;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(96, 109);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyAddress.Multiline = true;
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(533, 68);
            this.txtCompanyAddress.TabIndex = 6;
            this.txtCompanyAddress.Text = "87263 Hannover";
            // 
            // btnCreateResume
            // 
            this.btnCreateResume.Location = new System.Drawing.Point(96, 285);
            this.btnCreateResume.Name = "btnCreateResume";
            this.btnCreateResume.Size = new System.Drawing.Size(130, 30);
            this.btnCreateResume.TabIndex = 13;
            this.btnCreateResume.Text = "Crate Resume";
            this.btnCreateResume.UseVisualStyleBackColor = true;
            this.btnCreateResume.Click += new System.EventHandler(this.btnCreateResume_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(232, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "LinkedIn",
            "Email",
            "Online"});
            this.cmbType.Location = new System.Drawing.Point(415, 188);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(214, 24);
            this.cmbType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.Location = new System.Drawing.Point(96, 188);
            this.txtCompanyEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Size = new System.Drawing.Size(234, 23);
            this.txtCompanyEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(96, 7);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(462, 23);
            this.txtURL.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(96, 75);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(533, 23);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.Text = "Hays";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chbCertificates);
            this.tabPage2.Controls.Add(this.chbCoverLetter);
            this.tabPage2.Controls.Add(this.chbResume);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtOutputFilePath);
            this.tabPage2.Controls.Add(this.txtCetrficatesPath);
            this.tabPage2.Controls.Add(this.txtCoverLetterPath);
            this.tabPage2.Controls.Add(this.txtResumePath);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtBaseFolderPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chbCertificates
            // 
            this.chbCertificates.AutoSize = true;
            this.chbCertificates.Location = new System.Drawing.Point(10, 142);
            this.chbCertificates.Name = "chbCertificates";
            this.chbCertificates.Size = new System.Drawing.Size(97, 21);
            this.chbCertificates.TabIndex = 18;
            this.chbCertificates.Text = "Certificates";
            this.chbCertificates.UseVisualStyleBackColor = true;
            // 
            // chbCoverLetter
            // 
            this.chbCoverLetter.AutoSize = true;
            this.chbCoverLetter.Checked = true;
            this.chbCoverLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCoverLetter.Location = new System.Drawing.Point(10, 98);
            this.chbCoverLetter.Name = "chbCoverLetter";
            this.chbCoverLetter.Size = new System.Drawing.Size(105, 21);
            this.chbCoverLetter.TabIndex = 17;
            this.chbCoverLetter.Text = "Cover Letter";
            this.chbCoverLetter.UseVisualStyleBackColor = true;
            // 
            // chbResume
            // 
            this.chbResume.AutoSize = true;
            this.chbResume.Checked = true;
            this.chbResume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbResume.Location = new System.Drawing.Point(9, 59);
            this.chbResume.Name = "chbResume";
            this.chbResume.Size = new System.Drawing.Size(79, 21);
            this.chbResume.TabIndex = 16;
            this.chbResume.Text = "Resume";
            this.chbResume.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Folder Path";
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Location = new System.Drawing.Point(116, 192);
            this.txtOutputFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(492, 23);
            this.txtOutputFilePath.TabIndex = 14;
            this.txtOutputFilePath.Text = "Z:\\Dropbox\\Germany\\Applications.xlsx";
            // 
            // txtCetrficatesPath
            // 
            this.txtCetrficatesPath.Location = new System.Drawing.Point(116, 142);
            this.txtCetrficatesPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtCetrficatesPath.Name = "txtCetrficatesPath";
            this.txtCetrficatesPath.Size = new System.Drawing.Size(492, 23);
            this.txtCetrficatesPath.TabIndex = 12;
            this.txtCetrficatesPath.Text = "Zeugnis-Mojtaba Ashena-V6.docx";
            // 
            // txtCoverLetterPath
            // 
            this.txtCoverLetterPath.Location = new System.Drawing.Point(116, 98);
            this.txtCoverLetterPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoverLetterPath.Name = "txtCoverLetterPath";
            this.txtCoverLetterPath.Size = new System.Drawing.Size(492, 23);
            this.txtCoverLetterPath.TabIndex = 10;
            this.txtCoverLetterPath.Text = "Anschreiben-Mojtaba Ashena-V7.docx";
            // 
            // txtResumePath
            // 
            this.txtResumePath.Location = new System.Drawing.Point(116, 57);
            this.txtResumePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtResumePath.Name = "txtResumePath";
            this.txtResumePath.Size = new System.Drawing.Size(492, 23);
            this.txtResumePath.TabIndex = 8;
            this.txtResumePath.Text = "Lebenslauf-Mojtaba Ashena-V6.docx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Folder Path";
            // 
            // txtBaseFolderPath
            // 
            this.txtBaseFolderPath.Location = new System.Drawing.Point(116, 16);
            this.txtBaseFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseFolderPath.Name = "txtBaseFolderPath";
            this.txtBaseFolderPath.Size = new System.Drawing.Size(492, 23);
            this.txtBaseFolderPath.TabIndex = 6;
            this.txtBaseFolderPath.Text = "C:\\Projects\\Bewerbung";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 381);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(61, 17);
            this.lblPrompt.TabIndex = 3;
            this.lblPrompt.Text = "Prompt :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 422);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bewerbung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCreateResume;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompanyEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBaseFolderPath;
        private System.Windows.Forms.TextBox txtCetrficatesPath;
        private System.Windows.Forms.TextBox txtCoverLetterPath;
        private System.Windows.Forms.TextBox txtResumePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesrip;
        private System.Windows.Forms.DateTimePicker dtApplicationDate;
        private System.Windows.Forms.Button btnParseURL;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.CheckBox chbCertificates;
        private System.Windows.Forms.CheckBox chbCoverLetter;
        private System.Windows.Forms.CheckBox chbResume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPortal;
        private System.Windows.Forms.Button btnExportPDF;
    }
}

