using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Reserve : Account
    {
        //Fields

        //Properties

        //Constructors
        public Reserve(int accountNum, string clientName, double balance)
        {
            AccountNum = accountNum;
            ClientName = clientName;
            Balance = balance;
            FileName = CreateFile(ClientName, AccountNum, "Reserve");

        }

        //Methods
    }
}
