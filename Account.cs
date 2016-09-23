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
        int accountNum;
        string accountType;
        double balance;

        //Properties
        public int AccountNum
        {
            get { return this.accountNum; }
            set { this.accountNum = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
            

        //Constructors
        public Account(int accountNum, string accountType, double balance)
        {
            AccountNum = accountNum;
            AccountType = accountType;
            Balance = balance;
        }

        //Methods
        //  Deposit
        public double Deposit()
        {
            Console.WriteLine("Enter amount to be deposted.");
            double deposit = double.Parse(Console.ReadLine());
            return deposit;
        }
        //  Withdrawl
        public double Withdrawl()
        {
            Console.WriteLine("Enter amount to be withdrawn.");
            double withdrawl = double.Parse(Console.ReadLine());
            return withdrawl;
        }
        //  Balance
    }
}
