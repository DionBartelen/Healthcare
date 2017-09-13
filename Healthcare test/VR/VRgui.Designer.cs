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
            this.set_Ground_Terrain_256_256 = new System.Windows.Forms.Button();
            this.GroundTerrain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remove_Terrain_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Buttonobject = new System.Windows.Forms.Button();
            this.Routebutton = new System.Windows.Forms.Button();
            this.Showroutebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_Button
            // 
            this.connect_Button.Location = new System.Drawing.Point(357, 20);
            this.connect_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connect_Button.Name = "connect_Button";
            this.connect_Button.Size = new System.Drawing.Size(75, 23);
            this.connect_Button.TabIndex = 5;
            this.connect_Button.Text = "connect";
            this.connect_Button.UseVisualStyleBackColor = true;
            this.connect_Button.Click += new System.EventHandler(this.connect_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Session name";
            // 
            // sessions
            // 
            this.sessions.FormattingEnabled = true;
            this.sessions.Location = new System.Drawing.Point(115, 20);
            this.sessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(223, 24);
            this.sessions.TabIndex = 3;
            // 
            // TunnelStatus
            // 
            this.TunnelStatus.AutoSize = true;
            this.TunnelStatus.Location = new System.Drawing.Point(477, 20);
            this.TunnelStatus.Name = "TunnelStatus";
            this.TunnelStatus.Size = new System.Drawing.Size(100, 17);
            this.TunnelStatus.TabIndex = 6;
            this.TunnelStatus.Text = "Not connected";
            // 
            // ChangeTerain
            // 
            this.ChangeTerain.Location = new System.Drawing.Point(228, 289);
            this.ChangeTerain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeTerain.Name = "ChangeTerain";
            this.ChangeTerain.Size = new System.Drawing.Size(85, 33);
            this.ChangeTerain.TabIndex = 7;
            this.ChangeTerain.Text = "Set Time";
            this.ChangeTerain.UseVisualStyleBackColor = true;
            this.ChangeTerain.Click += new System.EventHandler(this.ChangeTerain_Click);
            // 
            // RefreshClients
            // 
            this.RefreshClients.Location = new System.Drawing.Point(604, 20);
            this.RefreshClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshClients.Name = "RefreshClients";
            this.RefreshClients.Size = new System.Drawing.Size(75, 23);
            this.RefreshClients.TabIndex = 8;
            this.RefreshClients.Text = "Refresh";
            this.RefreshClients.UseVisualStyleBackColor = true;
            this.RefreshClients.Click += new System.EventHandler(this.RefreshClients_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 294);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 16;
            // 
            // set_Ground_Terrain_256_256
            // 
            this.set_Ground_Terrain_256_256.Location = new System.Drawing.Point(228, 239);
            this.set_Ground_Terrain_256_256.Name = "set_Ground_Terrain_256_256";
            this.set_Ground_Terrain_256_256.Size = new System.Drawing.Size(85, 34);
            this.set_Ground_Terrain_256_256.TabIndex = 10;
            this.set_Ground_Terrain_256_256.Text = "setTerrain";
            this.set_Ground_Terrain_256_256.UseVisualStyleBackColor = true;
            this.set_Ground_Terrain_256_256.Click += new System.EventHandler(this.set_Ground_Terrain_256_256_Click);
            // 
            // GroundTerrain
            // 
            this.GroundTerrain.AutoSize = true;
            this.GroundTerrain.Location = new System.Drawing.Point(12, 256);
            this.GroundTerrain.Name = "GroundTerrain";
            this.GroundTerrain.Size = new System.Drawing.Size(56, 17);
            this.GroundTerrain.TabIndex = 11;
            this.GroundTerrain.Text = "Ground";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "256 * 256";
            // 
            // remove_Terrain_Button
            // 
            this.remove_Terrain_Button.Location = new System.Drawing.Point(228, 187);
            this.remove_Terrain_Button.Name = "remove_Terrain_Button";
            this.remove_Terrain_Button.Size = new System.Drawing.Size(85, 36);
            this.remove_Terrain_Button.TabIndex = 13;
            this.remove_Terrain_Button.Text = "remove";
            this.remove_Terrain_Button.UseVisualStyleBackColor = true;
            this.remove_Terrain_Button.Click += new System.EventHandler(this.remove_Terrain_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Delete Terrain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delete";
            // 
            // Buttonobject
            // 
            this.Buttonobject.Location = new System.Drawing.Point(228, 128);
            this.Buttonobject.Name = "Buttonobject";
            this.Buttonobject.Size = new System.Drawing.Size(85, 32);
            this.Buttonobject.TabIndex = 17;
            this.Buttonobject.Text = "3d object";
            this.Buttonobject.UseVisualStyleBackColor = true;
            this.Buttonobject.Click += new System.EventHandler(this.Buttonobject_Click);
            // 
            // Routebutton
            // 
            this.Routebutton.Location = new System.Drawing.Point(604, 136);
            this.Routebutton.Name = "Routebutton";
            this.Routebutton.Size = new System.Drawing.Size(75, 23);
            this.Routebutton.TabIndex = 18;
            this.Routebutton.Text = "Route";
            this.Routebutton.UseVisualStyleBackColor = true;
            this.Routebutton.Click += new System.EventHandler(this.Routebutton_Click);
            // 
            // Showroutebutton
            // 
            this.Showroutebutton.Location = new System.Drawing.Point(604, 166);
            this.Showroutebutton.Name = "Showroutebutton";
            this.Showroutebutton.Size = new System.Drawing.Size(75, 23);
            this.Showroutebutton.TabIndex = 19;
            this.Showroutebutton.Text = "Show Route";
            this.Showroutebutton.UseVisualStyleBackColor = true;
            this.Showroutebutton.Click += new System.EventHandler(this.Showroutebutton_Click);
            // 
            // VRgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 384);
            this.Controls.Add(this.Showroutebutton);
            this.Controls.Add(this.Routebutton);
            this.Controls.Add(this.Buttonobject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remove_Terrain_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroundTerrain);
            this.Controls.Add(this.set_Ground_Terrain_256_256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshClients);
            this.Controls.Add(this.ChangeTerain);
            this.Controls.Add(this.TunnelStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connect_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

        private System.Windows.Forms.Button set_Ground_Terrain_256_256;
        private System.Windows.Forms.Label GroundTerrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remove_Terrain_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buttonobject;
        private System.Windows.Forms.Button Routebutton;
        private System.Windows.Forms.Button Showroutebutton;
    }
}