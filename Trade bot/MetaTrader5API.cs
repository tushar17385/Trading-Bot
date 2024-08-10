//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Mt5;
//using MetaQuotes;
//using mtapi;


//namespace Trade_bot
//{
//   public class MetaTrader5API
//    {
//        private MtApiClient _client;

//        public MetaTrader5API()
//        {
//            _client = new MtApiClient();
//        }

//        public void SetBroker(string brokerName)
//        {
//            // Configure API settings for the selected broker
//            // This is still a placeholder implementation
//            _client.SetBrokerServer(brokerName);
//        }

//        public bool Login(string username, string password)
//        {
//            // Perform the actual login using MetaTrader5 API
//            // Replace this with actual API call.
//            var result = _client.Login(username, password);
//            return result == 0; // Assuming 0 is success
//        }

//        public List<string> GetAvailableBrokers()
//        {
//            List<string> brokers = new List<string>();

//            // Example of how to fetch brokers from the MetaTrader5 API
//            if (_client.Connect())
//            {
//                string[] companies = _client.GetBrokers(); // Hypothetical method
//                if (companies != null && companies.Length > 0)
//                {
//                    brokers.AddRange(companies);
//                }
//                _client.Disconnect();
//            }

//            return brokers;
//        }
//    }


//}
