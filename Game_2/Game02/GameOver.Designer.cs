namespace Game02
{
    partial class GameOver
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
            this.btn_NewG = new System.Windows.Forms.Button();
            this.btn_Main = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_title)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NewG
            // 
            this.btn_NewG.BackColor = System.Drawing.Color.Transparent;
            this.btn_NewG.ForeColor = System.Drawing.Color.Transparent;
            this.btn_NewG.Image = global::Game02.Properties.Resources.Group_14;
            this.btn_NewG.Location = new System.Drawing.Point(244, 217);
            this.btn_NewG.Name = "btn_NewG";
            this.btn_NewG.Size = new System.Drawing.Size(317, 63);
            this.btn_NewG.TabIndex = 10;
            this.btn_NewG.UseVisualStyleBackColor = false;
            this.btn_NewG.Click += new System.EventHandler(this.btn_NewG_Click);
            // 
            // btn_Main
            // 
            this.btn_Main.BackColor = System.Drawing.Color.Transparent;
            this.btn_Main.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Main.Image = global::Game02.Properties.Resources.Group_1;
            this.btn_Main.Location = new System.Drawing.Point(244, 305);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(317, 63);
            this.btn_Main.TabIndex = 9;
            this.btn_Main.UseVisualStyleBackColor = false;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Image = global::Game02.Properties.Resources.Group_15;
            this.lbl_title.Location = new System.Drawing.Point(106, 82);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(588, 116);
            this.lbl_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_title.TabIndex = 8;
            this.lbl_title.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game02.Properties.Resources.Frame_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_NewG);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.lbl_title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.lbl_title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewG;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.PictureBox lbl_title;
    }
}