using System.Threading;
namespace ProjectEuler
{
    internal class Program
    {
        // Multiples of 3 or 5
        static void Problem1()
        {
            int limit = 1000;
            int sum = 0;
            for (int i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }

        // Even Fibonacci Numbers
        static void Problem2()
        {
            long sum = 0;
            long limit = 32;
            long[] sequence = new long[limit]; // 4 million
            sequence[0] = 1;
            sequence[1] = 2;
            for (long i = 2; i < limit; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
                Console.WriteLine($"{i+1}: {sequence[i]}");
                Thread.Sleep(500);
                if (sequence[i] % 2 == 0)
                {
                    sum += (long)sequence[i];
                }
            }
            Console.WriteLine(sum + 2); // + 2 because the second term is defined outside the for loop
        }
        static void Main(string[] args)
        {
            Problem2();
        }
    }
}
