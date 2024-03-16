using System;
using System.Windows.Forms;

namespace Game02
{
    public partial class Cave : Form
    {
        int SelectChar;
        int score;
        int playerHealth = 100;
        Char player;
        Char p1 = new Char();
        bool right, left, up, down, gameOver;
        private int scoreFromPreviousLevel;

        public Cave(int score, int choice)
        {
            InitializeComponent();
            SelectChar = choice;
            scoreFromPreviousLevel = score;
        }

        private void Cave_Load(object sender, EventArgs e)
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
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = true;
                    if (SelectChar == 1)
                        picPlayer.Image = Properties.Resources.p1_D;
                    else if (SelectChar == 2)
                        picPlayer.Image = Properties.Resources.p2_d;
                    break;
                case Keys.Left:
                    left = true;
                    if (SelectChar == 1)
                        picPlayer.Image = Properties.Resources.p1_c;
                    else if (SelectChar == 2)
                        picPlayer.Image = Properties.Resources.p2_c;
                    break;
                case Keys.Up:
                    up = true;
                    if (SelectChar == 1)
                        picPlayer.Image = Properties.Resources.p1_b;
                    else if (SelectChar == 2)
                        picPlayer.Image = Properties.Resources.p2_b;
                    break;
                case Keys.Down:
                    down = true;
                    if (SelectChar == 1)
                        picPlayer.Image = Properties.Resources.p1_a;
                    else if (SelectChar == 2)
                        picPlayer.Image = Properties.Resources.p2_a;
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
            }

            if (downArrow.Bounds.IntersectsWith(picPlayer.Bounds))
            {
                if (!picHam.Visible) // Nếu picHam được lấy
                {
                    lvl_c back = new lvl_c(score + scoreFromPreviousLevel, SelectChar); // Cộng điểm từ level trước
                    this.Hide();
                    GameTimer.Stop();
                    back.ShowDialog();
                    this.Close();
                }
                else
                {
                    dialogBox1.Visible = true;
                    Timer dialogTimer = new Timer();
                    dialogTimer.Interval = 2000; // 2000 milliseconds = 2 seconds
                    dialogTimer.Tick += (s, args) =>
                    {
                        dialogTimer.Stop();
                        dialogBox1.Visible = false;
                    };
                    dialogTimer.Start();
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
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
            txtAmmo.Text = "Ammo: 10 ";
            txtScore.Text = "Score: " + (score + scoreFromPreviousLevel);
            playerMove();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        score += 5;
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
                if (x is PictureBox && (string)x.Tag == "tools")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        picHam.Visible = false;
                    }
                }
            }
        }

        void playerMove()
        {
            if (right == true && picPlayer.Left < 500)
                picPlayer.Left += 10;
            if (left == true && picPlayer.Left > 20)
                picPlayer.Left -= 10;
            if (up == true && picPlayer.Top > 20)
                picPlayer.Top -= 10;
            if (down == true && picPlayer.Top < 260)
                picPlayer.Top += 10;
        }

        public void RestartGame()
        {
            up = false;
            down = false;
            left = false;
            right = false;
            playerHealth = 100;
            score = 0;
            GameTimer.Start();
        }
    }
}
