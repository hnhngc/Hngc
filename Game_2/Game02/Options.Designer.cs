namespace Game02
{
    partial class Options
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
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_title = new System.Windows.Forms.PictureBox();
            this.pic_Bg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Play = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bg)).BeginInit();
            this.SuspendLayout();
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
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(48, 45);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseTransparentBackground = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Image = global::Game02.Properties.Resources.Group_8;
            this.lbl_title.Location = new System.Drawing.Point(111, 63);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(588, 116);
            this.lbl_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_title.TabIndex = 7;
            this.lbl_title.TabStop = false;
            // 
            // pic_Bg
            // 
            this.pic_Bg.BackColor = System.Drawing.Color.Transparent;
            this.pic_Bg.Image = global::Game02.Properties.Resources.Rectangle_24__1_;
            this.pic_Bg.Location = new System.Drawing.Point(102, 195);
            this.pic_Bg.Name = "pic_Bg";
            this.pic_Bg.Size = new System.Drawing.Size(612, 232);
            this.pic_Bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Bg.TabIndex = 8;
            this.pic_Bg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "BGM";
            // 
            // btn_Sp
            // 
            this.btn_Sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.btn_Sp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.btn_Sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Sp.ForeColor = System.Drawing.Color.Black;
            this.btn_Sp.Location = new System.Drawing.Point(289, 347);
            this.btn_Sp.Name = "btn_Sp";
            this.btn_Sp.Size = new System.Drawing.Size(243, 45);
            this.btn_Sp.TabIndex = 13;
            this.btn_Sp.Text = "SUPPORT";
            this.btn_Sp.Click += new System.EventHandler(this.btn_Sp_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BorderThickness = 2;
            this.btn_Play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Play.FillColor = System.Drawing.Color.Transparent;
            this.btn_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Play.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Play.Location = new System.Drawing.Point(384, 279);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Play.Size = new System.Drawing.Size(45, 39);
            this.btn_Play.TabIndex = 14;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Game02.Properties.Resources.Frame_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Sp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Bg);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private System.Windows.Forms.PictureBox lbl_title;
        private System.Windows.Forms.PictureBox pic_Bg;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Sp;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Play;
    }
}