using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Game02
{
    public partial class lvl_d : Form
    {
        bool right, left, up, down, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int SelectChar;
        int ammo = 10;
        int enSpeed = 3;
        Random random = new Random();
        int score;
        List<PictureBox> enemyList = new List<PictureBox>();
        Char player;
        Char p1 = new Char();
        private int scoreFromPreviousLevel;
        public static bool itemScrewTaken = false;
        private string _username;
        private int _userID;

        public lvl_d(int score, int choice, string username)
        {
            InitializeComponent();
            _username = username;
            SelectChar = choice;
            RestartGame();
            scoreFromPreviousLevel = score;
        }

        private void lvl_d_Load(object sender, EventArgs e)
        {
            if (SelectChar == 1)
            {
                player = p1;
                picPlayer.Image = Properties.Resources.p1_a;
            }
            else if (SelectChar == 2)
            {
                player = p1;
                picPlayer.Image = Properties.Resources.p2_a;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (SelectChar == 1)
            {
                picPlayer.BringToFront();
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        right = true;
                        facing = "right";
                        picPlayer.Image = Properties.Resources.p1_D;
                        break;
                    case Keys.Left:
                        left = true;
                        facing = "left";
                        picPlayer.Image = Properties.Resources.p1_c;
                        break;
                    case Keys.Up:
                        up = true;
                        facing = "up";
                        picPlayer.Image = Properties.Resources.p1_b;
                        break;
                    case Keys.Down:
                        down = true;
                        facing = "down";
                        picPlayer.Image = Properties.Resources.p1_a;
                        break;
                }
            }
            else
            {
                picPlayer.BringToFront();
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        right = true;
                        facing = "right";
                        picPlayer.Image = Properties.Resources.p2_d;
                        break;
                    case Keys.Left:
                        left = true;
                        facing = "left";
                        picPlayer.Image = Properties.Resources.p2_c;
                        break;
                    case Keys.Up:
                        up = true;
                        facing = "up";
                        picPlayer.Image = Properties.Resources.p2_b;
                        break;
                    case Keys.Down:
                        down = true;
                        facing = "down";
                        picPlayer.Image = Properties.Resources.p2_a;
                        break;
                }
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = false;
                    break;
                case Keys.Left:
                    left = false;
                    break;
                case Keys.Up:
                    up = false;
                    break;
                case Keys.Down:
                    down = false;
                    break;
            }
            if (e.KeyCode == Keys.Space && ammo > 0 && !gameOver)
            {
                ammo--;
                ShootBullet(facing);
                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
            if (picL_T.Bounds.IntersectsWith(picPlayer.Bounds) )
            {
                if (!picScrew.Visible) // Nếu picHam được lấy
                {
                    itemScrewTaken = true;
                    lvl_b back = new lvl_b(score + scoreFromPreviousLevel, SelectChar, _username); // Cộng điểm từ level trước
                    this.Hide();
                    GameTimer.Stop();
                    back.ShowDialog();
                    this.Close();
                }
                else
                {
                    dialogBox2.Visible = true;
                    Timer dialogTimer = new Timer();
                    dialogTimer.Interval = 1500; // 2000 milliseconds = 2 seconds
                    dialogTimer.Tick += (s, args) =>
                    {
                        dialogTimer.Stop();
                        dialogBox2.Visible = false;
                    };
                    dialogTimer.Start();
                }
            }
            if (a1.Bounds.IntersectsWith(picPlayer.Bounds))
            {
                if (!picScrew.Visible) // Nếu picHam được lấy
                {
                    itemScrewTaken = true;
                    lvl_e back = new lvl_e(score + scoreFromPreviousLevel, SelectChar, _username); // Cộng điểm từ level trước
                    this.Hide();
                    GameTimer.Stop();
                    back.ShowDialog();
                    this.Close();
                }
                else
                {
                    dialogBox3.Visible = true;
                    Timer dialogTimer = new Timer();
                    dialogTimer.Interval = 1500; // 2000 milliseconds = 2 seconds
                    dialogTimer.Tick += (s, args) =>
                    {
                        dialogTimer.Stop();
                        dialogBox3.Visible = false;
                    };
                    dialogTimer.Start();
                }
            }

        }
        

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            UpdatePlayerHealth();
            UpdateUI();
            playerMove();
            HandleCollisions();
        }

        private void UpdatePlayerHealth()
        {
            if (playerHealth > 1)
            {
                HPbar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                GameTimer.Stop();
                this.Hide();
                GameOver go = new GameOver();
                go.ShowDialog();
                this.Close();
            }
        }

        private void UpdateUI()
        {
            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Score: " + (score + scoreFromPreviousLevel);
        }

        private void playerMove()
        {
            if (right == true)
            {
                if (picPlayer.Left < 500)
                {
                    picPlayer.Left += 10;
                }
            }
            if (left == true)
            {
                if (picPlayer.Left > 20)
                {
                    picPlayer.Left -= 10;
                }
            }
            if (up == true)
            {
                if (picPlayer.Top > 20)
                {
                    picPlayer.Top -= 10;
                }
            }
            if (down == true)
            {
                if (picPlayer.Top < 260)
                {
                    picPlayer.Top += 10;
                }
            }
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.Shuriken;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.BackColor = Color.Transparent;
            ammo.Left = random.Next(100, this.ClientSize.Width - ammo.Width - 100);
            ammo.Top = random.Next(50, 210);
            ammo.Tag = "ammo";

            this.Controls.Add(ammo);
            ammo.BringToFront();
            picPlayer.BringToFront();
        }

        private void SpawnEnemy()
        {
            PictureBox enemy = new PictureBox();
            enemy.Tag = "en";
            enemy.Image = Properties.Resources.enFont;
            enemy.Left = random.Next(0, 700);
            enemy.Top = random.Next(0, 215);
            enemy.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy.BackColor = Color.Transparent;
            enemyList.Add(enemy);
            this.Controls.Add(enemy);
            picPlayer.BringToFront();
        }

        private void HandleCollisions()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "tools")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        picScrew.Visible = false;
                        itemScrewTaken = true;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "block")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (right)
                        {
                            picPlayer.Left -= 10;
                        }
                        else if (left)
                        {
                            picPlayer.Left += 10;
                        }
                        if (up)
                        {
                            picPlayer.Top += 10;
                        }
                        else if (down)
                        {
                            picPlayer.Top -= 10;
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "en")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }
                    if (x.Left > picPlayer.Left)
                    {
                        x.Left -= enSpeed;
                        ((PictureBox)x).Image = Properties.Resources.enLeft;
                    }
                    if (x.Left < picPlayer.Left)
                    {
                        x.Left += enSpeed;
                        ((PictureBox)x).Image = Properties.Resources.enRight;
                    }
                    if (x.Top > picPlayer.Top)
                    {
                        x.Top -= enSpeed;
                        ((PictureBox)x).Image = Properties.Resources.enBack;
                    }
                    if (x.Top < picPlayer.Top)
                    {
                        x.Top += enSpeed;
                        ((PictureBox)x).Image = Properties.Resources.enFont;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "en")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            IncreaseScore(10);
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            enemyList.Remove(((PictureBox)x));
                            SpawnEnemy();
                        }
                    }
                }
            }
        }

        public void IncreaseScore(int points)
        {
            score += points;
        }

        private void ShootBullet(string direction)
        {
            Bullet shoot = new Bullet();
            shoot.direction = direction;
            shoot.bulletLeft = picPlayer.Left + (picPlayer.Width / 2);
            shoot.bulletTop = picPlayer.Top + (picPlayer.Height / 2);
            shoot.MakeBullet(this);
        }

        public void RestartGame()
        {
            foreach (PictureBox i in enemyList)
            {
                this.Controls.Remove(i);
            }
            enemyList.Clear();
            for (int i = 0; i < 3; i++)
            {
                SpawnEnemy();
            }
            up = false;
            down = false;
            left = false;
            right = false;
            playerHealth = 100;
            score = 0;
            ammo = 10;
            GameTimer.Start();
        }
    }
}



