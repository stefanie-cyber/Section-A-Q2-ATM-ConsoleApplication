using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_A_Q2_ATM_ConsoleApplication
{
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("==== CTU SIMPLE ATM SYSTEM ====");
            Console.WriteLine();

               Console.WriteLine("HI! What is your name?");
                string name = Console.ReadLine();

            Console.WriteLine();
                Console.WriteLine("WELCOME " + name.ToUpper() + "!");

               
              double balance;
                Console.Write("Enter account balance: ");
               while (!double.TryParse(Console.ReadLine(), out balance))

                {
                   Console.Write("Invalid input. Enter account balance: ");
                }

             
                double withdrawal;
              Console.Write("Enter withdrawal amount: ");
                 while (!double.TryParse(Console.ReadLine(), out withdrawal))


                {

              Console.Write("Invalid input. Enter withdrawal amount: ");

              }

            Console.WriteLine();

              
                if (withdrawal <= balance)

         {
               balance = balance - withdrawal;

               Console.WriteLine("Withdrawal successful!");
                   Console.WriteLine("Updated Balance: " + balance.ToString ("0.00").Replace ('.',','));
                    Console.WriteLine("Transaction Time: " +
                        DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));

                }

                else

                {

                 Console.WriteLine("Insufficient funds!");
                    Console.WriteLine("Transaction cancelled.");

                }

               Console.ReadKey();
            }
        }
    }
