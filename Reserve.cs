using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Reserve : Account
    {
        //Fields
        private float interestRate;
        private double fee;        

        //Properties
        public float InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
        public double Fee
        {
            get { return this.fee; }
            set { this.fee = value; }
        }

        //Constructors
        public Reserve(int accountNum, string clientName, double balance)
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
            FileName = CreateFile(ClientName, AccountNum, "Reserve", Balance);

        }

        //Methods
    }
}
