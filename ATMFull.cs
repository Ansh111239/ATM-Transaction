using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{



    internal class Program
    {



        

        static void Transaction()
        {
            int choice;
            int WithAm;
            int pinpass = 1234;
            int Bal = 2034;
            int DepAm;
            int pin;
            Console.WriteLine("Enter pin");

            pin = Convert.ToInt32(Console.ReadLine());
            if (pin != pinpass)
            {
                Console.WriteLine("Incorrect Pin");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("1: Current Balance");
                Console.WriteLine("2: Withdraw");
                Console.WriteLine("3: Deposit");
                Console.WriteLine("4: Cancel");
                bool quit=false;
                do
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Your Current Balance is " + Bal);
                            
                            break;

                        case 2:
                            Console.WriteLine("Enter the ammount to Withdraw ");
                            WithAm = Convert.ToInt32(Console.ReadLine());

                            if (WithAm > Bal)
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                            else if(WithAm <= 0)
                            {
                                Console.WriteLine("Enter Positive Value");
                            }
                            else
                            {
                                Bal = Bal - WithAm;
                                Console.WriteLine(Bal);
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter the ammount to Deposit ");
                            DepAm = Convert.ToInt32(Console.ReadLine());
                            if (DepAm <= 0)
                            {
                                Console.WriteLine("Enter Positive Value");
                            }
                            else
                            {                                
                                Bal = Bal + DepAm;
                                Console.WriteLine(Bal);
                            }
                            
                            break;

                        case 4:
                            Console.WriteLine("Transaction Cancelled");
                            quit = true;
                            break;

                        default:
                            Console.WriteLine("Incorrect Choice");
                            Console.ReadLine();
                            break;
                    }
                }
                while (!quit);
                
                
            }

            

        }

        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO ABC BANK ATM SERVICE");


            Transaction();





        }
    }
}
