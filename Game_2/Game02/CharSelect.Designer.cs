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
            this.lbl_title = new System.Windows.Forms.PictureBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.btn_Start = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Image = global::Game02.Properties.Resources.Group_9;
            this.lbl_title.Location = new System.Drawing.Point(113, 40);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(588, 116);
            this.lbl_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_title.TabIndex = 1;
            this.lbl_title.TabStop = false;
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
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BorderRadius = 10;
            this.btn_Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Start.FillColor = System.Drawing.Color.SeaShell;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.SandyBrown;
            this.btn_Start.Location = new System.Drawing.Point(314, 309);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(174, 45);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "START";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // CharSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game02.Properties.Resources.Frame_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.picP2);
            this.Controls.Add(this.picP1);
            this.Controls.Add(this.lbl_title);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.lbl_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lbl_title;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.PictureBox picP2;
        private Guna.UI2.WinForms.Guna2Button btn_Start;
    }
}