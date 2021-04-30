using System;

namespace task02
{
    internal static class Program
    {
        private delegate double Add(double x, double y);

        private delegate double Sub(double x, double y);

        private delegate double Mul(double x, double y);

        private delegate double Div(double x, double y);

        private static void Main()
        {
            var x = 1.4;
            var y = 2.5;
            Console.WriteLine("Operation:");
            var operation = Console.ReadLine();
            switch (operation)
            {
                case "Add":
                    Add add = (a, b) => a + b;
                    Console.WriteLine($"{operation} result={add(x, y)}");
                    break;
                case "Sub":
                    Sub sub = (a, b) => a - b;
                    Console.WriteLine($"{operation} result={sub(x, y)}");
                    break;
                case "Mul":
                    Mul mul = (a, b) => a * b;
                    Console.WriteLine($"{operation} result={mul(x, y)}");
                    break;
                case "Div":
                    Div div = delegate (double a, double b) {
                        if (b != 0) return a / b;
                        Console.WriteLine("Division by 0"); return b;
                    };
                    Console.WriteLine($"{operation} result={div(x, y)}");
                    break;
                default:
                    Console.WriteLine($"Unsupported operation {operation}");
                    break;
            }
        }
    }
}
