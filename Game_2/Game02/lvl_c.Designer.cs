namespace Game02
{
    partial class lvl_c
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl_c));
            this.picCave = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.HPbar = new System.Windows.Forms.ProgressBar();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picFinal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // picCave
            // 
            this.picCave.BackColor = System.Drawing.Color.Transparent;
            this.picCave.Image = global::Game02.Properties.Resources.cv;
            resources.ApplyResources(this.picCave, "picCave");
            this.picCave.Name = "picCave";
            this.picCave.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // HPbar
            // 
            this.HPbar.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.HPbar, "HPbar");
            this.HPbar.Name = "HPbar";
            this.HPbar.Value = 100;
            // 
            // txtScore
            // 
            resources.ApplyResources(this.txtScore, "txtScore");
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Name = "txtScore";
            // 
            // txtAmmo
            // 
            resources.ApplyResources(this.txtAmmo, "txtAmmo");
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Name = "txtAmmo";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Game02.Properties.Resources._1254;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "block";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Game02.Properties.Resources._1254;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Game02.Properties.Resources._1254;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "block";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Game02.Properties.Resources._1254;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "block";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Game02.Properties.Resources._1254;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "block";
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picPlayer, "picPlayer");
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.TabStop = false;
            this.picPlayer.Tag = "";
            // 
            // picFinal
            // 
            this.picFinal.BackColor = System.Drawing.Color.Transparent;
            this.picFinal.Image = global::Game02.Properties.Resources.snapedit_1707830270323;
            resources.ApplyResources(this.picFinal, "picFinal");
            this.picFinal.Name = "picFinal";
            this.picFinal.TabStop = false;
            // 
            // lvl_c
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game02.Properties.Resources.Grass_Sample;
            this.Controls.Add(this.picFinal);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.picCave);
            this.Controls.Add(this.HPbar);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lvl_c";
            this.Load += new System.EventHandler(this.lvl_c_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCave;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ProgressBar HPbar;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picFinal;
    }
}