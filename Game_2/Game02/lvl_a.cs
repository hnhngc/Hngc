using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game02
{
    public partial class lvl_a : Form
    {
        int SelectChar;
        Char player;
        Char p1 = new Char();
        int score;
        private int scoreFromPreviousLevel;
        private string _username;
        private int _userID;
        public lvl_a(int choice, string username)
        {
            InitializeComponent();
            _username = username;
            SelectChar = choice;
        }

        private void lvl_a_Load(object sender, EventArgs e)
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
        bool right, left, up, down;
        void playerMove()
        {
            
            if (right==true) 
            {
                if (picPlayer.Left < 500)
                {
                    picPlayer.Left += 10;
                }
            }
            if(left == true)
            {
                if(picPlayer.Left > 20) 
                {
                    picPlayer.Left -= 10;
                }
            }
            if(up == true)
            {
                if (picPlayer.Top > 20)
                {
                    picPlayer.Top -= 10;
                }
            }
            if (down == true)
            {
                if(picPlayer.Top < 260)
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
            if (a1.Bounds.IntersectsWith(picPlayer.Bounds))
            {
                lvl_d ls = new lvl_d(score + scoreFromPreviousLevel, SelectChar, _username);
                this.Hide();
                timer1.Stop();
                ls.ShowDialog();
                this.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            playerMove();
            
            foreach (Control x in this.Controls)
            {
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
                
            }
            



        }
    }
}

