using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Maze_of_Monolith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundsSet.Music("xDeviruchi_Title_Theme.wav",0.02f);
            new ScreenSett();
            new Titlescreen(); 
            new GetHelp(); 

            //Kommentar
            


            




        }
    }
}
