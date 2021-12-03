using System; 
namespace LEDUC_Henri_TP1_ST2TRD
{
    public class EX5_ChristmasTree
    {
        public void draw()
        {
            Console.WriteLine("Please enter the height for your tree");
            int.TryParse(Console.ReadLine(), out var n);
            while(n < 3 || n > 20)
            {
                Console.WriteLine("Please enter the height for your tree (size 3-20):");
                int.TryParse(Console.ReadLine(), out var n1);
                n = n1;
            }
            for (int j = 0; j <= n; j++) //Going through lines
            {
                for (int i = 0; i < (n*2)-1; i++) //going through Columns
                {
                    if (j == n && (i == n - 2  || i == n)) // trunk on the last row
                    {
                        Console.Write("|");
                    }
                    else if ((j < n) && ((i == n - 1) || (i >= n-1-j && i <= n-1+j))) //Verifying that we are not on last row and add elem.
                    {
                        
                        if ((j > 0) && (i + j + (j%3)) % 3 == 0) //Reuse pattern from ex4
                        {
                            Random rand = new Random(); // Choosing randomly if we will have a "o" or a "i"
                            int nb = rand.Next(0, 100);
                            if ((nb -= 33) < 0)
                            {
                                Console.Write("o");
                            }
                            else
                            {
                                Console.Write("i");
                            }
                        }
                        else
                        {
                            Console.Write("*");   
                        }
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