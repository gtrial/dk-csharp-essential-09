using System;
using System.Linq;

namespace task03
{
    internal static class Program
    {
        private delegate double MyDelegate(Delegate[] delegates);

        private delegate int Delegate();

        private static void Main()
        {
            var random = new Random();
            var delegates = new Delegate[] {
                delegate {
                    var result = random.Next(1, 10);
                    Console.WriteLine($"{result}");
                    return result; },
                delegate {
                    var result = random.Next(1, 10);
                    Console.WriteLine($"{result}");
                    return result;
                } };
            MyDelegate myDelegate = delegate
            {
                var result = delegates.Aggregate<Delegate, double>(0, (current, t) => current + t());
                if (delegates.Length > 0)
                {
                    return result / delegates.Length;
                }

                return 0;
            };
            Console.WriteLine($"{myDelegate(delegates)}");
        }
    }
}

