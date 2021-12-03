using System;
namespace LEDUC_Henri_TP1_ST2TRD
{
    public class EX1_Multiplication
    {
        int result;
        public void m_table()
        {
            for (var i = 1;i <= 10; i++)
            {
                for (var j = 1;j <= 10; j++)
                {
                    this.result = i * j;
                    Console.WriteLine(i + "*" + j + " = " + this.result + "\t");
                }
            }
        }
        
        public void odd_m_table()
        {
            for (var i = 1;i <= 10; i++)
            {
                for (var j = 1;j <= 10; j++)
                {
                    this.result = i * j;
                    if (this.result%2 == 1)
                    {
                        Console.WriteLine(i + "*" + j + " = " + i*j + "\t");
                    }
                }
            }
        }
        
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public void specific_table()
        {
            var i = AskUserForParameter();
            for (var j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + "*" + j + " = " + i*j + "\t");
            }
        }
    }
}