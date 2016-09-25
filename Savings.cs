using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Account
    {
        //Fields
        private float interestRate;
        private double minmumBalance;
        private double serviceFee;

        //Properties
        public float InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
        public double MinimumBalance
        {
            get { return this.minmumBalance; }
            set { this.minmumBalance = value; }
        }
        //Contructors
        public Savings(int accountNum, string clientName, double balance)
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
            FileName = CreateFile(ClientName, AccountNum, "Savings", Balance);

        }

        //Methods

    }
}
