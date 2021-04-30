using System;

namespace task02
{
    internal class Program
    {
        public delegate double Add(double x, double y);
        public delegate double Sub(double x, double y);
        public delegate double Mul(double x, double y);
        public delegate double Div(double x, double y);

        private static void Main()
        {
            double x = 1.4;
            double y = 2.5;
            Console.WriteLine("Operation:");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "Add":
                    Add add = delegate (double x, double y) { return x + y; };
                    Console.WriteLine($"{operation} result={add(x, y)}");
                    break;
                case "Sub":
                    Sub sub = delegate (double x, double y) { return x - y; };
                    Console.WriteLine($"{operation} result={sub(x, y)}");
                    break;
                case "Mul":
                    Mul mul = delegate (double x, double y) { return x * y; };
                    Console.WriteLine($"{operation} result={mul(x, y)}");
                    break;
                case "Div":
                    Div div = delegate (double x, double y) { if (y == 0) { Console.WriteLine("Division by 0"); return y; } return x / y; };
                    Console.WriteLine($"{operation} result={div(x, y)}");
                    break;
                default:
                    Console.WriteLine($"Unsupported operation {operation}");
                    break;
            }
        }
    }
}
