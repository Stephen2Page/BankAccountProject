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

        //Properties

        //Constructors
        public Checking(int accountNum, string clientName, double balance) 
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
        }

        //Methods
        public override double Withdrawl()
        {
            Console.WriteLine("Please enter check number. (press enter is none)");
            string checkNumEntered = Console.ReadLine();
            if (checkNumEntered != null)
            {
                int checkNum = int.Parse(checkNumEntered);
            } 
            Console.WriteLine("Please enter amount of withdrawl");
            double withdrawl = double.Parse(Console.ReadLine());
            //adjust balance
            //save to file & display on screen
            return withdrawl;
        }
    }
}
