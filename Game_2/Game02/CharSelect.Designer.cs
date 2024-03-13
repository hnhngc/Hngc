namespace Game02
{
    partial class CharSelect
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Game02.Properties.Resources.Group_9;
            this.pictureBox1.Location = new System.Drawing.Point(113, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picP1
            // 
            this.picP1.BackColor = System.Drawing.Color.Transparent;
            this.picP1.Image = global::Game02.Properties.Resources.Faceset;
            this.picP1.Location = new System.Drawing.Point(314, 223);
            this.picP1.Name = "picP1";
            this.picP1.Size = new System.Drawing.Size(38, 38);
            this.picP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picP1.TabIndex = 2;
            this.picP1.TabStop = false;
            this.picP1.Click += new System.EventHandler(this.picP1_Click);
            // 
            // picP2
            // 
            this.picP2.BackColor = System.Drawing.Color.Transparent;
            this.picP2.Image = global::Game02.Properties.Resources.Faceset1;
            this.picP2.Location = new System.Drawing.Point(440, 223);
            this.picP2.Name = "picP2";
            this.picP2.Size = new System.Drawing.Size(38, 38);
            this.picP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picP2.TabIndex = 3;
            this.picP2.TabStop = false;
            this.picP2.Click += new System.EventHandler(this.picP2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SeaShell;
            this.guna2Button1.Font = new System.Drawing.Font("NinjaAdventure", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.SandyBrown;
            this.guna2Button1.Location = new System.Drawing.Point(314, 309);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "START";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // CharSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game02.Properties.Resources.Frame_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.picP2);
            this.Controls.Add(this.picP1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.PictureBox picP2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}