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
        public Checking(int accountNum, string clientName, double balance) //: base (accountNum, clientName, balance)
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
            }
        //Methods
        public override double Withdrawl()
        {
            //Check number
            return base.Withdrawl();
        }
    }
}
