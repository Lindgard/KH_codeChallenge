namespace codeChallenge;

class Program
{
    static void Main(string[] args)
    {
        //* Creating an instance of the calculator class
        Calculator calc = new Calculator();

        Console.WriteLine("Welcome to the calculator cli!");

        //* Adding interactivity
        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();
        int num1 = int.Parse(input1);
    }
}
