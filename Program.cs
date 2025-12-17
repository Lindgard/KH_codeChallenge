namespace codeChallenge;

class Program
{
    static void Main(string[] args)
    {
        //* Creating an instance of the calculator class
        Calculator calc = new Calculator();

        //* Array of recent calculation history
        string[] recentHistory = new string[5];
        int historyIndex = 0;

        //* List for all results
        List<double> allResults = new List<double>();
        List<string> allCalculations = new List<string>();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the calculator cli!");
        Console.ResetColor();

        while (true)
        {
            //* Ask if user wants decimal calculations (bool)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Use decimal numbers? (y/n): ");
            Console.ResetColor();
            char? choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); //* Add newline after reading char
            bool useDecimals = choice == 'y' || choice == 'Y';

            //* Get first number
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter first number: ");
            Console.ResetColor();
            string? input1 = Console.ReadLine();

            //* Parse first number based on useDecimals flag
            double num1Double = 0;
            int num1Int = 0;
            if (useDecimals)
            {
                if (string.IsNullOrEmpty(input1) || !double.TryParse(input1, out num1Double))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid decimal number!");
                    Console.ResetColor();
                    continue;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(input1) || !int.TryParse(input1, out num1Int))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid number!");
                    Console.ResetColor();
                    continue;
                }
            }

            //* Get operation (char)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter operation (+, -, *, /): ");
            Console.ResetColor();
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); //* Add newline after reading char

            //* Validate char operation (char can't be null, so no IsNullOrEmpty needed)
            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Invalid operation! Please use +, -, *, or /");
                Console.ResetColor();
                continue;
            }

            //* Get second number
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter second number: ");
            Console.ResetColor();
            string? input2 = Console.ReadLine();

            //* Parse second number based on useDecimals flag
            double num2Double = 0;
            int num2Int = 0;
            if (useDecimals)
            {
                if (string.IsNullOrEmpty(input2) || !double.TryParse(input2, out num2Double))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid decimal number!");
                    Console.ResetColor();
                    continue;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(input2) || !int.TryParse(input2, out num2Int))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid number!");
                    Console.ResetColor();
                    continue;
                }
            }

            //* Perform calculation based on useDecimals flag
            if (useDecimals)
            {
                double result = 0;
                if (operation == '+')
                {
                    result = calc.AddDouble(num1Double, num2Double);

                    result = Math.Round(result, 2, MidpointRounding.AwayFromZero); //* Adding a limit to the decimals of the double that result should be.
                }
                else if (operation == '-')
                {
                    result = calc.SubtractDouble(num1Double, num2Double);

                    result = Math.Round(result, 2, MidpointRounding.AwayFromZero);
                }
                else if (operation == '*')
                {
                    result = calc.MultiplyDouble(num1Double, num2Double);

                    result = Math.Round(result, 2, MidpointRounding.AwayFromZero);
                }
                else if (operation == '/')
                {
                    //* Handling of division by zero
                    if (num2Double == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Error: cannot divide by zero!");
                        Console.ResetColor();
                        continue;
                    }
                    result = calc.DivideDouble(num1Double, num2Double);

                    result = Math.Round(result, 2, MidpointRounding.AwayFromZero);
                }

                //* Displaying the result
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ Result: {result}");
                Console.ResetColor();

                //* Storing in array
                string calculationEntry = $"{num1Double} {operation} {num2Double} = {result}";
                recentHistory[historyIndex % 5] = calculationEntry;
                historyIndex++;

                //* Storing in lists
                allResults.Add(result);
                allCalculations.Add(calculationEntry);
            }
            else
            {
                int result = 0;
                if (operation == '+')
                {
                    result = calc.Add(num1Int, num2Int);
                }
                else if (operation == '-')
                {
                    result = calc.Subtract(num1Int, num2Int);
                }
                else if (operation == '*')
                {
                    result = calc.Multiply(num1Int, num2Int);
                }
                else if (operation == '/')
                {
                    //* Handling of division by zero
                    if (num2Int == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Error: cannot divide by zero!");
                        Console.ResetColor();
                        continue;
                    }
                    result = calc.Divide(num1Int, num2Int);
                }

                //* Displaying the result
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✅ Result: {result}");
                Console.ResetColor();

                //* Storing in array
                string calculationEntry = $"{num1Int} {operation} {num2Int} = {result}";
                recentHistory[historyIndex % 5] = calculationEntry;
                historyIndex++;

                //* Storing in lists
                allResults.Add(result);
                allCalculations.Add(calculationEntry);
            }

            Console.Write("Type 'exit' to quit or press Enter to continue: ");
            string? continueChoice = Console.ReadLine();
            if (continueChoice?.ToLower() == "exit")
            {
                break;
            }
            Console.WriteLine();
        }

        //* Displaying the collections
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--- Recent History (Array - last 5) ---");
        Console.ResetColor();
        foreach (string historyItem in recentHistory)
        {
            if (historyItem != null) //* arrays can have null elements
            {
                Console.WriteLine(historyItem);
            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n--- All Results (List - Total: {allResults.Count}) ---");
        Console.ResetColor();
        foreach (double res in allResults)
        {
            Console.WriteLine($"Result: {res}");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--- All Calculations (List) ---");
        Console.ResetColor();
        foreach (string calculation in allCalculations)
        {
            Console.WriteLine(calculation);
        }
    }
}
