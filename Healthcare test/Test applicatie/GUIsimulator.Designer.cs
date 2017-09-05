namespace Healthcare_test.test_applicatie
{
    partial class GUIsimulator 
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.energybox = new System.Windows.Forms.TextBox();
            this.rpmbox = new System.Windows.Forms.TextBox();
            this.speedbox = new System.Windows.Forms.TextBox();
            this.distancebox = new System.Windows.Forms.TextBox();
            this.pulsebox = new System.Windows.Forms.TextBox();
            this.timebox = new System.Windows.Forms.TextBox();
            this.powerbox = new System.Windows.Forms.TextBox();
            this.resetbutton = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.autobutton = new System.Windows.Forms.Button();
            this.replyBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RPM:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SPEED:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DISTANCE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "POWER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TIME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ENERGY:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "PULSE:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // energybox
            // 
            this.energybox.Location = new System.Drawing.Point(400, 331);
            this.energybox.Margin = new System.Windows.Forms.Padding(2);
            this.energybox.Name = "energybox";
            this.energybox.Size = new System.Drawing.Size(76, 20);
            this.energybox.TabIndex = 11;
            this.energybox.Text = " ";
            this.energybox.TextChanged += new System.EventHandler(this.energybox_TextChanged_1);
            // 
            // rpmbox
            // 
            this.rpmbox.Location = new System.Drawing.Point(44, 266);
            this.rpmbox.Margin = new System.Windows.Forms.Padding(2);
            this.rpmbox.Name = "rpmbox";
            this.rpmbox.Size = new System.Drawing.Size(76, 20);
            this.rpmbox.TabIndex = 12;
            this.rpmbox.Text = " ";
            this.rpmbox.TextChanged += new System.EventHandler(this.rpmbox_TextChanged);
            // 
            // speedbox
            // 
            this.speedbox.Location = new System.Drawing.Point(212, 266);
            this.speedbox.Margin = new System.Windows.Forms.Padding(2);
            this.speedbox.Name = "speedbox";
            this.speedbox.Size = new System.Drawing.Size(76, 20);
            this.speedbox.TabIndex = 13;
            this.speedbox.Text = " ";
            this.speedbox.TextChanged += new System.EventHandler(this.speedbox_TextChanged);
            // 
            // distancebox
            // 
            this.distancebox.Location = new System.Drawing.Point(400, 266);
            this.distancebox.Margin = new System.Windows.Forms.Padding(2);
            this.distancebox.Name = "distancebox";
            this.distancebox.Size = new System.Drawing.Size(76, 20);
            this.distancebox.TabIndex = 14;
            this.distancebox.Text = " ";
            this.distancebox.TextChanged += new System.EventHandler(this.distancebox_TextChanged);
            // 
            // pulsebox
            // 
            this.pulsebox.Location = new System.Drawing.Point(44, 390);
            this.pulsebox.Margin = new System.Windows.Forms.Padding(2);
            this.pulsebox.Name = "pulsebox";
            this.pulsebox.Size = new System.Drawing.Size(76, 20);
            this.pulsebox.TabIndex = 15;
            this.pulsebox.Text = " ";
            this.pulsebox.TextChanged += new System.EventHandler(this.pulsebox_TextChanged);
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(212, 331);
            this.timebox.Margin = new System.Windows.Forms.Padding(2);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(76, 20);
            this.timebox.TabIndex = 16;
            this.timebox.Text = " ";
            this.timebox.TextChanged += new System.EventHandler(this.timebox_TextChanged);
            // 
            // powerbox
            // 
            this.powerbox.Location = new System.Drawing.Point(44, 331);
            this.powerbox.Margin = new System.Windows.Forms.Padding(2);
            this.powerbox.Name = "powerbox";
            this.powerbox.Size = new System.Drawing.Size(76, 20);
            this.powerbox.TabIndex = 17;
            this.powerbox.Text = " ";
            this.powerbox.TextChanged += new System.EventHandler(this.powerbox_TextChanged);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(190, 473);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(2);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(148, 39);
            this.resetbutton.TabIndex = 19;
            this.resetbutton.Text = "RESET";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // applybutton
            // 
            this.applybutton.Location = new System.Drawing.Point(29, 473);
            this.applybutton.Margin = new System.Windows.Forms.Padding(2);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(140, 39);
            this.applybutton.TabIndex = 20;
            this.applybutton.Text = "APPLY";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.applybutton_Click);
            // 
            // replyBoxText
            // 
            this.replyBoxText.Location = new System.Drawing.Point(44, 33);
            this.replyBoxText.Margin = new System.Windows.Forms.Padding(2);
            this.replyBoxText.Multiline = true;
            this.replyBoxText.Name = "replyBoxText";
            this.replyBoxText.ReadOnly = true;
            this.replyBoxText.Size = new System.Drawing.Size(468, 186);
            this.replyBoxText.TabIndex = 18;
            this.replyBoxText.TextChanged += new System.EventHandler(this.replyBoxText_TextChanged);
            // 
            // autobutton
            // 
            this.autobutton.Location = new System.Drawing.Point(364, 473);
            this.autobutton.Margin = new System.Windows.Forms.Padding(2);
            this.autobutton.Name = "autobutton";
            this.autobutton.Size = new System.Drawing.Size(148, 39);
            this.autobutton.TabIndex = 21;
            this.autobutton.Text = "AUTO";
            this.autobutton.UseVisualStyleBackColor = true;
            this.autobutton.Click += new System.EventHandler(this.autobutton_Click);
            // 
            // GUIsimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 527);
            this.Controls.Add(this.autobutton);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.replyBoxText);
            this.Controls.Add(this.powerbox);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.pulsebox);
            this.Controls.Add(this.distancebox);
            this.Controls.Add(this.speedbox);
            this.Controls.Add(this.rpmbox);
            this.Controls.Add(this.energybox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUIsimulator";
            this.Text = "GUIsimulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox energybox;
        private System.Windows.Forms.TextBox rpmbox;
        private System.Windows.Forms.TextBox speedbox;
        private System.Windows.Forms.TextBox distancebox;
        private System.Windows.Forms.TextBox pulsebox;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.TextBox powerbox;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Button autobutton;
        private System.Windows.Forms.TextBox replyBoxText;
    }
}