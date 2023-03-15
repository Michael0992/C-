using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_of_Monolith
{
    internal class Snake : Enemys
    {
        internal Snake()
        {
            typ = "Schlangenkönig";
            dmgdeal = 20;
            lifepoints = 100;
        }
    }
}
