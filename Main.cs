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

namespace Piantoni_Isabella_991392679_Assignment2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //name box
        }

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection conn;
            SqlCommand command;

            connectionString = @"Data Source = DESKTOP-76CQ0MM\SQLEXPRESS; Initial Catalog = Sheridan_Sports_DB; Integrated Security = SSPI; Persist Security Info = False";
            conn = new SqlConnection(connectionString);
            string commandString = "insert into dbo.PLAYERS (FirstName, LastName, SportName, Age) values(@FirstName, @LastName, @SportName, @AgePicker)";


            try
            {
                conn.Open();
                command = new SqlCommand(commandString, conn);

                command.Parameters.AddWithValue("@FirstName", this.FirstName.Text);
                command.Parameters.AddWithValue("@LastName", this.LastName.Text);
                command.Parameters.AddWithValue("@SportName", this.SportName.Text);
                command.Parameters.AddWithValue("@AgePicker", int.Parse(this.AgePicker.Text));

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " player record added!");

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL!" + ex.Message);
            }
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SportName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete deletePopup = new Delete();
            DialogResult dialogresult = deletePopup.ShowDialog();
    }

        private void PlayerEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlayerViewBtn_Click(object sender, EventArgs e)
        {
            //Select player, put data into thing. 

        }
    }
}
