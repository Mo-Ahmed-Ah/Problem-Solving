

using _01_Simple_Multiplication;
using _02_Century_From_Year;
using _03_Is_N_Divisible_By_X_And_Y;
using _04_Even_or_Odd;
using _05_Reversed_Strings;
using _07_Price_of_Mangoes;
using System.ComponentModel;

namespace Test_All_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple Multiplication
            //Console.WriteLine(SimpleMultiplication.Multiply(5));
            #endregion

            #region Is N Divisible By X And Y
            //Console.WriteLine(IsNDivisibleByXAndY.IsDivisible(3, 1, 3));
            #endregion

            #region Century From Year
            //Console.WriteLine(CenturyFromYear.СenturyFromYear(1705));
            //Console.WriteLine(CenturyFromYear.СenturyFromYear(1900));
            //Console.WriteLine(CenturyFromYear.СenturyFromYear(1601));
            //Console.WriteLine(CenturyFromYear.СenturyFromYear(2000));
            //Console.WriteLine(CenturyFromYear.СenturyFromYear(2742));
            #endregion

            #region Even or Odd
            //Console.WriteLine(EvenOrOdd.EvenOrOddNumber(3));
            //Console.WriteLine(EvenOrOdd.EvenOrOddNumber(2));
            #endregion

            #region You can used this region to test all projects
            while (true)
            {
                Console.Clear();
                Console.WriteLine("01 : Simple Multiplication.");
                Console.WriteLine("02 : Is N Divisible By X And Y.");
                Console.WriteLine("03 : Century From Year.");
                Console.WriteLine("04 : Even Or Odd.");
                Console.WriteLine("05 : Reversed Strings.");
                Console.WriteLine("06 : Convert a boolean to a string");
                Console.WriteLine("07 : Price Of Mangoes.");
                Console.Write("Enter project number (01-04) or 'exit' to quit: ");
                string input = Console.ReadLine();
                int.TryParse(input, out var intputNumber);

                switch (intputNumber)
                {
                    case 01:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter a number to multiply by 8 if even or by 9 if odd:");
                            if (int.TryParse(Console.ReadLine(), out var numberToMultiply))
                            {
                                Console.WriteLine($"Result: {SimpleMultiplication.Multiply(numberToMultiply)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            }
                        }
                        break;
                    case 02:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter three integers (N, X, Y) separated by spaces to check if N is divisible by both X and Y:");
                            var inputs = Console.ReadLine().Split(' ');
                            if (inputs.Length == 3 &&
                                int.TryParse(inputs[0], out var n) &&
                                int.TryParse(inputs[1], out var x) &&
                                int.TryParse(inputs[2], out var y))
                            {
                                Console.WriteLine($"Is {n} divisible by {x} and {y}? {IsNDivisibleByXAndY.IsDivisible(n, x, y)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter three valid integers.");
                            }
                        }
                        break;
                    case 03:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter a year to find out its century:");
                            if (int.TryParse(Console.ReadLine(), out var year))
                            {
                                Console.WriteLine($"The century for the year {year} is: {CenturyFromYear.СenturyFromYear(year)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid year.");
                            }
                        }
                        break;
                    case 04:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter a number to check if it's even or odd:");
                            if (int.TryParse(Console.ReadLine(), out var numberToCheck))
                            {
                                Console.WriteLine($"The number {numberToCheck} is: {EvenOrOdd.EvenOrOddNumber(numberToCheck)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            }
                        }
                        break;
                    case 05:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter the String : ");
                            string str = Console.ReadLine();
                            if (str is not null)
                            {
                                Console.WriteLine($"The {str} after revers is: {ReversedStrings.Solution(str)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            }
                        }
                        break;
                    case 06:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter the boolean value (true/false): ");
                            string boolInput = Console.ReadLine().ToLower();
                            if (boolInput.ToLower() == "true" || boolInput.ToLower() == "false")
                            {
                                bool boolValue = boolInput == "true";
                                Console.WriteLine($"The string representation of {boolValue} is: {boolValue.ToString()}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
                            }
                        }
                        break;
                    case 07:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter the quantity of mangoes: ");
                            bool isQuantityValid = int.TryParse(Console.ReadLine(), out var quantity);
                            Console.Write("Enter the price per mango: ");
                            bool isPriceValid = int.TryParse(Console.ReadLine(), out var price);
                            if (isQuantityValid && isPriceValid)
                            {
                                Console.WriteLine($"The total price for {quantity} mangoes at {price} each is: {PriceOfMangoes.Mango(quantity, price)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter valid integers for quantity and price.");
                            }
                        }
                        break;
                    default: break;
                }

                Console.Write("Enter Yes if you want used agaen : ");
                if (Console.ReadLine().ToLower() != "yes")
                    return;
            }
            #endregion
        }
    }
        
}
