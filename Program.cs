namespace calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an operation (+, -, *, /):");
            string operation = Console.ReadLine();

            double result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"Result: {result}");
        }

        static double PerformOperation(double a, double b, string op)
        {
            switch (op)
            {
                case "+":
                    return Add(a, b);
                case "-":
                    return Subtract(a, b);
                case "*":
                    return Multiply(a, b);
                case "/":
                    return Divide(a, b);
                default:
                    Console.WriteLine("Invalid operation");
                    return 0;
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            return a / b;
        }
    }
}
