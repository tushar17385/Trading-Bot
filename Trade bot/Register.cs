using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Trade_bot
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string nickname = textBox3.Text;

            string connectionString = "server=localhost;uid=root;pwd=root;database=userid";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM loginData WHERE uname = @username OR nickname = @nickname";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@nickname", nickname);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Username or nickname already exists. Please choose a different one.");
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO loginData (uname, upass, nickname) VALUES (@username, @password, @nickname)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@username", username);
                                insertCmd.Parameters.AddWithValue("@password", password);
                                insertCmd.Parameters.AddWithValue("@nickname", nickname);

                                insertCmd.ExecuteNonQuery();

                                MessageBox.Show("Registration successful!");

                                 this.Close();
                                 Login loginForm = new Login();
                                 loginForm.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
