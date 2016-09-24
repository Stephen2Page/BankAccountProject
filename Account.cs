using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

        //  Overdrawn

        public string CreateFile(string clientName, int accountNum, string accountType)
        {
            string fileName = clientName + " " + accountNum + ".txt";
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(clientName + "\t" + accountType + "\t" + accountNum);
            writer.WriteLine();
            writer.WriteLine("Date  Time\t| Type | Amout | Balance ");
            writer.Close();
            return fileName;
        }

        public void WriteFile(string fileName, string transaction)
        {

            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(transaction);
            writer.Close();
        }

    }
}
