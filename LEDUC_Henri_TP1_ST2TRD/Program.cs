using System;
namespace LEDUC_Henri_TP1_ST2TRD
{
    public class Program
    {
        public static void Main()
        {
            var choice = 1;
            do
            {
                Console.WriteLine("Enter 1-5 for the Exercise, 0 to exit program.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EX1();
                        break;
                    case 2:
                        EX2();
                        break;
                    default:
                        break;
                    case 3:
                        var Ex3 = new EX3_TryCatch();
                        Ex3.RunFct();
                        break;
                    case 4:
                        var Ex4 = new EX4_Square();
                        Ex4.draw();
                        break;
                    case 5:
                        var Ex5 = new EX5_ChristmasTree();
                        Ex5.draw();
                        break;
                }
            } while (choice != 0);
        }
        
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        private static void EX1()
        {
            Console.WriteLine("Enter 1-3 for the Exercise Part");
            var Ex1 = new EX1_Multiplication();
            var pick = Convert.ToInt32(Console.ReadLine());
            switch (pick)
            {
                case 1:
                    Ex1.m_table();
                    break;
                case 2:
                    Ex1.odd_m_table();
                    break;
                case 3:
                    Ex1.specific_table();
                    break;
            }
    
        }

        private static void EX2()
        {
            Console.WriteLine("Enter 1-3 for the Exercise Part");
            var Ex2 = new EX2_Math();
            var pick = Convert.ToInt32(Console.ReadLine());
            switch (pick)
            {
                case 1:
                    Ex2.Prime();
                    break;
                case 2:
                    Ex2.AskFibonacci();
                    break;
                case 3:
                    Ex2.Factorial();
                    break;
            } 
        }
    }
}