namespace codeChallenge;

class Program
{
    static void Main(string[] args)
    {
        //* Creating an instance of the calculator class
        Calculator calc = new Calculator();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the calculator cli!");
        Console.ResetColor();

        //* Adding interactivity
        Console.ForegroundColor =  ConsoleColor.Yellow;
        Console.Write("Enter first number: ");
        Console.ResetColor();
        string? input1 = Console.ReadLine();
        if (string.IsNullOrEmpty(input1) || !int.TryParse(input1, out int num1))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ No input received!");
            Console.ResetColor();
            return;
        }

        //* Get operation
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter operation (+, -, *, /): ");
        Console.ResetColor();
        string? operation = Console.ReadLine();
        if (string.IsNullOrEmpty(operation) || (operation != "+" && operation != "-" && operation != "*" && operation != "/"))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid operation! Please use +, -, *, or /");
            Console.ResetColor();
            return;
        }

        //* Get Second number from input
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter second number: ");
        Console.ResetColor();
        string? input2 = Console.ReadLine();
        if (string.IsNullOrEmpty(input2) || !int.TryParse(input2, out int num2))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid number! Please enter a valid integer.");
            Console.ResetColor();
            return;
        }
        

        int result = 0;
        if (operation == "+")
        {
            result = calc.Add(num1, num2);
        } 
        else if (operation == "-")
        {
            result = calc.Subtract(num1, num2);
        } 
        else if (operation == "*")
        {
            result = calc.Multiply(num1, num2);
        }
        else if (operation == "/")
        {
            //* Handling of division by zero
            if (num2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Error: cannot divide by zero!");
                Console.ResetColor();
                return;
            }
            result = calc.Divide(num1, num2);
        }

        //* Displaying the result
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"✅ Result: {result}");
        Console.ResetColor();
    }
}
