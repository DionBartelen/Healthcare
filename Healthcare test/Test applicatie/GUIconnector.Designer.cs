﻿using System.IO.Ports;

namespace Healthcare_test
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
            this.commandInput = new System.Windows.Forms.TextBox();
            this.sendInput = new System.Windows.Forms.Button();
            this.replyBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baudRateText = new System.Windows.Forms.TextBox();
            this.connectSerial = new System.Windows.Forms.Button();
            this.comPortText = new System.Windows.Forms.ComboBox();
            this.data_Collector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandInput
            // 
            this.commandInput.Location = new System.Drawing.Point(45, 351);
            this.commandInput.Name = "commandInput";
            this.commandInput.Size = new System.Drawing.Size(486, 22);
            this.commandInput.TabIndex = 0;
            // 
            // sendInput
            // 
            this.sendInput.ForeColor = System.Drawing.Color.DarkBlue;
            this.sendInput.Location = new System.Drawing.Point(565, 351);
            this.sendInput.Name = "sendInput";
            this.sendInput.Size = new System.Drawing.Size(75, 23);
            this.sendInput.TabIndex = 1;
            this.sendInput.Text = "Send";
            this.sendInput.UseVisualStyleBackColor = true;
            this.sendInput.Click += new System.EventHandler(this.sendInput_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // baudRateText
            // 
            this.baudRateText.Location = new System.Drawing.Point(295, 20);
            this.baudRateText.Name = "baudRateText";
            this.baudRateText.Size = new System.Drawing.Size(100, 22);
            this.baudRateText.TabIndex = 6;
            this.baudRateText.Text = "9600";
            // 
            // connectSerial
            // 
            this.connectSerial.ForeColor = System.Drawing.Color.DarkBlue;
            this.connectSerial.Location = new System.Drawing.Point(441, 16);
            this.connectSerial.Name = "connectSerial";
            this.connectSerial.Size = new System.Drawing.Size(90, 31);
            this.connectSerial.TabIndex = 7;
            this.connectSerial.Text = "CONNECT";
            this.connectSerial.UseVisualStyleBackColor = true;
            this.connectSerial.Click += new System.EventHandler(this.connectSerial_Click);
            // 
            // comPortText
            // 
            this.comPortText.FormattingEnabled = true;
            this.comPortText.Items.AddRange(new object[] {
            "Simulator"});
            this.comPortText.Location = new System.Drawing.Point(91, 17);
            this.comPortText.Name = "comPortText";
            this.comPortText.Size = new System.Drawing.Size(121, 24);
            this.comPortText.TabIndex = 8;
            // 
            // data_Collector
            // 
            this.data_Collector.Enabled = false;
            this.data_Collector.ForeColor = System.Drawing.Color.DarkBlue;
            this.data_Collector.Location = new System.Drawing.Point(565, 83);
            this.data_Collector.Name = "data_Collector";
            this.data_Collector.Size = new System.Drawing.Size(94, 28);
            this.data_Collector.TabIndex = 9;
            this.data_Collector.Text = "current data ";
            this.data_Collector.UseVisualStyleBackColor = true;
            this.data_Collector.Click += new System.EventHandler(this.data_Collector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.data_Collector);
            this.Controls.Add(this.comPortText);
            this.Controls.Add(this.connectSerial);
            this.Controls.Add(this.baudRateText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replyBoxText);
            this.Controls.Add(this.sendInput);
            this.Controls.Add(this.commandInput);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Remote Healthcare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandInput;
        private System.Windows.Forms.Button sendInput;
        private System.Windows.Forms.TextBox replyBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baudRateText;
        private System.Windows.Forms.Button connectSerial;
        private System.Windows.Forms.ComboBox comPortText;
        private System.Windows.Forms.Button data_Collector;
    }
}

