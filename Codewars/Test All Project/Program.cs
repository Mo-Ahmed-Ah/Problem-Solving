using _01_Simple_Multiplication;
using _02_Century_From_Year;
using _03_Is_N_Divisible_By_X_And_Y;
using _04_Even_or_Odd;
using _05_Reversed_Strings;
using _07_Price_of_Mangoes;
using _08_Cat_years__Dog_years;
using _09_Invert_Values;
using _10_Remove_exclamation_marks;
using _11_Find_Maximum_and_Minimum_Values_of_a_List;
using _12_Multiply;
using _13_Keep_Hydrated;
using _14_Beginner_Reduce_but_Grow;


namespace Test_All_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region You can used this region to test all projects
            while (true)
            {
                #region Menu
                Console.Clear();
                Console.WriteLine("01 : Simple Multiplication.");
                Console.WriteLine("02 : Is N Divisible By X And Y.");
                Console.WriteLine("03 : Century From Year.");
                Console.WriteLine("04 : Even Or Odd.");
                Console.WriteLine("05 : Reversed Strings.");
                Console.WriteLine("06 : Convert a boolean to a string");
                Console.WriteLine("07 : Price Of Mangoes.");
                Console.WriteLine("08 : Cat years, Dog years.");
                Console.WriteLine("09 : Arrays Inversion.");
                Console.WriteLine("10 : Remove exclamation marks.");
                Console.WriteLine("11 : Find Maximum and Minimum Values of a List.");
                Console.WriteLine("12 : Multiply.");
                Console.WriteLine("13 : Calculate what do you want to drink Litres of water");
                Console.WriteLine("14 : Calculate multiplication of array items");
                Console.Write("Enter project number (01-14) or 'exit' to quit: ");
                #endregion

                #region Input and Validation 
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
                int.TryParse(input, out var intputNumber);
                #endregion
                
                #region Switch Case
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
                    case 08:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter the human years to convert to cat and dog years: ");
                            if (int.TryParse(Console.ReadLine(), out var humanYears))
                            {
                                var result = CatYearsDogYears.humanYearsCatYearsDogYears(humanYears);
                                Console.WriteLine($"Human Years: {result[0]}, Cat Years: {result[1]}, Dog Years: {result[2]}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer for human years.");
                            }
                        }
                        break;
                    case 09:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter integers separated by spaces to invert their values: ");
                            var inputArray = Console.ReadLine().Split(' ');
                            try
                            {
                                int[] numbers = Array.ConvertAll(inputArray, int.Parse);
                                var invertedArray = InvertValues.ArraysInversion(numbers);
                                Console.WriteLine("Inverted values: " + string.Join(", ", invertedArray));
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Please enter valid integers separated by spaces.");
                            }
                        }
                        break;
                    case 10:
                        while (true)
                            { 
                            Console.Clear();
                                Console.Write("Enter the String : ");
                                string str = Console.ReadLine();
                                if (str is not null)
                                {
                                    Console.WriteLine($"The {str} after removing exclamation marks is: {RemoveExclamationMarks.RemoveExclamationMark(str)}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                            }
                        }
                        break;
                    case 11:

                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter integers separated by spaces to find the maximum and minimum values: ");
                            var inputArray = Console.ReadLine().Split(' ');
                            try
                            {
                                int[] numbers = Array.ConvertAll(inputArray, int.Parse);
                                Console.WriteLine($"Minimum value: {FindMaximumAndMinimumValuesOfAList.Min((int[])numbers.Clone())}, Maximum value: {FindMaximumAndMinimumValuesOfAList.Max((int[])numbers.Clone())}");
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Please enter valid integers separated by spaces.");
                            }
                        }
                        break;
                    case 12:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter two numbers separated by space to multiply: ");
                            var inputs = Console.ReadLine().Split(' ');
                            if (inputs.Length == 2 &&
                                int.TryParse(inputs[0], out var a) &&
                                int.TryParse(inputs[1], out var b))
                            {
                                Console.WriteLine($"Result: {Multiply.multiply(a, b)}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter two valid numbers.");
                            }
                        }
                        break;
                    case 13:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter the time in hours you spend on exercise per day: ");
                            if (double.TryParse(Console.ReadLine(), out var time))
                            {
                                Console.WriteLine($"You need to drink {KeepHydrated.Litres(time)} litres of water.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number for time.");
                            }
                        }
                        break;
                    case 14:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Enter integers separated by spaces to calculate the multiplication of all items: ");
                            var inputArray = Console.ReadLine().Split(' ');
                            try
                            {
                                int[] numbers = Array.ConvertAll(inputArray, int.Parse);
                                Console.WriteLine($"The multiplication of all items is: {BeginnerReducebutGrow.Grow(numbers)}");
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Please enter valid integers separated by spaces.");
                            }
                        }
                        break;
                    default: break;
                }
                #endregion

                #region Repeat or Exit
                Console.Write("Enter Yes if you want used agaen : ");
                if (Console.ReadLine().ToLower() != "yes")
                    return;
                #endregion
            }
            #endregion
        }
    }
        
}
