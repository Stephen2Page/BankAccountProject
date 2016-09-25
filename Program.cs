﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

//TO DO
    //trap for blank enteries for amounts in withdraw and deposit
    //Overdrawn or minimum balance
    //implement check numbers

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            bool currentUser = true;
            do
            {
                Console.WriteLine("Enter Account Holder's Name.");
                userName = (Console.ReadLine());
                Client currentClient = new Client(userName); //begining values hard coded under Client

                while (currentUser == true)
                {
                    DisplayMainMenu();
                    int accountNum;

                    switch (MenuChoice())
                    {
                        case 1:         //Client Information, Name, Account numbers
                                        //Need screen position for proper alignment
                            DisplayClientAccounts(currentClient);
                            break;
                        case 2:         //Account Balance -- call submenu
                            DisplayBalanceMenu(currentClient);
                            break;
                        case 3:         //Deposit
                            accountNum = currentClient.ClientAccountNumbers[AccountMenu()];     //choose account
                            currentClient.ClientAccounts[accountNum].Deposit();                   //process the withdraw from choosen account
                            break;
                        case 4:         //Withdrawl
                            accountNum = currentClient.ClientAccountNumbers[AccountMenu()];     //choose account
                            currentClient.ClientAccounts[accountNum].Withdrawl();                   //process the withdraw from choosen account
                            break;
                        case 5:         //Exit
                            Environment.Exit(0);
                            break;
                        default:
                            currentUser = false;
                            break;
                    }
                }
                currentUser = true;
            }
            while (true);
        }

       //METHODS
        static int MenuChoice()
        {
            Console.WriteLine();
            Console.Write(">");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static void PressAKey()
        {
            Console.WriteLine("Press a key to continue.");
            Console.Write(">");
            Console.ReadKey();
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
            Console.WriteLine("6.\tLogout to switch user");
        }

        static void DisplayClientAccounts(Client currentClient)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(currentClient.ClientName);
            Console.WriteLine();
            Console.WriteLine("Account \tNumber");
            Console.WriteLine();

            foreach (KeyValuePair<string, int> account in currentClient.ClientAccountNumbers)
            {
                Console.WriteLine(account.Key + "\t" + account.Value);
            }

            Console.WriteLine();
            PressAKey();
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

            int accountNum;
            switch (MenuChoice())
            {
                case 1:         //Checking Balance
                    accountNum = currentClient.ClientAccountNumbers["Checking"];
                    Console.WriteLine(currentClient.ClientAccounts[accountNum].Balance);
                    PressAKey();
                    break;
                case 2:         //Reserve Balance
                    accountNum = currentClient.ClientAccountNumbers["Reserve "];
                    Console.WriteLine(currentClient.ClientAccounts[accountNum].Balance);
                    PressAKey();
                    break;
                case 3:         //Savings Balance
                    accountNum = currentClient.ClientAccountNumbers["Savings "];
                    Console.WriteLine(currentClient.ClientAccounts[accountNum].Balance);
                    PressAKey();
                    break;
                case 4:
                    DisplayMainMenu();
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
