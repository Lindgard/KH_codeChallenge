namespace codeChallenge;

public class Calculator
{
    /// <summary>
    /// Adds two integers and returns their sum.
    /// </summary>
    /// <param name="a">First addend.</param>
    /// <param name="b">Second addend.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts integer b from integer a and returns the result.
    /// </summary>
    /// <param name="a">The value to subtract from.</param>
    /// <param name="b">The value to subtract.</param>
    /// <returns>The sum of <paramref name="a"/> minus <paramref name="b"/>.</returns>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies integer a by integer b and returns the product.
    /// </summary>
    /// <param name="a">The first factor.</param>
    /// <param name="b">The second factor.</param>
    /// <returns>The product of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Tries to divide one integer by another.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <param name="result">The quotient if the division succeeds; otherwise 0.</param>
    /// <returns>
    /// <c>true</c> if the division succeeded; <c>false</c> if <paramref name="b"/> was zero.
    /// </returns>
    public bool TryDivide(int a, int b, out int result)
    {
        if (b == 0)
        {
            result = 0;
            return false;
        }
        
        result = a / b;
        return true;
    }

    //* Decimal-versions of methods

    /// <summary>
    /// Adds two doubles and returns their sum.
    /// </summary>
    /// <param name="a">First addend.</param>
    /// <param name="b">Second addend.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public double AddDouble(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second double from the first and returns the result.
    /// </summary>
    /// <param name="a">The value to subtract from.</param>
    /// <param name="b">The value to subtract</param>
    /// <returns>The result of <paramref name="a"/> minus <paramref name="b"/>.</returns>
    public double SubtractDouble(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two doubles and returns the product.
    /// </summary>
    /// <param name="a">The first factor.</param>
    /// <param name="b">The second factor.</param>
    /// <returns>The product of <paramref name="a"> and <paramref name="b"/>.</returns>
    public double MultiplyDouble(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Tries to divide one double by another.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <param name="result">The quotient if the division succeeds; otherwise 0.0;</param>
    /// <returns>
    /// <c>true</c> if the division succeeded; <c>false</c> if <paramref name="b"/> was zero.
    /// </returns>
    public bool TryDivideDouble (double a, double b, out double result)
    {
        if (b == 0)
        {
            result = 0.0;
            return false;
        }

        result = a / b;
        return true;
    }
}