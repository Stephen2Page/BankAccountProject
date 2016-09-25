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
        private Dictionary<string, int> clientAccountNumbers = new Dictionary<string, int>(); //accountNumber, accountType
        private Dictionary<int, Account> clientAccounts = new Dictionary<int, Account>();

        //Properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; ; }
        }
        public Dictionary<string, int> ClientAccountNumbers
        {
            get { return this.clientAccountNumbers; }
            set { this.clientAccountNumbers = value; }
        }
        public Dictionary<int, Account> ClientAccounts
        {
            get { return this.clientAccounts; }
            set { this.clientAccounts = value; }
        }

        //Constructors
        public Client(string clientName)    //Using type of account as key for expedience
        {
            ClientName = clientName;
            ClientAccountNumbers = clientAccountNumbers;
            ClientAccountNumbers.Add("Checking", 1234);
            ClientAccountNumbers.Add("Savings ", 7890);
            ClientAccountNumbers.Add("Reserve ", 2468);

            Checking currentChecking = new Checking(ClientAccountNumbers["Checking"], ClientName, 500.00);
            ClientAccounts.Add(1234, currentChecking);

            Savings currentSavings = new Savings(ClientAccountNumbers["Savings "], ClientName, 2000.00);
            ClientAccounts.Add(7890, currentSavings);

            Reserve currentReserve = new Reserve(ClientAccountNumbers["Reserve "], ClientName, 100.00);
            ClientAccounts.Add(2468, currentReserve);


        }

        //Methods
    }
}
