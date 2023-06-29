

namespace CalculatorApp
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Misol uchun 5 + 7\n");
                string expression = Console.ReadLine();
                Console.WriteLine("Result: " + (double)EvaluateExpression(expression));

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'q' || key.KeyChar == 'Q')
                    break;
            }
        }

        private static double EvaluateExpression(string expression)
        {
            string[] parts = expression.Split(' ');

            double son1, son2;

            son1 = double.Parse(parts[0]);
            son2 = double.Parse(parts[2]);


            char MatematikAmal = parts[1][0];

            switch (MatematikAmal)
            {
                case '+':
                    return CalculatorArithmetic.Add(son1, son2);
                case '-':
                    return CalculatorArithmetic.Subtract(son1, son2);
                case '*':
                    return CalculatorArithmetic.Multiplaction(son1, son2);
                case '/':
                    return CalculatorArithmetic.Divide(son1, son2);
                default:
                    throw new ArgumentException("Invalid operator: ");
            }
        }
    }
}
