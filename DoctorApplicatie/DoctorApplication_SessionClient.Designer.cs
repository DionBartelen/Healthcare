namespace DoctorApplicatie
{
    partial class DoctorApplication_SessionClient
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
            this.setPowerBtn = new System.Windows.Forms.Button();
            this.setPowerTxt = new System.Windows.Forms.TextBox();
            this.setPowerLbl = new System.Windows.Forms.Label();
            this.toAllBtn = new System.Windows.Forms.Button();
            this.sendToClientBtn = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.TrainingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setPowerBtn
            // 
            this.setPowerBtn.BackColor = System.Drawing.SystemColors.Control;
            this.setPowerBtn.Location = new System.Drawing.Point(169, 182);
            this.setPowerBtn.Name = "setPowerBtn";
            this.setPowerBtn.Size = new System.Drawing.Size(84, 24);
            this.setPowerBtn.TabIndex = 18;
            this.setPowerBtn.Text = "setPower";
            this.setPowerBtn.UseVisualStyleBackColor = false;
            // 
            // setPowerTxt
            // 
            this.setPowerTxt.Location = new System.Drawing.Point(9, 182);
            this.setPowerTxt.Name = "setPowerTxt";
            this.setPowerTxt.Size = new System.Drawing.Size(122, 22);
            this.setPowerTxt.TabIndex = 17;
            // 
            // setPowerLbl
            // 
            this.setPowerLbl.AutoSize = true;
            this.setPowerLbl.Location = new System.Drawing.Point(12, 164);
            this.setPowerLbl.Name = "setPowerLbl";
            this.setPowerLbl.Size = new System.Drawing.Size(76, 17);
            this.setPowerLbl.TabIndex = 16;
            this.setPowerLbl.Text = "Set Power:";
            // 
            // toAllBtn
            // 
            this.toAllBtn.BackColor = System.Drawing.SystemColors.Control;
            this.toAllBtn.Location = new System.Drawing.Point(256, 108);
            this.toAllBtn.Name = "toAllBtn";
            this.toAllBtn.Size = new System.Drawing.Size(75, 23);
            this.toAllBtn.TabIndex = 15;
            this.toAllBtn.Text = "AllClients";
            this.toAllBtn.UseVisualStyleBackColor = false;
            // 
            // sendToClientBtn
            // 
            this.sendToClientBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sendToClientBtn.Location = new System.Drawing.Point(169, 106);
            this.sendToClientBtn.Name = "sendToClientBtn";
            this.sendToClientBtn.Size = new System.Drawing.Size(75, 25);
            this.sendToClientBtn.TabIndex = 14;
            this.sendToClientBtn.Text = "toClient";
            this.sendToClientBtn.UseVisualStyleBackColor = false;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(12, 88);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(69, 17);
            this.messageLbl.TabIndex = 13;
            this.messageLbl.Text = "Message:";
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(12, 107);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(119, 22);
            this.messageTxt.TabIndex = 12;
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StopBtn.Location = new System.Drawing.Point(256, 53);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 19;
            this.StopBtn.Text = "stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.Control;
            this.startBtn.Location = new System.Drawing.Point(169, 53);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 21;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = false;
            // 
            // TrainingLbl
            // 
            this.TrainingLbl.AutoSize = true;
            this.TrainingLbl.Location = new System.Drawing.Point(12, 53);
            this.TrainingLbl.Name = "TrainingLbl";
            this.TrainingLbl.Size = new System.Drawing.Size(60, 17);
            this.TrainingLbl.TabIndex = 20;
            this.TrainingLbl.Text = "Training";
            // 
            // DoctorApplication_SessionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 416);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.TrainingLbl);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.setPowerBtn);
            this.Controls.Add(this.setPowerTxt);
            this.Controls.Add(this.setPowerLbl);
            this.Controls.Add(this.toAllBtn);
            this.Controls.Add(this.sendToClientBtn);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.messageTxt);
            this.Name = "DoctorApplication_SessionClient";
            this.Text = "DoctorApplication_SessionClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setPowerBtn;
        private System.Windows.Forms.TextBox setPowerTxt;
        private System.Windows.Forms.Label setPowerLbl;
        private System.Windows.Forms.Button toAllBtn;
        private System.Windows.Forms.Button sendToClientBtn;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label TrainingLbl;
    }
}