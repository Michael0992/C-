using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains;
using System.Drawing;
using TrueColorConsole;


namespace Maze_of_Monolith
{
    internal class IMGgen
    {
        string px1 = ((char)'\u2588').ToString();
        string px2 = ((char)'\u2593').ToString();
        string px3 = ((char)'\u2592').ToString();
        string px4 = ((char)'\u2591').ToString();

        int res_x = 240;
        int res_y = 120;






        internal void MyIMG(string img_name, int resx, int resy)
        {
            res_x = resx;
            res_y = resy;
            MyIMG(img_name);
            res_x = 240;
            res_y = 100;

        }


        internal void MyIMG(string img_name)
        {
            string gdir = AppDomain.CurrentDomain.BaseDirectory;
            gdir = gdir.Remove(gdir.Length - 10, 10);
            gdir = gdir + @"ressource\" + img_name;

            Color color = new Color();

            Bitmap image = new Bitmap(gdir);
            image = new Bitmap(image, new Size(res_x, res_y));
            image.SetResolution(res_x, res_y);

            Random rand = new Random();

            VTConsole.Enable();

            for (int y = 0; y <= res_y - 2; y = y + 2)
            {
                for (int x = 0; x <= res_x - 2; x++)
                {


                    color = image.GetPixel(x, y);

                    Chex(px1, color.R, color.G, color.B);

                }
                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            VTConsole.Disable(); 



        }

        internal void Chex(string text, int r, int g, int b)
        {
            
            VTConsole.Write(text, Color.FromArgb(r, g, b));            
        }
    }
}
