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
        private string fileName;


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
        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }
    
        //Methods
        public virtual void Transaction()
        {

        }
        //  Deposit
        public virtual double Deposit()
        {
            Console.WriteLine("Enter amount to be deposted.");
            Console.Write(">");
            double deposit = double.Parse(Console.ReadLine());

            Balance += deposit;
            string transaction = ("date&time + " + deposit + "\t" + Balance);
            WriteFile(FileName, transaction);  //save to file & display on screen
            return deposit;
        }
        //  Withdrawl
        public virtual double Withdrawl()
        {
            Console.WriteLine("Please enter amount of withdrawl");
            Console.Write(">");
            double withdrawl = double.Parse(Console.ReadLine());
            //Check for overdrawn

            Balance -= withdrawl;
            string transaction = ("date&time - " + withdrawl + "\t" + Balance);
            WriteFile(FileName, transaction);  //save to file & display on screen
            return withdrawl;
        }
        //  Balance

        //  Overdrawn

        public string CreateFile(string clientName, int accountNum, string accountType)
        {
            string fileName = (clientName + " " + accountNum + ".txt");
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(clientName + "\t" + accountType + "\t" + accountNum);
            writer.WriteLine();
            writer.WriteLine("Date  Time\t| Type | Amout | Balance ");
            writer.WriteLine();
            writer.Close();

            return fileName;
        }

        public void WriteFile(string fileName, string transaction)
        {
            StreamWriter writer = new StreamWriter(fileName, true);

            Console.WriteLine("Date  Time\t| Type | Amout | Balance ");
            Console.WriteLine(transaction);            
            Console.ReadKey();

            writer.WriteLine(transaction);
            writer.Close();
        }

    }
}
