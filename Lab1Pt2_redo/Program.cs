using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Pt2_redo
{
    class Program
    {
        private static int textnum1;
        private static int textnum2;
        private static int textlen1;
        private static int textlen2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Date Difference Machine.");

            string userInput;
            int intVal1;
            int intVal2;
            bool retry = true;
            bool inputblank = true;

            while (retry)
            {
                do
                {
                    Console.Write("Enter first value: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal1))
                    {
                        /* Converts to integer type */
                        intVal1 = Convert.ToInt32(userInput);
                        Console.WriteLine("You entered {0}", intVal1);
                        inputblank = false;
                    }
                } while (inputblank);

                inputblank = true;
                do
                {
                    Console.Write("Enter second value: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal2))
                    {
                        /* Converts to integer type */
                        intVal2 = Convert.ToInt32(userInput);
                        Console.WriteLine("You entered {0}", intVal2);
                        inputblank = false;
                    }
                } while (inputblank);

                bool x = true;

                if (intVal1.ToString() == "" && intVal2.ToString() == "")
                {
                    Console.WriteLine("Please enter a value.");
                }
                else if (intVal1.ToString().Length == 1 && intVal2.ToString().Length == 1)
                {
                    x = true;
                    Console.WriteLine("SUCCESS! But because it's only one number.");
                }
                else if (intVal1.ToString().Length == intVal2.ToString().Length)
                {
                    Console.WriteLine("Numbers are identical length.");
                    textnum1 = int.Parse(intVal1.ToString());
                    textnum2 = int.Parse(intVal2.ToString());
                    textlen1 = intVal1.ToString().Length;
                    textlen2 = intVal2.ToString().Length;

                    int i = 1;
                    int j = i + 1;
                    while (j <= textlen1 && x == true)
                    {
                        //Console.WriteLine(i);

                        var num1 = intVal1.ToString();
                        var num2 = intVal2.ToString();

                        if (num1[textlen1 - i] + num2[textlen2 - i] == num1[textlen1 - j] + num2[textlen2 - j])
                        {
                            x = true;
                        }
                        else
                        {
                            x = false;
                        }

                        i++;
                        j++;
                    }

                    if (x)
                    {
                        Console.WriteLine("SUCCESS! The sums of each digit of both numbers are equal.");
                    }
                    else
                    {
                        Console.WriteLine("FAIL! The sums of each digit are not equal.");
                    }
                }
                else
                {
                    Console.WriteLine("Numbers must be identical length.");
                }

                string key = "";
                while (key != "y" || key != "n")
                {
                    Console.WriteLine("Try again?");
                    Console.Write("[y/n]: ");
                    key = Console.ReadLine();
                    if (key == "y")
                    {
                        break;
                    }
                    if (key == "n")
                    {
                        retry = false;
                        break;
                    }
                }
            }
        }
    }
}
