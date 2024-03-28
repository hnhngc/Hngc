using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin___tke
{
    public partial class Setting_Game : Form
    {
        public Setting_Game()
        {
            InitializeComponent();
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Game admin_Game = new Admin_Game();
            admin_Game.Show();

        }

        private void txt_NameG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Des_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string gameID = txt_gameid.Text;
            string gameName = txt_NameG.Text;
            string gameDescription = txt_Des.Text;

            // Cắt ngắn mô tả xuống độ dài tối đa 200 ký tự
            if (gameDescription.Length > 200)
            {
                gameDescription = gameDescription.Substring(0, 200);
            }

            using (SqlConnection sqlConnection = admin___tke.Kết_nối.getConnection())
            {
                sqlConnection.Open();

                string query = "INSERT INTO Games (GameID, GameName, NGAYPHATHANH, GameDescription) VALUES (@gameID, @gameName, @releaseDate, @gameDescription)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@gameID", gameID);
                sqlCommand.Parameters.AddWithValue("@gameName", gameName);
                sqlCommand.Parameters.AddWithValue("@releaseDate", DateTime.Today);
                sqlCommand.Parameters.AddWithValue("@gameDescription", gameDescription);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }

            MessageBox.Show("Trò chơi đã được lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pic_G_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.tif)|*.bmp;*.jpg;*.jpeg;*.png;*.tif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_G.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }   
}
