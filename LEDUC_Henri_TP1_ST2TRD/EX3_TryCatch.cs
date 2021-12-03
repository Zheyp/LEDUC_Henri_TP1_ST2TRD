using System;

namespace LEDUC_Henri_TP1_ST2TRD
{
    public class EX3_TryCatch
    {
        private static int PowerFunction(int x)
        {
            return (int)(10 / ((int)Math.Pow(x, 2) - 4));
        }

        public void RunFct()
        {
            for (int i = -3; i < 4; i++)
            {
                try
                {
                    Console.WriteLine("f(" + i + ") = " + PowerFunction(i));
                }catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.GetType() + " Division by zero is impossible");
                }
            }
        }
    }
}