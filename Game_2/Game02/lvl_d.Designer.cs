namespace Game02
{
    partial class lvl_d
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.HPbar = new System.Windows.Forms.ProgressBar();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.PictureBox();
            this.picScrew = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picL_T = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.dialogBox2 = new System.Windows.Forms.PictureBox();
            this.dialogBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picL_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialogBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialogBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Game02.Properties.Resources._1254_80;
            this.pictureBox1.Location = new System.Drawing.Point(238, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Game02.Properties.Resources._1254_80;
            this.pictureBox2.Location = new System.Drawing.Point(464, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "block";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Game02.Properties.Resources._1254_90;
            this.pictureBox4.Location = new System.Drawing.Point(335, 197);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "block";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Game02.Properties.Resources._1254_90;
            this.pictureBox5.Location = new System.Drawing.Point(620, 182);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "block";
            // 
            // HPbar
            // 
            this.HPbar.ForeColor = System.Drawing.Color.Green;
            this.HPbar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HPbar.Location = new System.Drawing.Point(603, 12);
            this.HPbar.Name = "HPbar";
            this.HPbar.Size = new System.Drawing.Size(167, 26);
            this.HPbar.TabIndex = 42;
            this.HPbar.Value = 100;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtScore.Location = new System.Drawing.Point(220, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(0, 29);
            this.txtScore.TabIndex = 44;
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAmmo.Location = new System.Drawing.Point(52, 9);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(0, 29);
            this.txtAmmo.TabIndex = 43;
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.Transparent;
            this.a1.Image = global::Game02.Properties.Resources.r;
            this.a1.Location = new System.Drawing.Point(731, 123);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(33, 33);
            this.a1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.a1.TabIndex = 35;
            this.a1.TabStop = false;
            // 
            // picScrew
            // 
            this.picScrew.BackColor = System.Drawing.Color.Transparent;
            this.picScrew.Image = global::Game02.Properties.Resources.snapedit_1711166427558;
            this.picScrew.Location = new System.Drawing.Point(402, 242);
            this.picScrew.Name = "picScrew";
            this.picScrew.Size = new System.Drawing.Size(37, 47);
            this.picScrew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScrew.TabIndex = 45;
            this.picScrew.TabStop = false;
            this.picScrew.Tag = "tools";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 46;
            // 
            // picL_T
            // 
            this.picL_T.BackColor = System.Drawing.Color.Transparent;
            this.picL_T.Image = global::Game02.Properties.Resources.lu;
            this.picL_T.Location = new System.Drawing.Point(21, 41);
            this.picL_T.Name = "picL_T";
            this.picL_T.Size = new System.Drawing.Size(48, 40);
            this.picL_T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picL_T.TabIndex = 48;
            this.picL_T.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(92, 64);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(29, 34);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 30;
            this.picPlayer.TabStop = false;
            // 
            // dialogBox2
            // 
            this.dialogBox2.BackColor = System.Drawing.Color.Transparent;
            this.dialogBox2.Image = global::Game02.Properties.Resources.Group_1__1_;
            this.dialogBox2.Location = new System.Drawing.Point(58, 12);
            this.dialogBox2.Name = "dialogBox2";
            this.dialogBox2.Size = new System.Drawing.Size(114, 46);
            this.dialogBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogBox2.TabIndex = 50;
            this.dialogBox2.TabStop = false;
            this.dialogBox2.Tag = "";
            this.dialogBox2.Visible = false;
            // 
            // dialogBox3
            // 
            this.dialogBox3.BackColor = System.Drawing.Color.Transparent;
            this.dialogBox3.Image = global::Game02.Properties.Resources.Group_1__1_;
            this.dialogBox3.Location = new System.Drawing.Point(638, 71);
            this.dialogBox3.Name = "dialogBox3";
            this.dialogBox3.Size = new System.Drawing.Size(114, 46);
            this.dialogBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogBox3.TabIndex = 51;
            this.dialogBox3.TabStop = false;
            this.dialogBox3.Tag = "";
            this.dialogBox3.Visible = false;
            // 
            // lvl_d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game02.Properties.Resources.Đi_cảnh_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dialogBox3);
            this.Controls.Add(this.dialogBox2);
            this.Controls.Add(this.picL_T);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picScrew);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.HPbar);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lvl_d";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.lvl_d_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picL_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialogBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialogBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ProgressBar HPbar;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.PictureBox a1;
        private System.Windows.Forms.PictureBox picScrew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picL_T;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox dialogBox2;
        private System.Windows.Forms.PictureBox dialogBox3;
    }
}