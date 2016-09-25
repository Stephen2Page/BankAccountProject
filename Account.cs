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
            double deposit;
            while (!double.TryParse((Console.ReadLine()), out deposit)) //checking for valid input
            {
                Console.WriteLine("Please enter a valid dollar amount.");
                Console.Write(">");
            }

            Balance += deposit;
            WriteFile(FileName, '+', deposit, Balance);  //save to file & display on screen
            return deposit;
        }
        //  Withdrawl
        public virtual double Withdrawl()
        {
            Console.WriteLine("Please enter amount of withdrawl");
            Console.Write(">");
            double withdrawl;
            while (!double.TryParse((Console.ReadLine()), out withdrawl))
            {
                Console.WriteLine("Please enter a valid dollar amount");
                Console.Write(">");
            }
            Overdrawn(withdrawl, Balance);                  //Check for overdrawn

            Balance -= withdrawl;
            WriteFile(FileName, '-', withdrawl, Balance);  //save to file & display on screen
            return withdrawl;
        }
        //  Balance

        //  Overdrawn
        public void Overdrawn(double withdrawl, double balance)
        {
            if (withdrawl > balance)
            {
                Console.WriteLine("Please check your balance and enter a smaller amount.");
            }
        }

        public string CreateFile(string clientName, int accountNum, string accountType, double balance)
        {
            //Creates a file when account is created, generates name and sets up header in file, returns file name to account object
            string fileName = (clientName + " " + accountNum + ".txt");
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(clientName + "\t" + accountType + "\tAccount #:  " + accountNum);
            writer.WriteLine();
            writer.WriteLine("  Date\t    Time\t  | Type |  Amout \t| Balance ");
            writer.WriteLine();
            writer.WriteLine("{0,0} {1,14} {2,18}", DateTime.Now, " Opening Balance:", balance.ToString("C"));
            writer.Close();

            return fileName;
        }

        public void WriteFile(string fileName, char transactionType, double withdrawl, double balance)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            
            Console.WriteLine("  Date\t    Time\t  | Type |  Amout \t| Balance ");
            Console.WriteLine("{0,0} {1,9} {2,9} {3,16}", DateTime.Now, transactionType, withdrawl.ToString("C"), balance.ToString("C"));
            Console.ReadKey();

            writer.WriteLine("{0,0} {1,9} {2,9} {3,16}", DateTime.Now, transactionType, withdrawl.ToString("C"), balance.ToString("C"));
            writer.Close();
        }

    }
}
