using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_of_Monolith
{
    internal class TakeChoice
    {
        internal int Choice(string[] choices)
        {


            Console.OutputEncoding = Encoding.UTF8;
            
            int selected = 0;
            int nrb_choices = 0;

            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
 
            foreach (string i in choices)
            {
                if (i == choices[selected]) Console.WriteLine(((char)'\u2192').ToString() + i);
                else Console.WriteLine(i);
                nrb_choices++;
            }
            

            while (keyInfo.Key != ConsoleKey.Enter){


                keyInfo = Console.ReadKey(true);
                do
                {
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        selected--;
                        if (selected == -1) selected = nrb_choices - 1;
                        else if (selected == nrb_choices) selected = 0;
                        SoundsSet.output1.Stop();
                        SoundsSet.Sound("chose.wav",0.02f);



                    }
                    else if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        selected++;
                        if (selected == -1) selected = nrb_choices - 1;
                        else if (selected == nrb_choices) selected = 0;
                        SoundsSet.output1.Stop();
                        SoundsSet.Sound("chose.wav", 0.02f);

                    }
                    else if (keyInfo.Key == ConsoleKey.Enter) break;
                    else keyInfo = Console.ReadKey(true);

                    
                } while (keyInfo.Key != ConsoleKey.UpArrow && keyInfo.Key != ConsoleKey.DownArrow && keyInfo.Key != ConsoleKey.Enter);

                
                ClearLines.Clear(nrb_choices);
                nrb_choices = 0;
                foreach (string i in choices)
                {

                    if (i == choices[selected]) Console.WriteLine(((char)'\u2192').ToString() + i);
                    else Console.WriteLine(i);

                    nrb_choices++;
                }
                
            }
            SoundsSet.output1.Stop();
            SoundsSet.Sound("select.wav", 0.02f);

            return selected;
            
        }

    }
}
