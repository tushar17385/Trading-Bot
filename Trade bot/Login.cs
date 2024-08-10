using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trade_bot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "server=localhost;uid=root;pwd=root;database=userid";

            string query = "SELECT COUNT(*), UserID FROM loginData WHERE uname = @username AND upass = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int result = reader.GetInt32(0);
                                if (result > 0)
                                {
                                    // Set session data
                                    UserSession.Username = username;
                                    UserSession.Password = password;
                                    UserSession.IsLoggedIn = true;
                                    UserSession.UserID = reader.GetInt32(1); // Assuming UserID is of type int
                                    

                                    MessageBox.Show("Login successful!");

                                    // Redirect to the main form or dashboard
                                    Home mainForm = new Home();
                                    mainForm.FormClosed += (s, args) => this.Close(); 
                                    this.Hide(); // Hide the login form
                                    mainForm.Show();
                                }
                                else
                                {
                                    // Handle login failure
                                    MessageBox.Show("Login failed! Please check your credentials.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
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

        private void Register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
