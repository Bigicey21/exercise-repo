using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

        

   
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    if ((currentRow == 0 || currentRow == rows - 1) && (currentCol == 0 || currentCol == cols - 1))
                    {
                        Console.WriteLine("+ ");
                    }
                    else if ((currentRow == 0 || currentRow == rows - 1 ))
                    {
                        Console.WriteLine("| ");
                    }

                    else if (currentRow > 0 && currentRow < rows - 1)
                    {
                        Console.WriteLine("- ");
                    }
                    Console.WriteLine();
                }
            }
          

        }
    }
}
