namespace codeChallenge;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    //* Decimal-versions of methods
    public double AddDouble(double a, double b)
    {
        return a + b;
    }

    public double SubtractDouble(double a, double b)
    {
        return a - b;
    }

    public double MultiplyDouble(double a, double b)
    {
        return a * b;
    }

    public double DivideDouble(double a, double b)
    {
        return a / b;
    }
}