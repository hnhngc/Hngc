using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Game02
{
    public partial class lvl_c : Form
    {
        private bool right, left, up, down, gameOver;
        private string facing = "up";
        private int playerHealth = 100;
        private int SelectChar;
        private int ammo = 10;
        private int enSpeed = 3;
        private Random random = new Random();
        private int score;
        private List<PictureBox> enList = new List<PictureBox>();
        private Char player;
        private Char p1 = new Char();
        private int scoreFromPreviousLevel;

        public lvl_c(int score, int choice)
        {
            InitializeComponent();
            SelectChar = choice;
            scoreFromPreviousLevel = score;
            RestartGame();
        }

        private void lvl_c_Load(object sender, EventArgs e)
        {
            player = SelectChar == 1 ? p1 : p1;
            picPlayer.Image = SelectChar == 1 ? Properties.Resources.p1_a : Properties.Resources.p2_a;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            picPlayer.BringToFront();
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = true;
                    facing = SelectChar == 1 ? "right" : "right";
                    picPlayer.Image = SelectChar == 1 ? Properties.Resources.p1_D : Properties.Resources.p2_d;
                    break;
                case Keys.Left:
                    left = true;
                    facing = SelectChar == 1 ? "left" : "left";
                    picPlayer.Image = SelectChar == 1 ? Properties.Resources.p1_c : Properties.Resources.p2_c;
                    break;
                case Keys.Up:
                    up = true;
                    facing = SelectChar == 1 ? "up" : "up";
                    picPlayer.Image = SelectChar == 1 ? Properties.Resources.p1_b : Properties.Resources.p2_b;
                    break;
                case Keys.Down:
                    down = true;
                    facing = SelectChar == 1 ? "down" : "down";
                    picPlayer.Image = SelectChar == 1 ? Properties.Resources.p1_a : Properties.Resources.p2_a;
                    break;
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
                case Keys.Escape:
                    this.Close();
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
            if (picCave.Bounds.IntersectsWith(picPlayer.Bounds))
            {
                GoToNextLevel(new Cave(score+ scoreFromPreviousLevel, SelectChar));
            }
            if (picFinal.Bounds.IntersectsWith(picPlayer.Bounds))
            {
                GoToNextLevel(new lvl_e(score+ scoreFromPreviousLevel, SelectChar));
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            UpdatePlayerHealth();
            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Score: " + (score + scoreFromPreviousLevel);
            playerMove();
            UpdateEnemies();
            CheckBulletCollisions();
        }

        private void UpdatePlayerHealth()
        {
            if (playerHealth > 1)
            {
                HPbar.Value = playerHealth;
            }
            else
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            gameOver = true;
            GameTimer.Stop();
            this.Hide();
            GameOver go = new GameOver();
            go.ShowDialog();
            this.Close();
        }

        private void playerMove()
        {
            int moveAmount = 10;
            if (right && picPlayer.Left < 500)
            {
                picPlayer.Left += moveAmount;
            }
            if (left && picPlayer.Left > 20)
            {
                picPlayer.Left -= moveAmount;
            }
            if (up && picPlayer.Top > 20)
            {
                picPlayer.Top -= moveAmount;
            }
            if (down && picPlayer.Top < 260)
            {
                picPlayer.Top += moveAmount;
            }
        }

        private void ShootBullet(string direction)
        {
            Bullet shoot = new Bullet();
            shoot.direction = direction;
            shoot.bulletLeft = picPlayer.Left + (picPlayer.Width / 2);
            shoot.bulletTop = picPlayer.Top + (picPlayer.Height / 2);
            shoot.MakeBullet(this);
        }

        private void UpdateEnemies()
        {
            foreach (PictureBox enemy in enList)
            {
                if (picPlayer.Bounds.IntersectsWith(enemy.Bounds))
                {
                    playerHealth -= 1;
                }

                foreach (PictureBox en in enList)
                {
                    // Move towards the player along the X-axis
                    if (enemy.Left > picPlayer.Left)
                    {
                        enemy.Left -= enSpeed;
                        enemy.Image = Properties.Resources.enLeft;
                    }
                    else if (enemy.Left < picPlayer.Left)
                    {
                        enemy.Left += enSpeed;
                        enemy.Image = Properties.Resources.enRight;
                    }

                    // Move towards the player along the Y-axis
                    if (enemy.Top > picPlayer.Top)
                    {
                        enemy.Top -= enSpeed;
                        enemy.Image = Properties.Resources.enBack;
                    }
                    else if (enemy.Top < picPlayer.Top)
                    {
                        enemy.Top += enSpeed;
                        enemy.Image = Properties.Resources.enFont;
                    }

                    // Check collision with the player
                    if (picPlayer.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        playerHealth -= 1;
                    }
                }
            }
        }

        private void CheckBulletCollisions()
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
                if (x is PictureBox && (string)x.Tag == "block")
                {
                    // Kiểm tra nếu vị trí của người chơi giao nhau với vị trí của PictureBox "block"
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (right)
                        {
                            // Move player back to avoid collision
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
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    foreach (Control enemy in this.Controls)
                    {
                        if (enemy is PictureBox && (string)enemy.Tag == "en" && enemy.Bounds.IntersectsWith(x.Bounds))
                        {
                            score++;
                            this.Controls.Remove(x);
                            this.Controls.Remove(enemy);
                            enList.Remove((PictureBox)enemy);
                            ((PictureBox)enemy).Dispose();
                            ((PictureBox)x).Dispose();
                            SpawnEnemy();
                        }
                    }
                }
            }
        }

        public void SpawnEnemy()
        {
            PictureBox enemy = new PictureBox();
            enemy.Tag = "en";
            enemy.Image = Properties.Resources.enFont;
            enemy.Left = random.Next(0, 700);
            enemy.Top = random.Next(0, 400);
            enemy.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy.BackColor = Color.Transparent;
            enList.Add(enemy);
            this.Controls.Add(enemy);
            picPlayer.BringToFront();
        }

        public void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.Shuriken;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.BackColor = Color.Transparent;
            ammo.Left = random.Next(100, this.ClientSize.Width - ammo.Width - 100);
            ammo.Top = random.Next(200, this.ClientSize.Height - ammo.Height - 50);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            picPlayer.BringToFront();
        }

        private void GoToNextLevel(Form nextLevel)
        {
            this.Hide();
            GameTimer.Stop();
            nextLevel.ShowDialog();
            this.Close();
        }

        public void RestartGame()
        {
            foreach (PictureBox enemy in enList)
            {
                this.Controls.Remove(enemy);
                enemy.Dispose();
            }
            enList.Clear();
            for (int i = 0; i < 1; i++)
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
