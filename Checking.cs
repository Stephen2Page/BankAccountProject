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
        private double serviceFee;

        //Properties
        public int CheckNum
        {
            get { return this.checkNum; }
            set { this.checkNum = value; }
        }
        public double ServiceFee
        {
            get { return this.serviceFee; }
            set { this.serviceFee = value; }
        }

        //Constructors
        public Checking(int accountNum, string clientName, double balance) 
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
            ServiceFee = 5.00;
            FileName = CreateFile(ClientName, AccountNum, "Checking", Balance);
            
        }

        //Methods
        public override double Withdrawl()
        {
            Console.WriteLine("Please enter check number. (press enter if none)");
            Console.Write(">");
            string checkNumEntered = Console.ReadLine();
            if (int.TryParse(checkNumEntered, out checkNum))
            {
                checkNum = int.Parse(checkNumEntered);
            }
            else
            {
                return Withdrawl();
            }
            //Process check
            Console.WriteLine("Please enter amount of check");
            Console.Write(">");
            double withdrawl;
            while (!double.TryParse((Console.ReadLine()), out withdrawl))
            {
                Console.WriteLine("Please enter a valid dollar amount");
                Console.Write(">");
            }
            if (withdrawl > Balance)
            {
                //transfer money from reserve
                //access service fee
                //write to file
                //notify user on screen
            }

                Balance -= withdrawl;
            WriteFile(FileName, '-', withdrawl, Balance);  //save to file & display on screen
            return withdrawl;

        }
    }
}
