using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_of_Monolith
{
    internal class GetHelp
    {
        internal GetHelp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ ((char)'\u2666').ToString()}Die Steuerung erfolgt über die Pfeiltasten.{ ((char)'\u2190').ToString()} { ((char)'\u2191').ToString()} { ((char)'\u2192').ToString()} { ((char)'\u2193').ToString()} | Enter | Esc | ");

            Console.WriteLine($"{ ((char)'\u2666').ToString()}Um nach links zu gehen drücke { ((char)'\u2190').ToString()}");

            Console.WriteLine($"{ ((char)'\u2666').ToString()}Um nach rechts zu gehen drücke { ((char)'\u2192').ToString()}");

            Console.WriteLine($"{ ((char)'\u2666').ToString()}Um geradeaus zu laufen drücke { ((char)'\u2191').ToString()}");

            Console.WriteLine($"{ ((char)'\u2666').ToString()}Um umzukehren oder zu fliehen drücke { ((char)'\u2193').ToString()}");

            Console.WriteLine($"{ ((char)'\u2666').ToString()}Um etwas zu bestätigen drücke die Taste | Enter |");

            Console.WriteLine($"{ ((char)'\u2666').ToString()}Ziel des Spiels ist es 100 Punkte zu sammeln. Du verdienst Punkte indem du Monster besiegst.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\n\nBestätige mit ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" | ENTER | ");
            Console.ResetColor();
            Console.WriteLine("um fortzufahren.");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            while (keyInfo.Key != ConsoleKey.Enter)
            {
                keyInfo = Console.ReadKey(true);
            }
            SoundsSet.output1.Stop();
            SoundsSet.Sound("select.wav", 0.02f);
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            new Menu();
        }
    }
}
