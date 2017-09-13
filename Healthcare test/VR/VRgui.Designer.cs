namespace Healthcare_test.VR
{
    partial class VRgui
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
            this.connect_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sessions = new System.Windows.Forms.ComboBox();
            this.TunnelStatus = new System.Windows.Forms.Label();
            this.ChangeTerain = new System.Windows.Forms.Button();
            this.RefreshClients = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect_Button
            // 
            this.connect_Button.Location = new System.Drawing.Point(268, 16);
            this.connect_Button.Margin = new System.Windows.Forms.Padding(2);
            this.connect_Button.Name = "connect_Button";
            this.connect_Button.Size = new System.Drawing.Size(56, 19);
            this.connect_Button.TabIndex = 5;
            this.connect_Button.Text = "connect";
            this.connect_Button.UseVisualStyleBackColor = true;
            this.connect_Button.Click += new System.EventHandler(this.connect_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Session name";
            // 
            // sessions
            // 
            this.sessions.FormattingEnabled = true;
            this.sessions.Location = new System.Drawing.Point(86, 16);
            this.sessions.Margin = new System.Windows.Forms.Padding(2);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(168, 21);
            this.sessions.TabIndex = 3;
            // 
            // TunnelStatus
            // 
            this.TunnelStatus.AutoSize = true;
            this.TunnelStatus.Location = new System.Drawing.Point(358, 16);
            this.TunnelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TunnelStatus.Name = "TunnelStatus";
            this.TunnelStatus.Size = new System.Drawing.Size(78, 13);
            this.TunnelStatus.TabIndex = 6;
            this.TunnelStatus.Text = "Not connected";
            // 
            // ChangeTerain
            // 
            this.ChangeTerain.Location = new System.Drawing.Point(171, 240);
            this.ChangeTerain.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeTerain.Name = "ChangeTerain";
            this.ChangeTerain.Size = new System.Drawing.Size(56, 19);
            this.ChangeTerain.TabIndex = 7;
            this.ChangeTerain.Text = "Time";
            this.ChangeTerain.UseVisualStyleBackColor = true;
            this.ChangeTerain.Click += new System.EventHandler(this.ChangeTerain_Click);
            // 
            // RefreshClients
            // 
            this.RefreshClients.Location = new System.Drawing.Point(453, 16);
            this.RefreshClients.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshClients.Name = "RefreshClients";
            this.RefreshClients.Size = new System.Drawing.Size(56, 19);
            this.RefreshClients.TabIndex = 8;
            this.RefreshClients.Text = "Refresh";
            this.RefreshClients.UseVisualStyleBackColor = true;
            this.RefreshClients.Click += new System.EventHandler(this.RefreshClients_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 239);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VRgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshClients);
            this.Controls.Add(this.ChangeTerain);
            this.Controls.Add(this.TunnelStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connect_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VRgui";
            this.Text = "VRgui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VRgui_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VRgui_FormClosed);
            this.Load += new System.EventHandler(this.VRgui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sessions;
        private System.Windows.Forms.Label TunnelStatus;
        private System.Windows.Forms.Button ChangeTerain;
        private System.Windows.Forms.Button RefreshClients;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}