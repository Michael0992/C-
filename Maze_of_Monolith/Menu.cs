using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_of_Monolith
{
    internal class Menu
    {
        public Menu()
        {


            
            string message = "  MENÜ  ";
            int left = (Console.WindowWidth - message.Length) / 2;
            int top = Console.CursorTop;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(message);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ResetColor();

            string[] options = { "SPIEL STARTEN", "OPTIONEN","HILFE", "VERLASSEN" };
            TakeChoice choice = new TakeChoice();
            IMGgen img = new IMGgen();

            img.MyIMG("main.bmp", 240 , 60);


            int getchoice = choice.Choice(options);

            if (getchoice == 0)
            {
                new Game();
            }
            else if(getchoice == 1)
            {
                new Options();
            }
            else if (getchoice == 2)
            {
                new GetHelp();
            }
            else if (getchoice == 3)
            {
                Environment.Exit(0);
            }
            
            Console.ReadKey();








            



        }

    }
}
