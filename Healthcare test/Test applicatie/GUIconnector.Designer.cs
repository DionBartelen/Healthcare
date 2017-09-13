using System.IO.Ports;

namespace Healthcare_test
{
    partial class GUIconnector
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
            this.CommandInput = new System.Windows.Forms.TextBox();
            this.SendInput = new System.Windows.Forms.Button();
            this.replyBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BaudRateText = new System.Windows.Forms.TextBox();
            this.ConnectSerial = new System.Windows.Forms.Button();
            this.ComPortText = new System.Windows.Forms.ComboBox();
            this.Data_Collector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommandInput
            // 
            this.CommandInput.Location = new System.Drawing.Point(45, 351);
            this.CommandInput.Name = "CommandInput";
            this.CommandInput.Size = new System.Drawing.Size(486, 22);
            this.CommandInput.TabIndex = 0;
            // 
            // SendInput
            // 
            this.SendInput.ForeColor = System.Drawing.Color.DarkBlue;
            this.SendInput.Location = new System.Drawing.Point(565, 351);
            this.SendInput.Name = "SendInput";
            this.SendInput.Size = new System.Drawing.Size(75, 23);
            this.SendInput.TabIndex = 1;
            this.SendInput.Text = "Send";
            this.SendInput.UseVisualStyleBackColor = true;
            this.SendInput.Click += new System.EventHandler(this.SendInput_Click);
            // 
            // replyBoxText
            // 
            this.replyBoxText.Location = new System.Drawing.Point(45, 83);
            this.replyBoxText.Multiline = true;
            this.replyBoxText.Name = "replyBoxText";
            this.replyBoxText.ReadOnly = true;
            this.replyBoxText.Size = new System.Drawing.Size(486, 238);
            this.replyBoxText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(239, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "BAUD:";
            // 
            // BaudRateText
            // 
            this.BaudRateText.Location = new System.Drawing.Point(295, 20);
            this.BaudRateText.Name = "BaudRateText";
            this.BaudRateText.Size = new System.Drawing.Size(100, 22);
            this.BaudRateText.TabIndex = 6;
            this.BaudRateText.Text = "9600";
            // 
            // ConnectSerial
            // 
            this.ConnectSerial.ForeColor = System.Drawing.Color.DarkBlue;
            this.ConnectSerial.Location = new System.Drawing.Point(441, 16);
            this.ConnectSerial.Name = "ConnectSerial";
            this.ConnectSerial.Size = new System.Drawing.Size(90, 31);
            this.ConnectSerial.TabIndex = 7;
            this.ConnectSerial.Text = "CONNECT";
            this.ConnectSerial.UseVisualStyleBackColor = true;
            this.ConnectSerial.Click += new System.EventHandler(this.ConnectSerial_Click);
            // 
            // ComPortText
            // 
            this.ComPortText.FormattingEnabled = true;
            this.ComPortText.Items.AddRange(new object[] {
            "Simulator"});
            this.ComPortText.Location = new System.Drawing.Point(91, 17);
            this.ComPortText.Name = "ComPortText";
            this.ComPortText.Size = new System.Drawing.Size(121, 24);
            this.ComPortText.TabIndex = 8;
            this.ComPortText.SelectedIndexChanged += new System.EventHandler(this.ComPortText_SelectedIndexChanged);
            // 
            // Data_Collector
            // 
            this.Data_Collector.Enabled = false;
            this.Data_Collector.ForeColor = System.Drawing.Color.DarkBlue;
            this.Data_Collector.Location = new System.Drawing.Point(565, 83);
            this.Data_Collector.Name = "Data_Collector";
            this.Data_Collector.Size = new System.Drawing.Size(94, 28);
            this.Data_Collector.TabIndex = 9;
            this.Data_Collector.Text = "current data ";
            this.Data_Collector.UseVisualStyleBackColor = true;
            this.Data_Collector.Click += new System.EventHandler(this.Data_Collector_Click);
            // 
            // GUIconnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.Data_Collector);
            this.Controls.Add(this.ComPortText);
            this.Controls.Add(this.ConnectSerial);
            this.Controls.Add(this.BaudRateText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replyBoxText);
            this.Controls.Add(this.SendInput);
            this.Controls.Add(this.CommandInput);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "GUIconnector";
            this.Text = "Remote Healthcare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.GUIconnector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommandInput;
        private System.Windows.Forms.Button SendInput;
        private System.Windows.Forms.TextBox replyBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BaudRateText;
        private System.Windows.Forms.Button ConnectSerial;
        private System.Windows.Forms.ComboBox ComPortText;
        private System.Windows.Forms.Button Data_Collector;
    }
}

