namespace Game02
{
    partial class lvl_e
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
            this.picBoat = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.HPbar = new System.Windows.Forms.ProgressBar();
            this.pB_fixing = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.picLeft_Up = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft_Up)).BeginInit();
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
            this.pictureBox1.Image = global::Game02.Properties.Resources._1254_90;
            this.pictureBox1.Location = new System.Drawing.Point(208, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Game02.Properties.Resources._1254_90;
            this.pictureBox2.Location = new System.Drawing.Point(286, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "block";
            // 
            // picBoat
            // 
            this.picBoat.BackColor = System.Drawing.Color.Transparent;
            this.picBoat.Image = global::Game02.Properties.Resources.snapedit_1706523866543;
            this.picBoat.Location = new System.Drawing.Point(300, 101);
            this.picBoat.Name = "picBoat";
            this.picBoat.Size = new System.Drawing.Size(87, 81);
            this.picBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoat.TabIndex = 37;
            this.picBoat.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(27, 101);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(29, 34);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 38;
            this.picPlayer.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtScore.Location = new System.Drawing.Point(202, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(0, 29);
            this.txtScore.TabIndex = 40;
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAmmo.Location = new System.Drawing.Point(34, 9);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(0, 29);
            this.txtAmmo.TabIndex = 39;
            // 
            // HPbar
            // 
            this.HPbar.ForeColor = System.Drawing.Color.Green;
            this.HPbar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HPbar.Location = new System.Drawing.Point(604, 15);
            this.HPbar.Name = "HPbar";
            this.HPbar.Size = new System.Drawing.Size(167, 26);
            this.HPbar.TabIndex = 41;
            this.HPbar.Value = 100;
            // 
            // pB_fixing
            // 
            this.pB_fixing.BackColor = System.Drawing.Color.White;
            this.pB_fixing.Location = new System.Drawing.Point(3, 25);
            this.pB_fixing.Name = "pB_fixing";
            this.pB_fixing.Size = new System.Drawing.Size(52, 10);
            this.pB_fixing.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pB_fixing);
            this.panel1.Location = new System.Drawing.Point(315, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 38);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fixing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // picLeft_Up
            // 
            this.picLeft_Up.BackColor = System.Drawing.Color.Transparent;
            this.picLeft_Up.Image = global::Game02.Properties.Resources.lu;
            this.picLeft_Up.Location = new System.Drawing.Point(55, 35);
            this.picLeft_Up.Name = "picLeft_Up";
            this.picLeft_Up.Size = new System.Drawing.Size(33, 33);
            this.picLeft_Up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeft_Up.TabIndex = 44;
            this.picLeft_Up.TabStop = false;
            this.picLeft_Up.Tag = "";
            // 
            // lvl_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Game02.Properties.Resources.Frame_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picLeft_Up);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HPbar);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picBoat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lvl_e";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.lvl_e_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLeft_Up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBoat;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.ProgressBar HPbar;
        private System.Windows.Forms.ProgressBar pB_fixing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.PictureBox picLeft_Up;
    }
}