using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

//TO DO
    //trap for blank enteries for amounts in withdraw and deposit
    //add savings and reserve accounts

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client currentClient = new Client("Magdalena D. Williams");
            //Checking currentChecking = new Checking(currentClient.ClientAccountNumbers["Checking"], currentClient.ClientName, 500.00);
            //Checking currentSaving = new Saving(currentClient.ClientAccounts["Savings "], currentClient.ClientName, 2000.00);
            //Checking currentReserve = new Reserve(currentClient.ClientAccounts["Reserve "], currentClient.ClientName, 100.00);

            //int acc = currentClient.ClientAccountNumbers["Checking"];
            //Console.WriteLine(currentClient.ClientAccountNumbers["Checking"]);
            //Console.ReadKey();

            while (true)
            {
                DisplayMainMenu();

                switch (MenuChoice())
                {
                    case 1:         //Client Information, Name, Account numbers
                        //Need screen position for proper alignment
                        Console.WriteLine(currentClient.ClientName);
                        Console.WriteLine();
                        Console.WriteLine("Account \tNumber");
                        foreach (KeyValuePair<string, int> account in currentClient.ClientAccountNumbers)
                        {
                            Console.WriteLine(account.Key +"\t"+ account.Value);
                        }
                        Console.WriteLine("Press a key to continue.");
                        Console.WriteLine(">");
                        Console.ReadKey();
                        break;
                    case 2:         //Account Balance -- call submenu
                        DisplayBalanceMenu(currentClient);
                        break;
                    case 3:         //Deposit
                        //action = 'D';
                        AccountMenu();               //Which account, amount
                        break;
                    case 4:         //Withdrawl
                        int accountNum = currentClient.ClientAccountNumbers[AccountMenu()];     //choose account
                        currentClient.ClientAccounts[accountNum].Withdrawl();                   //process the withdraw from choosen account
                        break;
                    case 5:         //Exit
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }

       //METHODS
        static int MenuChoice()
        {
            Console.WriteLine();
            Console.Write(">");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void DisplayMainMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Main Menu");
            Console.WriteLine();
            Console.WriteLine("1.\tView Client Information");
            Console.WriteLine("2.\tView Account Balance");
            Console.WriteLine("3.\tDeposit Funds");
            Console.WriteLine("4.\tWithdraw Funds");
            Console.WriteLine("5.\tExit");

        }
        static void DisplayBalanceMenu(Client currentClient)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Balance Menu");
            Console.WriteLine("");
            Console.WriteLine("1.\tChecking Account Balance");
            Console.WriteLine("2.\tReserve Account Balance");
            Console.WriteLine("3.\tSavings Account Balance");
            Console.WriteLine("4.\tReturn to Main Menu");

            switch (MenuChoice())
            {
                case 1:         //Checking Balance
                    Console.WriteLine(currentClient.ClientAccountNumbers);
                    break;
                case 2:         //Reserve Balance

                    break;
                case 3:         //Savings Balance

                    break;
                case 4:
                    //DisplayMainMenu();
                    break;
            }

        }
        static string AccountMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Account Menu");
            Console.WriteLine("");
            Console.WriteLine("1.\tChecking Account");
            Console.WriteLine("2.\tReserve Account");
            Console.WriteLine("3.\tSavings Account");
            Console.WriteLine("4.\tReturn to Main Menu");

            string choosenAccount = "";
            switch (MenuChoice())
            {
                case 1:         //Checking
                    return (choosenAccount = "Checking");
                    break;
                case 2:         //Reserve 
                    return (choosenAccount = "Reserve ");
                    break;
                case 3:         //Savings
                    return (choosenAccount = "Savings ");
                    break;
                default:
                    DisplayMainMenu();
                    break;
            }
            return choosenAccount;
        }
    }
}
