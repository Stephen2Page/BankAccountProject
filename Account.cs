using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account
    {
        //Fields
        private int accountNum;
        private string clientName;
        private double balance;

        //Properties
        public int AccountNum
        {
            get { return this.accountNum; }
            set { this.accountNum = value; }
        }
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
            

        //Constructors
        //public Account
        //    {
        //    }
        //public Account(int accountNum, string accountType, double balance)
        //{
        //    AccountNum = accountNum;
        //    AccountType = accountType;
        //    Balance = balance;
        //}

        //Methods
        public virtual void Transaction()
        {

        }
        //  Deposit
        public virtual double Deposit()
        {
            Console.WriteLine("Enter amount to be deposted.");
            double deposit = double.Parse(Console.ReadLine());
            return deposit;
        }
        //  Withdrawl
        public virtual double Withdrawl()
        {
            Console.WriteLine("Enter amount to be withdrawn.");
            double withdrawl = double.Parse(Console.ReadLine());
            return withdrawl;
        }
        //  Balance
    }
}
