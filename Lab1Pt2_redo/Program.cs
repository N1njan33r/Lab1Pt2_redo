using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Pt2_redo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Date Difference Machine.");

            string userInput;
            int intVal1;
            int intVal2;
            int intVal3;
            string month;
            bool retry = true;
            bool inputblank = true;

            while (retry)
            {
                Console.WriteLine("=====Date 1=====");
                do
                {
                    Console.Write("Enter year: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal3))
                    {
                        /* Converts to integer type */
                        intVal3 = Convert.ToInt32(userInput);
                        //Console.WriteLine("You entered {0}", intVal3);
                        inputblank = false;
                    }
                } while (inputblank);
                inputblank = true;

                do
                {
                    Console.Write("Enter month: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal2))
                    {
                        /* Converts to integer type */
                        intVal2 = Convert.ToInt32(userInput);
                        //Console.WriteLine("You entered {0}", intVal1);
                        if (intVal2 > 0 && intVal2 <= 12)
                        {
                            inputblank = false;
                        }
                        else
                        {
                            Console.WriteLine("Month must be within range [1-12]");
                        }
                    }
                } while (inputblank);
                month = new DateTime(1, intVal2, 1).ToString("MMMM");
                inputblank = true;

                do
                {
                    Console.Write("Enter day: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal1))
                    {
                        /* Converts to integer type */
                        intVal1 = Convert.ToInt32(userInput);
                        //Console.WriteLine("You entered {0}", intVal2);
                        if (intVal1 > 0 && intVal1 <= DateTime.DaysInMonth(intVal3, intVal2))
                        {
                            inputblank = false;
                        }
                        else if(intVal1 > DateTime.DaysInMonth(intVal3, intVal2))
                        {
                            Console.WriteLine($"There are only {DateTime.DaysInMonth(intVal3, intVal2)} days in {month}");
                        }
                    }
                } while (inputblank);
                inputblank = true;

                DateTime date1 = new DateTime(intVal3, intVal2, intVal1);
                Console.WriteLine(date1);

                Console.WriteLine("=====Date 2=====");
                do
                {
                    Console.Write("Enter year: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal3))
                    {
                        /* Converts to integer type */
                        intVal3 = Convert.ToInt32(userInput);
                        //Console.WriteLine("You entered {0}", intVal3);
                        inputblank = false;
                    }
                } while (inputblank);
                inputblank = true;

                do
                {
                    Console.Write("Enter month: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal2))
                    {
                        /* Converts to integer type */
                        intVal2 = Convert.ToInt32(userInput);
                        //Console.WriteLine("You entered {0}", intVal1);
                        if (intVal2 > 0 && intVal2 <= 12)
                        {
                            inputblank = false;
                        }
                        else
                        {
                            Console.WriteLine("Month must be within range [1-12]");
                        }
                    }
                } while (inputblank);
                month = new DateTime(1, intVal2, 1).ToString("MMMM");
                inputblank = true;

                do
                {
                    Console.Write("Enter day: ");
                    userInput = Console.ReadLine();
                    if (Int32.TryParse(userInput, out intVal1))
                    {
                        /* Converts to integer type */
                        intVal1 = Convert.ToInt32(userInput);
                        //Console.WriteLine("You entered {0}", intVal2);
                        if (intVal1 > 0 && intVal1 <= DateTime.DaysInMonth(intVal3, intVal2))
                        {
                            inputblank = false;
                        }
                        else if (intVal1 > DateTime.DaysInMonth(intVal3, intVal2))
                        {
                            Console.WriteLine($"There are only {DateTime.DaysInMonth(intVal3, intVal2)} days in {month}");
                        }
                    }
                } while (inputblank);
                inputblank = true;

                DateTime date2 = new DateTime(intVal3, intVal2, intVal1);
                Console.WriteLine(date2);

                Console.WriteLine("Difference between two dates is: ");
                if (date1 < date2)
                {
                    TimeSpan span = date2.Subtract(date1);
                    Console.WriteLine(span.TotalMinutes + " minutes");
                    Console.WriteLine("~~OR~~");
                    Console.WriteLine(span.TotalHours + " hours");
                    Console.WriteLine("~~OR~~");
                    Console.WriteLine(span.Days + " days");
                }
                else if (date2 < date1)
                {
                    TimeSpan span = date1.Subtract(date2);
                    Console.WriteLine(span.TotalMinutes + " minutes");
                    Console.WriteLine("~~OR~~");
                    Console.WriteLine(span.TotalHours + " hours");
                    Console.WriteLine("~~OR~~");
                    Console.WriteLine(span.Days + " days");
                }

                #region
                //bool x = true;

                //if (intVal1.ToString() == "" && intVal2.ToString() == "")
                //{
                //    Console.WriteLine("Please enter a value.");
                //}
                //else if (intVal1.ToString().Length == 1 && intVal2.ToString().Length == 1)
                //{
                //    x = true;
                //    Console.WriteLine("SUCCESS! But because it's only one number.");
                //}
                //else if (intVal1.ToString().Length == intVal2.ToString().Length)
                //{
                //    Console.WriteLine("Numbers are identical length.");
                //    textnum1 = int.Parse(intVal1.ToString());
                //    textnum2 = int.Parse(intVal2.ToString());
                //    textlen1 = intVal1.ToString().Length;
                //    textlen2 = intVal2.ToString().Length;

                //    int i = 1;
                //    int j = i + 1;
                //    while (j <= textlen1 && x == true)
                //    {
                //        //Console.WriteLine(i);

                //        var num1 = intVal1.ToString();
                //        var num2 = intVal2.ToString();

                //        if (num1[textlen1 - i] + num2[textlen2 - i] == num1[textlen1 - j] + num2[textlen2 - j])
                //        {
                //            x = true;
                //        }
                //        else
                //        {
                //            x = false;
                //        }

                //        i++;
                //        j++;
                //    }

                //    if (x)
                //    {
                //        Console.WriteLine("SUCCESS! The sums of each digit of both numbers are equal.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("FAIL! The sums of each digit are not equal.");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Numbers must be identical length.");
                //}
                #endregion

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
