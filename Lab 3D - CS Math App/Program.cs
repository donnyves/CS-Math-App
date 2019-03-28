using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3D___CS_Math_App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1;
                int num2;
                string operand;
                ConsoleKeyInfo status;
                float answer;

                while (true)
                {
                    Console.WriteLine("Welcome to Donnyves' Super fun Calculator");
                    Console.WriteLine("I dare you to divide an integer by 0!!!)");
                    Console.Write("Please enter the first integer: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter an operand (+, -, /, *): ");
                    operand = Console.ReadLine();
                    Console.Write("Please enter the second integer: ");
                    num2 = Convert.ToInt32(Console.ReadLine());


                    switch (operand)
                    {
                        case "-":
                            answer = num1 - num2;
                            break;
                        case "+":
                            answer = num1 + num2;
                            break;
                        case "/":
                            answer = num1 / num2;
                            break;
                        case "*":
                            answer = num1 * num2;
                            break;
                        default:
                            answer = 0;
                            break;
                    }

                    Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                    Console.WriteLine("\n\n Thanks for stopping by!!! press E to exit!");
                    status = Console.ReadKey();
                    if (status.Key == ConsoleKey.E)
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine();
                }
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("You cannot divide by 0.");
            }
            finally
            {
                Console.WriteLine(" Program Ended");
            }

            Console.ReadLine();

        }
    }
}

