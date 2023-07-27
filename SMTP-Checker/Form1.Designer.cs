namespace SMTP_Checker
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtsmtpAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtsenderEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSenderEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtreceiverEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenderPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.chkEnableSsl = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkUseDefaultCredentials = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtport = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(97, 138);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "smtpAddress";
            // 
            // txtsmtpAddress
            // 
            this.txtsmtpAddress.Depth = 0;
            this.txtsmtpAddress.Hint = "";
            this.txtsmtpAddress.Location = new System.Drawing.Point(241, 138);
            this.txtsmtpAddress.MaxLength = 32767;
            this.txtsmtpAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsmtpAddress.Name = "txtsmtpAddress";
            this.txtsmtpAddress.PasswordChar = '\0';
            this.txtsmtpAddress.SelectedText = "";
            this.txtsmtpAddress.SelectionLength = 0;
            this.txtsmtpAddress.SelectionStart = 0;
            this.txtsmtpAddress.Size = new System.Drawing.Size(226, 23);
            this.txtsmtpAddress.TabIndex = 1;
            this.txtsmtpAddress.TabStop = false;
            this.txtsmtpAddress.UseSystemPasswordChar = false;
            // 
            // txtsenderEmail
            // 
            this.txtsenderEmail.Depth = 0;
            this.txtsenderEmail.Hint = "";
            this.txtsenderEmail.Location = new System.Drawing.Point(241, 233);
            this.txtsenderEmail.MaxLength = 32767;
            this.txtsenderEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsenderEmail.Name = "txtsenderEmail";
            this.txtsenderEmail.PasswordChar = '\0';
            this.txtsenderEmail.SelectedText = "";
            this.txtsenderEmail.SelectionLength = 0;
            this.txtsenderEmail.SelectionStart = 0;
            this.txtsenderEmail.Size = new System.Drawing.Size(226, 23);
            this.txtsenderEmail.TabIndex = 3;
            this.txtsenderEmail.TabStop = false;
            this.txtsenderEmail.UseSystemPasswordChar = false;
            // 
            // lblSenderEmail
            // 
            this.lblSenderEmail.AutoSize = true;
            this.lblSenderEmail.Depth = 0;
            this.lblSenderEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSenderEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSenderEmail.Location = new System.Drawing.Point(97, 233);
            this.lblSenderEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSenderEmail.Name = "lblSenderEmail";
            this.lblSenderEmail.Size = new System.Drawing.Size(93, 19);
            this.lblSenderEmail.TabIndex = 2;
            this.lblSenderEmail.Text = "SenderEmail";
            // 
            // txtreceiverEmail
            // 
            this.txtreceiverEmail.Depth = 0;
            this.txtreceiverEmail.Hint = "";
            this.txtreceiverEmail.Location = new System.Drawing.Point(241, 324);
            this.txtreceiverEmail.MaxLength = 32767;
            this.txtreceiverEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtreceiverEmail.Name = "txtreceiverEmail";
            this.txtreceiverEmail.PasswordChar = '\0';
            this.txtreceiverEmail.SelectedText = "";
            this.txtreceiverEmail.SelectionLength = 0;
            this.txtreceiverEmail.SelectionStart = 0;
            this.txtreceiverEmail.Size = new System.Drawing.Size(226, 23);
            this.txtreceiverEmail.TabIndex = 5;
            this.txtreceiverEmail.TabStop = false;
            this.txtreceiverEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(97, 324);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(100, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "receiverEmail";
            // 
            // txtSenderPassword
            // 
            this.txtSenderPassword.Depth = 0;
            this.txtSenderPassword.Hint = "";
            this.txtSenderPassword.Location = new System.Drawing.Point(241, 278);
            this.txtSenderPassword.MaxLength = 32767;
            this.txtSenderPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenderPassword.Name = "txtSenderPassword";
            this.txtSenderPassword.PasswordChar = '\0';
            this.txtSenderPassword.SelectedText = "";
            this.txtSenderPassword.SelectionLength = 0;
            this.txtSenderPassword.SelectionStart = 0;
            this.txtSenderPassword.Size = new System.Drawing.Size(226, 23);
            this.txtSenderPassword.TabIndex = 7;
            this.txtSenderPassword.TabStop = false;
            this.txtSenderPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(97, 232);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(0, 19);
            this.materialLabel2.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(97, 282);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(121, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "SenderPassword";
            // 
            // chkEnableSsl
            // 
            this.chkEnableSsl.AutoSize = true;
            this.chkEnableSsl.Depth = 0;
            this.chkEnableSsl.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEnableSsl.Location = new System.Drawing.Point(526, 151);
            this.chkEnableSsl.Margin = new System.Windows.Forms.Padding(0);
            this.chkEnableSsl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEnableSsl.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEnableSsl.Name = "chkEnableSsl";
            this.chkEnableSsl.Ripple = true;
            this.chkEnableSsl.Size = new System.Drawing.Size(90, 30);
            this.chkEnableSsl.TabIndex = 9;
            this.chkEnableSsl.Text = "EnableSsl";
            this.chkEnableSsl.UseVisualStyleBackColor = true;
            // 
            // chkUseDefaultCredentials
            // 
            this.chkUseDefaultCredentials.AutoSize = true;
            this.chkUseDefaultCredentials.Depth = 0;
            this.chkUseDefaultCredentials.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkUseDefaultCredentials.Location = new System.Drawing.Point(526, 199);
            this.chkUseDefaultCredentials.Margin = new System.Windows.Forms.Padding(0);
            this.chkUseDefaultCredentials.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUseDefaultCredentials.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUseDefaultCredentials.Name = "chkUseDefaultCredentials";
            this.chkUseDefaultCredentials.Ripple = true;
            this.chkUseDefaultCredentials.Size = new System.Drawing.Size(168, 30);
            this.chkUseDefaultCredentials.TabIndex = 10;
            this.chkUseDefaultCredentials.Text = "UseDefaultCredentials";
            this.chkUseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // txtport
            // 
            this.txtport.Depth = 0;
            this.txtport.Hint = "";
            this.txtport.Location = new System.Drawing.Point(241, 184);
            this.txtport.MaxLength = 32767;
            this.txtport.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtport.Name = "txtport";
            this.txtport.PasswordChar = '\0';
            this.txtport.SelectedText = "";
            this.txtport.SelectionLength = 0;
            this.txtport.SelectionStart = 0;
            this.txtport.Size = new System.Drawing.Size(226, 23);
            this.txtport.TabIndex = 12;
            this.txtport.TabStop = false;
            this.txtport.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(97, 184);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "port";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(526, 311);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(56, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "SEND";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(293, 83);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(115, 19);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "SMTP - TESTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.chkUseDefaultCredentials);
            this.Controls.Add(this.chkEnableSsl);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtSenderPassword);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtreceiverEmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtsenderEmail);
            this.Controls.Add(this.lblSenderEmail);
            this.Controls.Add(this.txtsmtpAddress);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "SMTP-Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsmtpAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsenderEmail;
        private MaterialSkin.Controls.MaterialLabel lblSenderEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtreceiverEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenderPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox chkEnableSsl;
        private MaterialSkin.Controls.MaterialCheckBox chkUseDefaultCredentials;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtport;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

