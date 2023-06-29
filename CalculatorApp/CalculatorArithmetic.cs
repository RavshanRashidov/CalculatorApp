namespace CalculatorApp;

public class CalculatorArithmetic
{
    public static double Add(params double[] num)
   => num.Length == 0 ? 0 : num.Sum();
    public static double Subtract(params double[] num)
    {
        var arxivnum = num[0];
        if (num.Length == 0) throw new InvalidCastException("Error!!");
        for (int i = 0; i < num.Length - 1; i++)
        {
            if (i == 0 && num[0] == 0) return 0;
            if (num[i] == 0) throw new DivideByZeroException("Do not input a zero!! ");
            arxivnum -= num[i + 1];
        }
        return arxivnum;
    }
    public static double Divide(params double[] num)
    {
        var arxivnum = num[0];

        if (num.Length == 0) throw new InvalidCastException("Error!!");

        for (int i = 0; i < num.Length - 1; i++)
        {
            if (i == 0 && num[0] == 0) return 0;
            if (num[i] == 0) throw new DivideByZeroException("Do not input a zero!!");
            arxivnum /= num[i + 1];
        }
        return arxivnum;
    }
    public static double Multiplaction(params double[] num)
    {
        var arxivnum = num[0];
        if (num.Length == 0) throw new InvalidCastException("Error!!");
        for (int i = 0; i < num.Length - 1; i++)
        {
            if (i == 0 && num[0] == 0) return 0;
            if (num[i] == 0) throw new DivideByZeroException("Do not input a zero");
            arxivnum *= num[i + 1];
        }
        return arxivnum;
    }
}
