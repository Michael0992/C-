using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Maze_of_Monolith
{
    internal class Options //: SoundsSet
    {

        public static float volume = 0.02f;
        
        
        internal Options()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            string message = "  OPTIONEN  ";
            int left = (Console.WindowWidth - message.Length) / 2;
            int top = Console.CursorTop;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(message);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ResetColor();
            IMGgen img = new IMGgen();
            img.MyIMG("options.bmp", 240, 60);

            string soundminmax = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";

           
            Console.WriteLine($"\nLautstärke einstellen: { ((char)'\u266B').ToString()} min {soundminmax} max\n\n" );           
            Console.BackgroundColor= ConsoleColor.Green;
            Console.Write("\t\u2190\t");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("\t\u2192\t");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("\t| Esc |  zum Verlassen. \t ");
            Console.ResetColor();

            SoundAnitmation(SetVolume(false), soundminmax);
            SoundAnitmation(SetVolume(true), soundminmax);

            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.LeftArrow) 
                {
                    SoundsSet.output1.Stop();
                    SoundsSet.Sound("chose.wav", 0.02f);
                    SoundAnitmation(SetVolume(false), soundminmax);
                    

                }
                else if(keyInfo.Key == ConsoleKey.RightArrow)
                {
                    SoundsSet.output1.Stop();
                    SoundsSet.Sound("chose.wav", 0.02f);
                    SoundAnitmation(SetVolume(true), soundminmax);
                    
                }
                
            }
            
            Console.Clear();
            SoundsSet.output1.Stop();
            SoundsSet.Sound("select.wav", 0.02f);
            new Menu();

        }

        internal int SetVolume(bool add_sub)
        {
            float vol = SoundsSet.output.Volume;
            if (add_sub == true)
            {
                vol = vol + 0.01f;
                if (vol > 1f) vol = 1f; 
                
            }
            else if(add_sub == false)
            {
                vol = vol - 0.01f;
                if (vol < 0f) vol = 0f;

            }

            
            SoundsSet.output.Volume = vol;
            volume = vol;



            return Convert.ToInt32(vol*100);
        }

        internal void SoundAnitmation(int vol,string visualvol)
        {
            
            Console.SetCursorPosition(0 , Console.BufferHeight - 31);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.BufferHeight - 32);          
            Console.Write($"\nLautstärke einstellen: { ((char)'\u266B').ToString()} min ");
            for(int i = 0; i < visualvol.Length; i++)
            {
                if (i < vol)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("|");
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                }
                
                
            }
            Console.ResetColor();
            Console.Write(" max \t" + vol + " %" );
        }
    }
}
