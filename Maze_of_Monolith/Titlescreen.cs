using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Maze_of_Monolith
{
    internal class Titlescreen
    {

        internal Titlescreen()
        {
            IMGgen img = new IMGgen();


            img.MyIMG("titlescreen2.png");
            string message = "Drücke | ENTER |";
            int left = (Console.WindowWidth - message.Length) / 2;
            int top = Console.CursorTop;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(message);
            

            
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();


            while (keyInfo.Key != ConsoleKey.Enter)
            {
                keyInfo = Console.ReadKey(true);


            }
            SoundsSet.output1.Stop();
            SoundsSet.Sound("select.wav", 0.02f);
            Console.Clear();

        }
    }
}
