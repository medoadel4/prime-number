using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read n1 and n2 from the user
            Console.Write("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());

            
            for (int i = n1; i <= n2; i++)
            {
                
                if (IsPrime(i))
                {
                    
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPrime(int number)
        {
            
            if (number <= 1) return false;
            if (number == 2) return true;

            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

