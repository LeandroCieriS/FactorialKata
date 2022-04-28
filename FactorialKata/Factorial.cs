public class Factorial
{
    public static int Calculate(int input)
    {
        if (input >= 2) return input * Calculate(input - 1);
        return 1;
    }
}