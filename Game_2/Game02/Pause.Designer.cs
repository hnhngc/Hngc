namespace Game02
{
    partial class Pause
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnE = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Game02.Properties.Resources.Group_12;
            this.pictureBox1.Location = new System.Drawing.Point(104, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Game02.Properties.Resources.Group_13;
            this.button1.Location = new System.Drawing.Point(242, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 63);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Game02.Properties.Resources.Group_14;
            this.button2.Location = new System.Drawing.Point(242, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 63);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::Game02.Properties.Resources.Group_1;
            this.button3.Location = new System.Drawing.Point(242, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 63);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.Transparent;
            this.btnE.BorderRadius = 10;
            this.btnE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnE.FillColor = System.Drawing.Color.Transparent;
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.Image = global::Game02.Properties.Resources.Rectangle_22;
            this.btnE.ImageSize = new System.Drawing.Size(40, 40);
            this.btnE.Location = new System.Drawing.Point(740, 12);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(48, 45);
            this.btnE.TabIndex = 14;
            this.btnE.UseTransparentBackground = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game02.Properties.Resources.Frame_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Guna.UI2.WinForms.Guna2Button btnE;
    }
}