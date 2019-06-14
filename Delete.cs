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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();

            string connectionString = null;
            string commandString = null;
            SqlConnection conn;
            SqlCommand command;
            SqlDataReader reader;

            connectionString = @"Data Source = DESKTOP-76CQ0MM\SQLEXPRESS; Initial Catalog = Sheridan_Sports_DB; Integrated Security = SSPI; Persist Security Info = False";
            conn = new SqlConnection(connectionString);
            commandString = "SELECT PlayerId, FirstName, LastName FROM dbo.PLAYERS";


            try
            {
                conn.Open();
                command = new SqlCommand(commandString, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    playerDeleteList.Items.Add(reader["PlayerId"].ToString() +" - "+ reader["FirstName"].ToString() +" "+ reader["LastName"].ToString());
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL!" + ex.Message);
            }
        }

        private void PlayerDeleteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void InnerDeleteBtn_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            string commandString = null;
            SqlConnection conn;
            SqlCommand command;

            connectionString = @"Data Source = DESKTOP-76CQ0MM\SQLEXPRESS; Initial Catalog = Sheridan_Sports_DB; Integrated Security = SSPI; Persist Security Info = False";
            conn = new SqlConnection(connectionString);
            commandString = "DELETE FROM dbo.PLAYERS WHERE PlayerId=@PlayerId";


            try
            {
                conn.Open();
                command = new SqlCommand(commandString, conn);

                command.Parameters.AddWithValue("@PlayerId", Convert.ToInt32(playerDeleteList.Text.Split()[0]));
                int r = command.ExecuteNonQuery();
                MessageBox.Show(r + " player record deleted!");

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL!" + ex.Message);
            }
        }
    }
}
