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

        // Largest Prime Factor
        static void Problem3()
        {
            int[] smallPrimes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47,  }; // single digit prime factors
            long number = 600851475143;
            long[] factors = new long[number / 2];
            for (int i = 0; i < factors.Length; i++)
            {
                foreach (int s in smallPrimes)
                {
                    if (number % s == 0 && factors[i-1] != s)
                    {
                        number /= s;
                        factors[i] = s;
                        break;
                    }
                }
            }
        }

        //// Problem 3: Check if prime function
        //static bool CheckPrime(long num)
        //{
        //    if (num == 0 || num == 1 || num == 2)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        long sqrt = (long)Math.Floor(Math.Sqrt(num)); // finds the square root and then rounds it down

        //    }
        //}
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                int product = 7 * i;
                if (product % 20 == 0 && product % 9 == 0 && product % 6 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(product);

            }
        }
    }
}
