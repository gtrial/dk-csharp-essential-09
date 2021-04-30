using System;

namespace task03
{
    internal class Program
    {
        public delegate double MyDelegate(Delegate[] delegates);
        public delegate int Delegate();

        private static void Main()
        {
            Random random = new Random();
            Delegate[] delegates = new Delegate[] {
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
                double result = 0;
                for (int i = 0; i < delegates.Length; i++)
                {
                    result += delegates[i]();
                }
                if (delegates.Length > 0)
                {
                    return (double)result / delegates.Length;
                }
                else
                {
                    return 0;
                }
            }; ;
            Console.WriteLine($"{myDelegate(delegates)}");
        }
    }
}

