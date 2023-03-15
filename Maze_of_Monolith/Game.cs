using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_of_Monolith
{
    internal class Game
    {
        internal Game()
        {
            Console.Clear();
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Mysterious_Dungeon.wav", 0.02f);
            new IMGgen().MyIMG("intro.png",240,100);
            Console.WriteLine("\nDu spürst den Wind in deinem Gesicht, als du in dem kleinen Flugzeug über den dichten Dschungel fliegst. Plötzlich hörst du ein lautes Knacken  und das Flugzeug gerät ins");
            Console.WriteLine("Schlingern.Du spürst, wie sich dein Magen zusammenzieht, als du merkst, dass du abstürzt. Es geht alles sehr schnell. Du spürst den Aufprall und dann ist alles schwarz um");
            Console.WriteLine("dich herum. Als du wieder zu Bewusstsein kommst, bist du benommen und verwirrt. Du kletterst aus dem Wrack des Flugzeugs und stehst mitten im dichten  Dschungel. Der Lärm");
            Console.WriteLine("der Absturzstelle liegt noch in der Luft und du spürst, wie sich dein Herzschlag  beruhigt. Du weißt, dass du Du weißt, dass du schnell handeln  musst, um Hilfe zu finden.\n");

            Console.WriteLine("Als du dich umsiehst, entdeckst du etwas in der Ferne. Es ist die Spitze einer Pyramide, die aus den Baumwipfeln ragt. Du beschließt, dorthin zu gehen, in der Hoffnung, von");   
            Console.WriteLine("oben einen besseren Ausblick zu haben und einen Weg aus dem Dschungel zu finden.  Es  ist  ein  beschwerlicher Weg  durch  das Dickicht, aber du gibst  nicht  auf. Endlich");
            Console.WriteLine("erreichst du die Pyramide und kletterst die steilen Stufen hoch. Doch dann bricht plötzlich der Boden der Pyramide unter dir zusammen und du stürzt in die Tiefe. Du spürst");
            Console.WriteLine("einen heftigen Aufprall und du verlierst das Bewustsein.");

            Key_Enter();

            //Aus Zeimangel konnte ich die Map nicht implementieren, daher werde ich den Zuffalsgenerator integrieren
            string[] transition = {"Du kletterst einen Schacht herab.", "Du überquerst eine Steinbrücke, unter dir die unendliche Leere ...","Du steigst eine Steintreppe herunter.",  "Du gehst einen modrig riechenden Gang entlang.","Du Steigst eine alte Treppe hoch", "Du gehst einen Fackel beleuchteten Gang entlang."};
            string[] rooms = { "Du betritts ein riesiges Gewölbe. Vor dir steht ein Kobold!", "Du gelangst in eine große Halle. Vor dir steht eine Mumie!", "Du kommst in einen großen Raum. Vor dir befindet sich eine riesige Spinne!", "Du betritts ein riesiges Gewölbe vor dir befindet sich der König der schlangen!", "Du stehst in einem Kerker. Hier ist es furchtbar heiss. Aber was ist das!!! Ein Riesiger Drache!!!" };
            string[] rooms_items = { "du betritts eine kleine Kammer mit einem Podest in der mitte. Aber sonst nichts... du gehst weiter.", "Du kommst in einem Raum in der mitte befindet sich etwas... Ein Heiltrank!", "Du kletterst duch einen Schacht und gelangst in eine Kammer, die hell erleuchtet ist. Du findest eine Fakel! Diese ist bestimmt nützlich", "Du stehst in einem Gang vor dir geht es Weiter, Aber Links ist eine Tür was tust du?", "Du stehst in einem Korridor es geht hier weiter aber zu deiner Rechten ist eine Tür... Was tust du?"};
            


            //

            new IMGgen().MyIMG("room1.png",240,100);
            Console.WriteLine("\nDu wachst auf und befindest dich in einer dunklen Gruft. Durch das Loch in der Decke siehst du Tageslicht, doch es ist unereichbar. Es muss einen weiteren weg hier raus geben. ");

            Key_Enter();






            Random rand = new Random();
            while (Character.points < 100)
            {
                int i = rand.Next(0,100);
                if(i < 50)
                {
                    int j = rand.Next(0,transition.Length);
                    if (j == 0) new IMGgen().MyIMG("room5v2.png", 240, 100);
                    else if (j == 1) new IMGgen().MyIMG("bridge.png", 240, 100);
                    else if (j == 2) new IMGgen().MyIMG("room5v2.png", 240, 100);
                    else if (j == 3) new IMGgen().MyIMG("essay_Gang.png", 240, 100);
                    else if (j == 4) new IMGgen().MyIMG("room5.png", 240, 100);
                    else if (j == 5) new IMGgen().MyIMG("room17.png", 240, 100);
                    Console.WriteLine(transition[j]);
                    Key_Enter();
                }
                else if (i > 80)
                {
                    int j = rand.Next(0, rooms.Length);
                    if (j == 0)
                    {
                        new IMGgen().MyIMG("room7.png", 240, 100);
                        Console.WriteLine(rooms[j]);
                        new Battleystem().Goblin();
                        if (Character.lifepoints <= 0) break;
                        Room_choice(1);
                    }
                    else if (j == 1) {
                        new IMGgen().MyIMG("room11.png", 240, 100);
                        Console.WriteLine(rooms[j]);
                        new Battleystem().Zombie_();
                        if (Character.lifepoints <= 0) break;
                        Room_choice(2);
                    }
                    else if(j == 2)
                    {
                        new IMGgen().MyIMG("Spider.png", 240, 100);
                        Console.WriteLine(rooms[j]);
                        new Battleystem().Spider();
                        if (Character.lifepoints <= 0) break;
                        Key_Enter();
                    }
                    else if (j == 3)
                    {
                        new IMGgen().MyIMG("Snake.png", 240, 100);
                        Console.WriteLine(rooms[j]);
                        new Battleystem().Snake();
                        if (Character.lifepoints <= 0) break;
                        Key_Enter();
                    }
                    else if (j == 4)
                    {
                        new IMGgen().MyIMG("Dragon.png", 240, 100);
                        Console.WriteLine(rooms[j]);
                        new Battleystem().Dragon();
                        if (Character.lifepoints <= 0) break;
                        Key_Enter();
                    }

                    
                    

                }
                else if(i >= 50 && i <= 80)
                {
                    int j = rand.Next(0, rooms_items.Length);
                    if (j == 0)
                    {
                        new IMGgen().MyIMG("room3v2.png", 240, 100);
                        Console.WriteLine(rooms_items[j]);
                        Key_Enter();
                    }
                    else if (j == 1)
                    {
                        new IMGgen().MyIMG("room3.png", 240, 100);
                        Console.WriteLine(rooms_items[j]);
                        
                        if (Character.lifepoints < 100)
                        {
                            Character.lifepoints = 100;
                            Console.WriteLine("Der Trank heilt deine Verletzungen. Du hast wieder 100 Lebenspunkte");
                           

                        }
                        else
                        {
                            Console.WriteLine("Dir geht es soweit gut. du brauchst den Trank nicht und hast auch kein Platz im Rucksack um ihn mitzunehmen... Also gehst du weiter...");
                                                    
                        }
                        Key_Enter();
                    }
                    else if (j == 2)
                    {
                        new IMGgen().MyIMG("room6.png", 240, 100);
                        Console.WriteLine(rooms_items[j]);
                        Console.WriteLine("Diese Fakel wird dir bestimmt helfen deine Angriffe zu verstärken");
                        Character.dmgdeal = Character.dmgdeal + 20;
                        Console.WriteLine($"Deine Angriffskraft entspricht jetzt {Character.dmgdeal} AngriffsPunkten!");
                        Key_Enter();
                    }
                    else if (j == 3)
                    {
                        new IMGgen().MyIMG("roomxy.png", 240, 100);
                        Console.WriteLine(rooms_items[j]);
                        string[] ways1 = { "Geradeaus weiter gehen...", "Nach Links gehen..." };
                        int getchoice = new TakeChoice().Choice(ways1);
                        Console.Clear();
                    }
                    else if (j == 4)
                    {
                        new IMGgen().MyIMG("room2.png", 240, 100);
                        Console.WriteLine(rooms_items[j]);
                        string[] ways1 = { "Geradeaus weiter gehen...", "Nach Rechts gehen..." };
                        int getchoice = new TakeChoice().Choice(ways1);
                        Console.Clear();


                    }

                   


                }




            }
            if (Character.points >= 100)
            {
               Console.Clear();
                SoundsSet.output.Stop();
                SoundsSet.Music("xDeviruchi_The_Final_of_The_Fantasy.wav", 0.02f);
                new IMGgen().MyIMG("titlescreen1.png", 240, 100);
                Console.WriteLine("Nach endlosen Suchen und zahlreichen Kämpfen gegen Kobolde, Drachen, Schlangen und Spinnen hast du endlich den Ausgang aus einer Maya-Pyramide gefunden.");
                Console.WriteLine("Du hast Entbehrungen und Gefahren getrotzt, um diesen Moment zu erreichen. Jetzt fühlst du eine immense Erleichterung  und Freude, als du  endlich  das");
                Console.WriteLine("Tageslicht und die frische Luft wieder spürst. Es ist ein Gefühl des Triumphes, das sich in dir ausbreitet, da  du erfolgreich die Herausforderungen auf");
                Console.WriteLine("deinem Weg gemeistert hast.");
                Key_Enter();
                SoundsSet.output.Stop();
                SoundsSet.Music("xDeviruchi_Title_Theme.wav", 0.02f);
                Character.lifepoints = 100;
                Character.points = 0;
                Character.dmgdeal = 20;
                new Menu();

            }
            else if(Character.lifepoints <= 0)
            {
                Console.Clear();
                SoundsSet.output.Stop();
                SoundsSet.Music("xDeviruchi_The_Final_of_The_Fantasy.wav", 0.02f);
                new IMGgen().MyIMG("Game_over.png", 240, 100);
                Console.WriteLine("Du hast es leider nicht geschafft. Die Pyramide hat ihren Tribut verlangt!\n \n GAME OVER");
                Key_Enter();
                SoundsSet.output.Stop();
                SoundsSet.Music("xDeviruchi_Title_Theme.wav", 0.02f);
                Character.lifepoints = 100;
                Character.points = 0;
                Character.dmgdeal = 20;
                new Menu();
            }


        }

        internal static void Key_Enter()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            while (keyInfo.Key != ConsoleKey.Enter)
            {
                keyInfo = Console.ReadKey(true);
            }
            SoundsSet.output1.Stop();
            SoundsSet.Sound("select.wav", 0.02f);
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            
        }

        internal static void Room_choice(int choice)
        {
            
            Console.Clear();

            if(choice == 1) 
            {
                new IMGgen().MyIMG("room7v2.png",240,100);
                Console.WriteLine("Vor dir befiinden sich nun 4 Türen was tust du?");
                string[] ways1 = { "Durch die ganz linke Tür gehen.", "Geradeaus durch die zweite von Links gehen", "Durch die zweite von Rechts gehen.","Durch die ganz rechte Tür gehen." };
                int getchoice = new TakeChoice().Choice(ways1);
                Console.Clear();
            }
            else if(choice == 2)
            {
                new IMGgen().MyIMG("room11v2.png", 240, 100);
                Console.WriteLine("Vor dir befiinden sich nun 3 Türen was tust du?");
                string[] ways1 = { "Durch die ganz linke Tür gehen.", "Durch die mittlere Tür gehen", "Durch die ganz rechte Tür gehen." };
                int getchoice = new TakeChoice().Choice(ways1);
                Console.Clear();
            }
            



        }

    }
}
