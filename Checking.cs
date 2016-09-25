using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Account
    {
        //Fields
        private int checkNum;
        private double minimumBalance;

        //Properties
        public int CheckNum
        {
            get { return this.checkNum; }
            set { this.checkNum = value; }
        }
        public double MinimumBalance
        {
            get { return this.minimumBalance; }
            set { this.minimumBalance = value; }
        }

        //Constructors
        public Checking(int accountNum, string clientName, double balance) 
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
            FileName = CreateFile(ClientName, AccountNum, "Checking");
            
        }

        //Methods
        public override double Withdrawl()
        {
            Console.WriteLine("Please enter check number. (press enter is none)");
            Console.Write(">");
            string checkNumEntered = Console.ReadLine();
            if (int.TryParse(checkNumEntered, out checkNum))
            {
                checkNum = int.Parse(checkNumEntered);
            }
            return base.Withdrawl();
            //May need following code if base call is not working with checknum
            //Console.WriteLine("Please enter amount of withdrawl");
            //Console.Write(">");
            //double withdrawl = double.Parse(Console.ReadLine());
            ////Check for overdrawn
            //Balance -= withdrawl;
            //string transaction = ("date&time - " + withdrawl + "\t" + Balance);
            //WriteFile(FileName, transaction);  //save to file & display on screen
            //return withdrawl;
        }
    }
}
