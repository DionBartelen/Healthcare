namespace WindowsFormsApp1
{
    partial class ClientGUI
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.sign_in_Btn = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.Label();
            this.comportLbl = new System.Windows.Forms.Label();
            this.comportCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(204, 152);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(150, 22);
            this.usernameTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(204, 186);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(150, 22);
            this.passwordTxt.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(17, 152);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(71, 17);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(20, 189);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(68, 17);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "password";
            // 
            // sign_in_Btn
            // 
            this.sign_in_Btn.Location = new System.Drawing.Point(204, 230);
            this.sign_in_Btn.Name = "sign_in_Btn";
            this.sign_in_Btn.Size = new System.Drawing.Size(150, 28);
            this.sign_in_Btn.TabIndex = 4;
            this.sign_in_Btn.Text = "sign in";
            this.sign_in_Btn.UseVisualStyleBackColor = true;
            this.sign_in_Btn.Click += new System.EventHandler(this.sign_in_Btn_Click);
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(461, 230);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(88, 17);
            this.response.TabIndex = 5;
            this.response.Text = "notConected";
            // 
            // comportLbl
            // 
            this.comportLbl.AutoSize = true;
            this.comportLbl.Location = new System.Drawing.Point(20, 117);
            this.comportLbl.Name = "comportLbl";
            this.comportLbl.Size = new System.Drawing.Size(59, 17);
            this.comportLbl.TabIndex = 6;
            this.comportLbl.Text = "comport";
            // 
            // comportCombo
            // 
            this.comportCombo.FormattingEnabled = true;
            this.comportCombo.Location = new System.Drawing.Point(204, 117);
            this.comportCombo.Name = "comportCombo";
            this.comportCombo.Size = new System.Drawing.Size(150, 24);
            this.comportCombo.TabIndex = 7;
            this.comportCombo.SelectedIndexChanged += new System.EventHandler(this.comportCombo_SelectedIndexChanged);
            // 
            // ClientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 406);
            this.Controls.Add(this.comportCombo);
            this.Controls.Add(this.comportLbl);
            this.Controls.Add(this.response);
            this.Controls.Add(this.sign_in_Btn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Name = "ClientGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button sign_in_Btn;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.Label comportLbl;
        private System.Windows.Forms.ComboBox comportCombo;
    }
}

