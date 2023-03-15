using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NAudio.Wave;

namespace Maze_of_Monolith
{
    internal class SoundsSet
    {

        public static WaveOutEvent output1 = new WaveOutEvent();
        public static WaveOutEvent output = new WaveOutEvent();
        
        internal SoundsSet()
        {
            output1.Volume = output.Volume;
        }




        internal static void Music(string media, float volume)
        {
            string gdir = AppDomain.CurrentDomain.BaseDirectory;
            gdir = gdir.Remove(gdir.Length - 10, 10);
            gdir = gdir + @"ressource\" + media;
            
            AudioFileReader player= new AudioFileReader(gdir);
            WaveOutEvent outputgen = new WaveOutEvent();

            Thread musicThread = new Thread(() =>
            {
                

                output.Init(player);
                if (Options.volume != volume) output.Volume = output.Volume;
                else output.Volume = volume;
                output.Play();
                
            });
            musicThread.Start();
            

        }
        internal static void Sound(string media, float volume)
        {
            string gdir = AppDomain.CurrentDomain.BaseDirectory;
            gdir = gdir.Remove(gdir.Length - 10, 10);
            gdir = gdir + @"ressource\" + media;

            AudioFileReader player = new AudioFileReader(gdir);
            

            Thread soundThread = new Thread(() =>
            {
                output1.Init(player);
                if (Options.volume != volume) output1.Volume = output.Volume;
                else output1.Volume = volume;
                output1.Play();

            });
            soundThread.Start();
        }

        
    }
}
