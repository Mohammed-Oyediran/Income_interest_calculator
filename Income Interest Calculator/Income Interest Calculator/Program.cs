using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Interest_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Income Interest Calculator";

            Console.WriteLine("Welcome to the Income Interest Calculator! \n");
            bool isRunning = true;

            while (isRunning)
            {
                
                
                // Display the options
                int user_choice = 0;
                Console.WriteLine("Please select an option then hit enter: \n");
                Console.WriteLine("1. Calculate your income after interest");
                Console.WriteLine("2. Calculate your interest");
                Console.WriteLine("3. Exit the program\n");

                user_choice = Convert.ToInt32(user_input("Enter your choice: "));
                double user_income = 0;
                double user_interest_rate = 0;

                switch (user_choice)
                {
                    
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("You have selected to calculate your income after interest. \n");

                    user_income = user_input("Enter your income: ");
                    user_interest_rate = user_input("Enter the interest rate: ");
                    double total_net_income = user_income - CalculateInterest(user_income, user_interest_rate);

                    Console.WriteLine();    
                    Console.WriteLine($"Your total income after interest deduction is {total_net_income}.");
                    isRunning = false;
                        break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("You have selected to calculate your interest. \n");

                    user_income = user_input("Enter your income: ");
                    user_interest_rate = user_input("Enter the interest rate: ");

                    double total_interest = CalculateInterest(user_income, user_interest_rate);

                    Console.WriteLine();
                    Console.WriteLine($"Your total interest is {total_interest}.");
                    isRunning = false;
                        break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("You have selected to exit the program. \n");
                    
                    isRunning = false;
                        break;
                    default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice! Please try again.\n");
                        break;
                }; 


            }


            Console.WriteLine();
            Console.WriteLine("Thank you for using the Income Interest Calculator! \n");
            Console.ReadLine();




        }

        static double CalculateInterest(double income, double interest_rate)
        {
            return income * ((interest_rate / 100));
        }

        static double user_input(string message)
        {
            double user_input = 0;
            
            Console.Write(message);
            bool coverted_successfully = true;
            while (coverted_successfully)
            {
                try
                {
                    user_input = Convert.ToDouble(Console.ReadLine());
                    coverted_successfully = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message + "\n \nPlease try again! \n");
                    Console.Write(message);

                }

               
            }
            return user_input;
        }
    }
}
