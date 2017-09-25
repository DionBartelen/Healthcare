namespace DoctorApplicatie
{
    partial class DoctorApplication_Session
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
            this.ConectedSessionsListCombo = new System.Windows.Forms.ComboBox();
            this.ConnectedSessionsListLbl = new System.Windows.Forms.Label();
            this.TrainingLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.messageLbl = new System.Windows.Forms.Label();
            this.sendToClientBtn = new System.Windows.Forms.Button();
            this.toAllBtn = new System.Windows.Forms.Button();
            this.setPowerLbl = new System.Windows.Forms.Label();
            this.setPowerTxt = new System.Windows.Forms.TextBox();
            this.setPowerBtn = new System.Windows.Forms.Button();
            this.getPastSessions = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.getPastDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConectedSessionsListCombo
            // 
            this.ConectedSessionsListCombo.FormattingEnabled = true;
            this.ConectedSessionsListCombo.Location = new System.Drawing.Point(173, 31);
            this.ConectedSessionsListCombo.Name = "ConectedSessionsListCombo";
            this.ConectedSessionsListCombo.Size = new System.Drawing.Size(162, 24);
            this.ConectedSessionsListCombo.TabIndex = 0;
            // 
            // ConnectedSessionsListLbl
            // 
            this.ConnectedSessionsListLbl.AutoSize = true;
            this.ConnectedSessionsListLbl.Location = new System.Drawing.Point(13, 37);
            this.ConnectedSessionsListLbl.Name = "ConnectedSessionsListLbl";
            this.ConnectedSessionsListLbl.Size = new System.Drawing.Size(125, 17);
            this.ConnectedSessionsListLbl.TabIndex = 1;
            this.ConnectedSessionsListLbl.Text = "ConectedSessions";
            // 
            // TrainingLbl
            // 
            this.TrainingLbl.AutoSize = true;
            this.TrainingLbl.Location = new System.Drawing.Point(16, 76);
            this.TrainingLbl.Name = "TrainingLbl";
            this.TrainingLbl.Size = new System.Drawing.Size(60, 17);
            this.TrainingLbl.TabIndex = 2;
            this.TrainingLbl.Text = "Training";
            this.TrainingLbl.Click += new System.EventHandler(this.TrainingLbl_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(173, 76);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(260, 76);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(19, 156);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(119, 22);
            this.messageTxt.TabIndex = 5;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(16, 136);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(69, 17);
            this.messageLbl.TabIndex = 6;
            this.messageLbl.Text = "message:";
            // 
            // sendToClientBtn
            // 
            this.sendToClientBtn.Location = new System.Drawing.Point(173, 154);
            this.sendToClientBtn.Name = "sendToClientBtn";
            this.sendToClientBtn.Size = new System.Drawing.Size(75, 25);
            this.sendToClientBtn.TabIndex = 7;
            this.sendToClientBtn.Text = "toClient";
            this.sendToClientBtn.UseVisualStyleBackColor = true;
            this.sendToClientBtn.Click += new System.EventHandler(this.sendToClientBtn_Click);
            // 
            // toAllBtn
            // 
            this.toAllBtn.Location = new System.Drawing.Point(260, 156);
            this.toAllBtn.Name = "toAllBtn";
            this.toAllBtn.Size = new System.Drawing.Size(75, 23);
            this.toAllBtn.TabIndex = 8;
            this.toAllBtn.Text = "AllClients";
            this.toAllBtn.UseVisualStyleBackColor = true;
            this.toAllBtn.Click += new System.EventHandler(this.toAllBtn_Click);
            // 
            // setPowerLbl
            // 
            this.setPowerLbl.AutoSize = true;
            this.setPowerLbl.Location = new System.Drawing.Point(16, 212);
            this.setPowerLbl.Name = "setPowerLbl";
            this.setPowerLbl.Size = new System.Drawing.Size(70, 17);
            this.setPowerLbl.TabIndex = 9;
            this.setPowerLbl.Text = "setPower:";
            // 
            // setPowerTxt
            // 
            this.setPowerTxt.Location = new System.Drawing.Point(16, 232);
            this.setPowerTxt.Name = "setPowerTxt";
            this.setPowerTxt.Size = new System.Drawing.Size(122, 22);
            this.setPowerTxt.TabIndex = 10;
            // 
            // setPowerBtn
            // 
            this.setPowerBtn.Location = new System.Drawing.Point(173, 230);
            this.setPowerBtn.Name = "setPowerBtn";
            this.setPowerBtn.Size = new System.Drawing.Size(75, 24);
            this.setPowerBtn.TabIndex = 11;
            this.setPowerBtn.Text = "setPower";
            this.setPowerBtn.UseVisualStyleBackColor = true;
            this.setPowerBtn.Click += new System.EventHandler(this.setPowerBtn_Click);
            // 
            // getPastSessions
            // 
            this.getPastSessions.AutoSize = true;
            this.getPastSessions.Location = new System.Drawing.Point(13, 289);
            this.getPastSessions.Name = "getPastSessions";
            this.getPastSessions.Size = new System.Drawing.Size(96, 17);
            this.getPastSessions.TabIndex = 12;
            this.getPastSessions.Text = "pastSessions:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // getPastDataBtn
            // 
            this.getPastDataBtn.Location = new System.Drawing.Point(173, 309);
            this.getPastDataBtn.Name = "getPastDataBtn";
            this.getPastDataBtn.Size = new System.Drawing.Size(75, 27);
            this.getPastDataBtn.TabIndex = 14;
            this.getPastDataBtn.Text = "getData";
            this.getPastDataBtn.UseVisualStyleBackColor = true;
            this.getPastDataBtn.Click += new System.EventHandler(this.getPastDataBtn_Click);
            // 
            // DoctorApplication_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 479);
            this.Controls.Add(this.getPastDataBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.getPastSessions);
            this.Controls.Add(this.setPowerBtn);
            this.Controls.Add(this.setPowerTxt);
            this.Controls.Add(this.setPowerLbl);
            this.Controls.Add(this.toAllBtn);
            this.Controls.Add(this.sendToClientBtn);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.TrainingLbl);
            this.Controls.Add(this.ConnectedSessionsListLbl);
            this.Controls.Add(this.ConectedSessionsListCombo);
            this.Name = "DoctorApplication_Session";
            this.Text = "DoctorApplication_Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConectedSessionsListCombo;
        private System.Windows.Forms.Label ConnectedSessionsListLbl;
        private System.Windows.Forms.Label TrainingLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button sendToClientBtn;
        private System.Windows.Forms.Button toAllBtn;
        private System.Windows.Forms.Label setPowerLbl;
        private System.Windows.Forms.TextBox setPowerTxt;
        private System.Windows.Forms.Button setPowerBtn;
        private System.Windows.Forms.Label getPastSessions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button getPastDataBtn;
    }
}