using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace Game02
{
    public partial class lvl_b : Form
    {

        bool right, left, up, down, gameOver;
        int SelectChar;
        Char player;
        string facing = "up";
        Char p1 = new Char();
        int playerHealth = 100;
        int enSpeed = 5;
        Random randNum = new Random();
        List<PictureBox> enList = new List<PictureBox>();
        public lvl_b(int choice)
        {
            InitializeComponent();
            SelectChar = choice;

        }
        private void lvl_b_Load(object sender, EventArgs e)
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

      
        void playerMove()
        {
            if (right == true)
            {
                if (picPlayer.Left < 0)
                {
                    picPlayer.Left += 10;
                }
            }
            if (left == true)
            {
                if (picPlayer.Left > 0)
                {
                    picPlayer.Left -= 10;
                }
            }
            if (up == true)
            {
                if (picPlayer.Top > 0)
                {
                    picPlayer.Top -= 10;
                }
            }
            if (down == true)
            {
                if (picPlayer.Top < 0)
                {
                    picPlayer.Top += 10;
                }
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (SelectChar == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        right = true;
                        picPlayer.Image = Properties.Resources.p1_D;
                        break;
                    case Keys.Left:
                        left = true;
                        picPlayer.Image = Properties.Resources.p1_c;
                        break;
                    case Keys.Up:
                        up = true;
                        picPlayer.Image = Properties.Resources.p1_b;
                        break;
                    case Keys.Down:
                        down = true;
                        picPlayer.Image = Properties.Resources.p1_a;
                        break;
                }
            }
            else if (SelectChar == 2)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        right = true;
                        picPlayer.Image = Properties.Resources.p2_d;
                        break;
                    case Keys.Left:
                        left = true;
                        picPlayer.Image = Properties.Resources.p2_c;
                        break;
                    case Keys.Up:
                        up = true;
                        picPlayer.Image = Properties.Resources.p2_b;
                        break;
                    case Keys.Down:
                        down = true;
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
            
        }

       

       

       
        private void ShootBullet(string direction)
        {

        }
        private void MakeZombies()
        {

        }
        private void RestartGame()
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            playerMove();

        }
    }
}
