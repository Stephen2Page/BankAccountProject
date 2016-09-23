using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking myChecking = new Checking(2468, "Magdalena D. Williams", 100.00);
            //Reserve
            //Savings
            DisplayMainMenu(myChecking);

            Console.WriteLine(myChecking.AccountNum);
        }

       //METHODS
        static int MenuChoice()
        {
            Console.WriteLine();
            Console.Write(">");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            return choice;
        }
        static void DisplayMainMenu(Checking currentAccount)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine();
            Console.WriteLine("1.\tView Client Information");
            Console.WriteLine("2.\tView Account Balance");
            Console.WriteLine("3.\tDeposit Funds");
            Console.WriteLine("4.\tWithdraw Funds");
            Console.WriteLine("5.\tExit");

            switch (MenuChoice())
            {
                case 1:         //Client Information, Name, Account numbers

                    break;
                case 2:         //Account Balance -- call submenu
                    DisplayBalanceMenu(currentAccount);
                    break;
                case 3:         //Deposit
                                    //Which account, amount
                    break;
                case 4:         //Withdrawl
                    
                    break;
                case 5:         //Exit
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        static void DisplayBalanceMenu(Checking currentAccount)
        {
            Console.WriteLine("Balance Menu");
            Console.WriteLine("");
            Console.WriteLine("1.\tChecking Account Balance");
            Console.WriteLine("2.\tReserve Account Balance");
            Console.WriteLine("3.\tSavings Account Balance");
            Console.WriteLine("4.\tReturn to Main Menu");

            switch (MenuChoice())
            {
                case 1:         //Checking Balance

                    break;
                case 2:         //Reserve Balance

                    break;
                case 3:         //Savings Balance

                    break;
                case 4:
                    DisplayMainMenu(currentAccount);
                    break;
            }

        }
    }
}
