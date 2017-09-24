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
            this.terrainWH = new System.Windows.Forms.Button();
            this.Routebutton = new System.Windows.Forms.Button();
            this.Showroutebutton = new System.Windows.Forms.Button();
            this.Moving_3D_Ojbect = new System.Windows.Forms.Button();
            this.objects = new System.Windows.Forms.ComboBox();
            this.selectbutton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.sceneButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_Button
            // 
            this.connect_Button.Location = new System.Drawing.Point(269, 16);
            this.connect_Button.Margin = new System.Windows.Forms.Padding(2);
            this.connect_Button.Name = "connect_Button";
            this.connect_Button.Size = new System.Drawing.Size(54, 21);
            this.connect_Button.TabIndex = 5;
            this.connect_Button.Text = "connect";
            this.connect_Button.UseVisualStyleBackColor = true;
            this.connect_Button.Click += new System.EventHandler(this.connect_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
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
            this.TunnelStatus.Location = new System.Drawing.Point(369, 19);
            this.TunnelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TunnelStatus.Name = "TunnelStatus";
            this.TunnelStatus.Size = new System.Drawing.Size(78, 13);
            this.TunnelStatus.TabIndex = 6;
            this.TunnelStatus.Text = "Not connected";
            // 
            // ChangeTerain
            // 
            this.ChangeTerain.Location = new System.Drawing.Point(171, 235);
            this.ChangeTerain.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeTerain.Name = "ChangeTerain";
            this.ChangeTerain.Size = new System.Drawing.Size(64, 27);
            this.ChangeTerain.TabIndex = 7;
            this.ChangeTerain.Text = "Set Time";
            this.ChangeTerain.UseVisualStyleBackColor = true;
            this.ChangeTerain.Click += new System.EventHandler(this.ChangeTerain_Click);
            // 
            // RefreshClients
            // 
            this.RefreshClients.Location = new System.Drawing.Point(451, 15);
            this.RefreshClients.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshClients.Name = "RefreshClients";
            this.RefreshClients.Size = new System.Drawing.Size(58, 21);
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
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 16;
            // 
            // set_Ground_Terrain_256_256
            // 
            this.set_Ground_Terrain_256_256.Location = new System.Drawing.Point(171, 194);
            this.set_Ground_Terrain_256_256.Margin = new System.Windows.Forms.Padding(2);
            this.set_Ground_Terrain_256_256.Name = "set_Ground_Terrain_256_256";
            this.set_Ground_Terrain_256_256.Size = new System.Drawing.Size(64, 28);
            this.set_Ground_Terrain_256_256.TabIndex = 10;
            this.set_Ground_Terrain_256_256.Text = "setTerrain";
            this.set_Ground_Terrain_256_256.UseVisualStyleBackColor = true;
            this.set_Ground_Terrain_256_256.Click += new System.EventHandler(this.set_Ground_Terrain_256_256_Click);
            // 
            // GroundTerrain
            // 
            this.GroundTerrain.AutoSize = true;
            this.GroundTerrain.Location = new System.Drawing.Point(9, 208);
            this.GroundTerrain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroundTerrain.Name = "GroundTerrain";
            this.GroundTerrain.Size = new System.Drawing.Size(42, 13);
            this.GroundTerrain.TabIndex = 11;
            this.GroundTerrain.Text = "Ground";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "256 * 256";
            // 
            // remove_Terrain_Button
            // 
            this.remove_Terrain_Button.Location = new System.Drawing.Point(171, 152);
            this.remove_Terrain_Button.Margin = new System.Windows.Forms.Padding(2);
            this.remove_Terrain_Button.Name = "remove_Terrain_Button";
            this.remove_Terrain_Button.Size = new System.Drawing.Size(64, 29);
            this.remove_Terrain_Button.TabIndex = 13;
            this.remove_Terrain_Button.Text = "remove";
            this.remove_Terrain_Button.UseVisualStyleBackColor = true;
            this.remove_Terrain_Button.Click += new System.EventHandler(this.remove_Terrain_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Delete Terrain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delete";
            // 
            // terrainWH
            // 
            this.terrainWH.Location = new System.Drawing.Point(454, 199);
            this.terrainWH.Margin = new System.Windows.Forms.Padding(2);
            this.terrainWH.Name = "terrainWH";
            this.terrainWH.Size = new System.Drawing.Size(66, 20);
            this.terrainWH.TabIndex = 18;
            this.terrainWH.Text = "terrainWH";
            this.terrainWH.UseVisualStyleBackColor = true;
            this.terrainWH.Click += new System.EventHandler(this.terrainWH_Click);
            // 
            // Routebutton
            // 
            this.Routebutton.Location = new System.Drawing.Point(239, 194);
            this.Routebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Routebutton.Name = "Routebutton";
            this.Routebutton.Size = new System.Drawing.Size(56, 28);
            this.Routebutton.TabIndex = 19;
            this.Routebutton.Text = "Route";
            this.Routebutton.UseVisualStyleBackColor = true;
            this.Routebutton.Click += new System.EventHandler(this.Routebutton_Click);
            // 
            // Showroutebutton
            // 
            this.Showroutebutton.Location = new System.Drawing.Point(299, 194);
            this.Showroutebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Showroutebutton.Name = "Showroutebutton";
            this.Showroutebutton.Size = new System.Drawing.Size(56, 30);
            this.Showroutebutton.TabIndex = 20;
            this.Showroutebutton.Text = "Show route";
            this.Showroutebutton.UseVisualStyleBackColor = true;
            this.Showroutebutton.Click += new System.EventHandler(this.Showroutebutton_Click);
            // 
            // Moving_3D_Ojbect
            // 
            this.Moving_3D_Ojbect.Location = new System.Drawing.Point(454, 79);
            this.Moving_3D_Ojbect.Margin = new System.Windows.Forms.Padding(2);
            this.Moving_3D_Ojbect.Name = "Moving_3D_Ojbect";
            this.Moving_3D_Ojbect.Size = new System.Drawing.Size(55, 37);
            this.Moving_3D_Ojbect.TabIndex = 21;
            this.Moving_3D_Ojbect.Text = "Object moving";
            this.Moving_3D_Ojbect.UseVisualStyleBackColor = true;
            this.Moving_3D_Ojbect.Click += new System.EventHandler(this.Moving_3D_Ojbect_Click);
            // 
            // objects
            // 
            this.objects.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objects.FormattingEnabled = true;
            this.objects.Location = new System.Drawing.Point(14, 54);
            this.objects.Margin = new System.Windows.Forms.Padding(2);
            this.objects.Name = "objects";
            this.objects.Size = new System.Drawing.Size(433, 17);
            this.objects.TabIndex = 22;
            this.objects.SelectedIndexChanged += new System.EventHandler(this.objects_SelectedIndexChanged);
            // 
            // selectbutton
            // 
            this.selectbutton.Location = new System.Drawing.Point(454, 54);
            this.selectbutton.Margin = new System.Windows.Forms.Padding(2);
            this.selectbutton.Name = "selectbutton";
            this.selectbutton.Size = new System.Drawing.Size(56, 21);
            this.selectbutton.TabIndex = 23;
            this.selectbutton.Text = "Add";
            this.selectbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selectbutton.UseVisualStyleBackColor = true;
            this.selectbutton.Click += new System.EventHandler(this.selectbutton_Click);
            // 
            // speedButton
            // 
            this.speedButton.Location = new System.Drawing.Point(79, 88);
            this.speedButton.Margin = new System.Windows.Forms.Padding(2);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(69, 21);
            this.speedButton.TabIndex = 24;
            this.speedButton.Text = "Set speed";
            this.speedButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(14, 88);
            this.speedBox.Margin = new System.Windows.Forms.Padding(2);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(61, 20);
            this.speedBox.TabIndex = 25;
            // 
            // sceneButton
            // 
            this.sceneButton.Location = new System.Drawing.Point(171, 110);
            this.sceneButton.Margin = new System.Windows.Forms.Padding(2);
            this.sceneButton.Name = "sceneButton";
            this.sceneButton.Size = new System.Drawing.Size(64, 38);
            this.sceneButton.TabIndex = 26;
            this.sceneButton.Text = "Scene info";
            this.sceneButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sceneButton.UseVisualStyleBackColor = true;
            this.sceneButton.Click += new System.EventHandler(this.sceneButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(239, 110);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(56, 38);
            this.resetButton.TabIndex = 27;
            this.resetButton.Text = "Reset scene";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // VRgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 276);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sceneButton);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.speedButton);
            this.Controls.Add(this.selectbutton);
            this.Controls.Add(this.objects);
            this.Controls.Add(this.Moving_3D_Ojbect);
            this.Controls.Add(this.Showroutebutton);
            this.Controls.Add(this.Routebutton);
            this.Controls.Add(this.terrainWH);
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

        private System.Windows.Forms.Button set_Ground_Terrain_256_256;
        private System.Windows.Forms.Label GroundTerrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remove_Terrain_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button terrainWH;
        private System.Windows.Forms.Button Routebutton;
        private System.Windows.Forms.Button Showroutebutton;
        private System.Windows.Forms.Button Moving_3D_Ojbect;
        private System.Windows.Forms.ComboBox objects;
        private System.Windows.Forms.Button selectbutton;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.Button sceneButton;
        private System.Windows.Forms.Button resetButton;
    }
}