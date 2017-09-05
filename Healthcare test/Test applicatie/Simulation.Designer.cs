namespace Healthcare_test.test_applicatie
{
    partial class Simulation
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
            this.PowerTrackbar = new System.Windows.Forms.TrackBar();
            this.SeedLabel = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RpmLabel = new System.Windows.Forms.Label();
            this.distanceLAbel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PulseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Powerlabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // PowerTrackbar
            // 
            this.PowerTrackbar.Location = new System.Drawing.Point(24, 57);
            this.PowerTrackbar.Maximum = 500;
            this.PowerTrackbar.Minimum = 35;
            this.PowerTrackbar.Name = "PowerTrackbar";
            this.PowerTrackbar.Size = new System.Drawing.Size(324, 56);
            this.PowerTrackbar.TabIndex = 0;
            this.PowerTrackbar.TickFrequency = 50;
            this.PowerTrackbar.Value = 35;
            this.PowerTrackbar.Scroll += new System.EventHandler(this.PowerTrackbar_Scroll);
            // 
            // SeedLabel
            // 
            this.SeedLabel.Location = new System.Drawing.Point(24, 146);
            this.SeedLabel.Maximum = 80;
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(324, 56);
            this.SeedLabel.TabIndex = 1;
            this.SeedLabel.TickFrequency = 5;
            this.SeedLabel.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "RPM";
            // 
            // Power
            // 
            this.Power.AutoSize = true;
            this.Power.Location = new System.Drawing.Point(40, 34);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(60, 17);
            this.Power.TabIndex = 3;
            this.Power.Text = "POWER";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(40, 116);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(109, 17);
            this.Speed.TabIndex = 4;
            this.Speed.Text = "SPEED IN KM/H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "DISTANCE";
            // 
            // RpmLabel
            // 
            this.RpmLabel.AutoSize = true;
            this.RpmLabel.Location = new System.Drawing.Point(223, 266);
            this.RpmLabel.Name = "RpmLabel";
            this.RpmLabel.Size = new System.Drawing.Size(28, 17);
            this.RpmLabel.TabIndex = 6;
            this.RpmLabel.Text = "0.0";
            // 
            // distanceLAbel
            // 
            this.distanceLAbel.AutoSize = true;
            this.distanceLAbel.Location = new System.Drawing.Point(223, 299);
            this.distanceLAbel.Name = "distanceLAbel";
            this.distanceLAbel.Size = new System.Drawing.Size(28, 17);
            this.distanceLAbel.TabIndex = 7;
            this.distanceLAbel.Text = "0.0";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(43, 394);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(99, 53);
            this.ApplyButton.TabIndex = 8;
            this.ApplyButton.Text = "APPLY";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.ForeColor = System.Drawing.Color.Crimson;
            this.ResetButton.Location = new System.Drawing.Point(226, 394);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(107, 53);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "PULSE";
            // 
            // PulseLabel
            // 
            this.PulseLabel.AutoSize = true;
            this.PulseLabel.Location = new System.Drawing.Point(226, 332);
            this.PulseLabel.Name = "PulseLabel";
            this.PulseLabel.Size = new System.Drawing.Size(28, 17);
            this.PulseLabel.TabIndex = 11;
            this.PulseLabel.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "TIME";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(223, 235);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(36, 17);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "0:00";
            // 
            // Powerlabel
            // 
            this.Powerlabel.AutoSize = true;
            this.Powerlabel.Location = new System.Drawing.Point(305, 34);
            this.Powerlabel.Name = "Powerlabel";
            this.Powerlabel.Size = new System.Drawing.Size(28, 17);
            this.Powerlabel.TabIndex = 14;
            this.Powerlabel.Text = "0.0";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Location = new System.Drawing.Point(305, 116);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(28, 17);
            this.SpeedLabel.TabIndex = 15;
            this.SpeedLabel.Text = "0.0";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Simulation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(376, 483);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.Powerlabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PulseLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.distanceLAbel);
            this.Controls.Add(this.RpmLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.PowerTrackbar);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Simulation";
            this.Text = "Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar PowerTrackbar;
        private System.Windows.Forms.TrackBar SeedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RpmLabel;
        private System.Windows.Forms.Label distanceLAbel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PulseLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label Powerlabel;
        private System.Windows.Forms.Label SpeedLabel;
    }
}