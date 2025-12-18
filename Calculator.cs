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
    /// Throws if the divisor is zero(int).
    /// </summary>
    /// <param name="b"></param>
    /// <exception cref="DivideByZeroException"></exception>
    private static void EnsureNonZeroDivisor(int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisor 'b' must not be zero.");
        }
    }

    /// <summary>
    /// Throws if the divisor is zero(double).
    /// </summary>
    /// <param name="b"></param>
    /// <exception cref="DivideByZeroException"></exception>
    private static void EnsureNonZeroDivisor(double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisor 'b' must not be zero.");
        }
    }

    /// <summary>
    /// Divides one integer by another and returns the quotient.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The result of dividing <paramref name="a"/> by <paramref name="b"/>.</returns>
    /// <exception cref="DivideByZeroException">
    /// Thrown when <paramref name="b"/> is zero.
    /// </exception>
    public int Divide(int a, int b)
    {
        EnsureNonZeroDivisor(b);
        return a / b;
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
    /// Divides one double by another and returns the quotient.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The result of dividing <paramref name="a"/> by <paramref name="b"/>.</returns>
    /// <exception cref="DivideByZeroException">
    /// Thrown when <paramref name="b"/> is zero.
    /// </exception>
    public double DivideDouble(double a, double b)
    {
        EnsureNonZeroDivisor(b);
        return a / b;
    }
}