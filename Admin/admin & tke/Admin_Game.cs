using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using ZedGraph;
using System.IO;

namespace admin___tke
{
    public partial class Admin_Game : Form
    {
        public Admin_Game()
        {
            InitializeComponent();
            
        }

        private void btn_SettingG1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_SettingG2_Click(object sender, EventArgs e)
        {
            this.Close();
            Setting_Game setting_Game = new Setting_Game();
            setting_Game.Show();
        }

        private void btn_GamePage_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Player admin_Player = new Admin_Player();
            admin_Player.Show();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string gameName = txt_Search.Text;

            using (SqlConnection sqlConnection = admin___tke.Kết_nối.getConnection())
            {
                sqlConnection.Open();

                string query = "SELECT GameName, GameDescription FROM Games WHERE GameName = @gameName";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@gameName", gameName);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.Read())
                    {
                        lblName_G1.Text = sqlDataReader.GetString(0);
                        lbl_des1.Text = sqlDataReader.IsDBNull(1) ? "" : sqlDataReader.GetString(1);
                    }
                    else
                    {
                        MessageBox.Show("Game not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                sqlConnection.Close();
            }
        }

        private void populateGameInfo(SqlDataReader sqlDataReader)
        {
            if (sqlDataReader.Read())
            {
                string gameID = sqlDataReader["GameID"].ToString();
                lblGameID.Text = gameID;
                lblName_G1.Text = sqlDataReader["GameName"].ToString();
                lbl_des1.Text = sqlDataReader["GameDescription"].ToString();
                // ReleaseDate.Value = (DateTime)sqlDataReader["NGAYPHATHANH"];
            }
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            this.Close();
            Setting_Game setting_Game = new Setting_Game();
            setting_Game.Show();
        }

        private void Admin_Game_Load(object sender, EventArgs e)
        {

        }

        private void btn_P2_Click(object sender, EventArgs e)
        {
            Admin_Game form2 = new Admin_Game();
            form2.Show();
            this.Hide();
        }
    }
}
