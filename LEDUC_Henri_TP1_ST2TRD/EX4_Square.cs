using System;

namespace LEDUC_Henri_TP1_ST2TRD
{
    public class EX4_Square
    {
        public void draw()
        {
            Console.WriteLine("Please enter the height n for your rectangle");
            int.TryParse(Console.ReadLine(), out var n);
            Console.WriteLine("Please enter the width m for your rectangle");
            int.TryParse(Console.ReadLine(), out var m);
            if (n >= 1 && n <= 1000 && m >= 1 && m <= 1000)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((i == 0 && (j == 0 || j == n - 1))
                            || (i == m - 1 && (j == 0 || j == n - 1)))
                        {
                            Console.Write("0");
                        }
                        else if (i == 0 || i == m - 1)
                        {
                            Console.Write("-");
                        }
                        else if (j == 0 || j == n - 1)
                        {
                            Console.Write("|");
                        }
                        else if ((i + j - 2) % 3 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}