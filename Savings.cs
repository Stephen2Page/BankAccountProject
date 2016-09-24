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

        //Properties

        //Contructors
        public Savings(int accountNum, string clientName, double balance)
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
            FileName = CreateFile(ClientName, AccountNum, "Savings");

        }

        //Methods

    }
}
