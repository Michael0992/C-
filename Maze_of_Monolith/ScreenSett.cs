using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Maze_of_Monolith
{
    internal class ScreenSett
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_MAXIMIZE = 3;

        internal ScreenSett()
        {

            Console.BufferHeight = 50;
            Console.BufferWidth = 240;
            Console.SetWindowSize(Console.BufferWidth, Console.BufferHeight);
            Console.BufferHeight = Console.WindowHeight;
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_MAXIMIZE);







        }
    }
}
