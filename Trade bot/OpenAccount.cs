//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
////using MetaTrader5;
//using Mt5;
//using mtapi;
//using MetaQuotes;

//namespace Trade_bot
//{
//    public partial class OpenAccount : Form
//    {
//        public OpenAccount()
//        {
//            InitializeComponent();
//            LoadBrokerList();
//        }

//        private void LoadBrokerList()
//        {
//            try
//            {
//                // Fetch broker names from MT5 API
//                List<string> brokers = FetchBrokersFromMT5API();

//                if (brokers != null && brokers.Count > 0)
//                {
//                    comboBoxBroker.Items.AddRange(brokers.ToArray());
//                    comboBoxBroker.SelectedIndex = 0; // Select the first broker by default
//                }
//                else
//                {
//                    MessageBox.Show("No brokers available. Please check your internet connection or MT5 setup.");
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error fetching brokers: " + ex.Message);
//            }
//        }
//        private bool LoginToBroker(string brokerName, string username, string password)
//        {
//            // Initialize MetaTrader5 API and login
//            MetaTrader5API api = new MetaTrader5API();

//            // Set broker connection details
//            api.SetBroker(brokerName);

//            // Attempt to login
//            bool loginResult = api.Login(username, password);

//            return loginResult;
//        }
//        private List<string> FetchBrokersFromMT5API()
//        {
//            // This method should interact with the MT5 API to fetch the list of brokers.
//            MetaTrader5API api = new MetaTrader5API();
//            return api.GetAvailableBrokers();
//        }
//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string brokerName = comboBoxBroker.SelectedItem.ToString();
//            string username = txtUsername.Text;
//            string password = txtPassword.Text;

//            // Use the MetaTrader5 API to log in
//            bool loginResult = LoginToBroker(brokerName, username, password);

//            if (loginResult)
//            {
//                MessageBox.Show("Login successful!");
//                // Optionally, you can navigate to the portfolio form or close this form
//            }
//            else
//            {
//                MessageBox.Show("Login failed. Please check your credentials.");
//            }
//        }
//    }
//}
