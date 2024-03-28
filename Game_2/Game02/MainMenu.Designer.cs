namespace Game02
{
    partial class MainMenu
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
            this.lbl_GameName = new System.Windows.Forms.PictureBox();
            this.btn_Opt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Score = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_GameName)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GameName.Image = global::Game02.Properties.Resources.Group_5;
            this.lbl_GameName.Location = new System.Drawing.Point(122, 42);
            this.lbl_GameName.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(588, 116);
            this.lbl_GameName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_GameName.TabIndex = 0;
            this.lbl_GameName.TabStop = false;
            // 
            // btn_Opt
            // 
            this.btn_Opt.BackColor = System.Drawing.Color.Transparent;
            this.btn_Opt.BorderRadius = 10;
            this.btn_Opt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Opt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Opt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Opt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Opt.FillColor = System.Drawing.Color.Transparent;
            this.btn_Opt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Opt.ForeColor = System.Drawing.Color.White;
            this.btn_Opt.Image = global::Game02.Properties.Resources.Rectangle_21;
            this.btn_Opt.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Opt.Location = new System.Drawing.Point(677, 12);
            this.btn_Opt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Opt.Name = "btn_Opt";
            this.btn_Opt.Size = new System.Drawing.Size(48, 46);
            this.btn_Opt.TabIndex = 3;
            this.btn_Opt.UseTransparentBackground = true;
            this.btn_Opt.Click += new System.EventHandler(this.btn_Opt_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BorderRadius = 10;
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::Game02.Properties.Resources.Rectangle_22;
            this.btn_Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Exit.Location = new System.Drawing.Point(740, 12);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(48, 46);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.UseTransparentBackground = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Start.Image = global::Game02.Properties.Resources.Group_6;
            this.btn_Start.Location = new System.Drawing.Point(250, 226);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(317, 62);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Score
            // 
            this.btn_Score.BackColor = System.Drawing.Color.Transparent;
            this.btn_Score.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Score.Image = global::Game02.Properties.Resources.Group_7;
            this.btn_Score.Location = new System.Drawing.Point(250, 313);
            this.btn_Score.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(317, 62);
            this.btn_Score.TabIndex = 6;
            this.btn_Score.UseVisualStyleBackColor = false;
            this.btn_Score.Click += new System.EventHandler(this.btn_Score_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(349, 181);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(123, 28);
            this.lbl_Username.TabIndex = 31;
            this.lbl_Username.Text = "@username";
            this.lbl_Username.Click += new System.EventHandler(this.lbl_Username_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Game02.Properties.Resources.Frame_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Score);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Opt);
            this.Controls.Add(this.lbl_GameName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_GameName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lbl_GameName;
        private Guna.UI2.WinForms.Guna2Button btn_Opt;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Score;
        private System.Windows.Forms.Label lbl_Username;
    }
}

