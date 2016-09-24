using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //Fields
        private string clientName;
        private Dictionary<int, string> clientAccounts = new Dictionary<int, string>(); //accountNumber, accountType

        //Properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; ; }
        }
        public Dictionary<int, string> ClientAccounts
        {
            get { return this.clientAccounts; }
            set { this.clientAccounts = value; }
        }

        //Constructors
        public Client(string clientName)    //Dictionary<int, string> clientAccounts)
        {
            ClientName = clientName;
            ClientAccounts = clientAccounts;
            ClientAccounts.Add(1234, "checking");
            ClientAccounts.Add(7890, "savings");

        }
        //Methods
        //display cusotmer name and accounts for menu item 1.
    }
}
