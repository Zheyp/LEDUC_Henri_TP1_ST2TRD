using System;
namespace LEDUC_Henri_TP1_ST2TRD
{
    public class EX2_Math
    {
        public void Prime()
        {
            for (int i = 3; i < 1000; i += 2)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
            
        }

        public void AskFibonacci()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var lenght);
            Console.WriteLine("First " + lenght + " element of Fibonacci suite :");
            for (int i = 0; i < lenght; i++)
            {  
                Console.Write("{0} ", Fibonacci(i));  
            }

            Console.Write("\n");
        }

        public void Factorial()
        {
            int result = 1;
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var number);
            Console.WriteLine(number + "! :");
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            } 
            Console.WriteLine(result);
        }
    }
}