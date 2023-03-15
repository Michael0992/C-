using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_of_Monolith
{
    internal class ClearLines
    {
        public static void Clear()
        {
            Console.WriteLine(new string(' ', Console.WindowWidth));
            
        }
        public static void Clear(int nbrLines)
        {

            int numLinesToClear = Console.CursorTop;
            for (int i = 0; i <= nbrLines ; i++)
            {
                Console.CursorTop = numLinesToClear - i;
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
            Console.CursorTop = numLinesToClear-nbrLines;
        }
        public static void All()
        {
            Console.Clear();
        }
    }
}
