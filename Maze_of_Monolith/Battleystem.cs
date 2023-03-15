using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_of_Monolith
{
    internal class Battleystem
    {

        static string[] options = new string[2];
        internal Battleystem()
        {
            Key_Enter();
            options = new string[] { $"Den Gegner angreifen! (Angrifstärke: {Character.dmgdeal})", $"Vor dem Gegner weglaufen (50% Erfolgschance)" };

        }

        internal void Zombie_()
        {
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Prepare_for_Battle.wav", 0.02f);
            TakeChoice choice = new TakeChoice();
            Zombie zombie = new Zombie();
            Console.Write("Was möchtest du tun?\n");

            Key_Enter();
            while (zombie.lifepoints > 0 && Character.lifepoints > 0)
            {
                int getchoice = choice.Choice(options);
                ClearLines.Clear(2);

                if (getchoice == 0)
                {
                    zombie.lifepoints = zombie.lifepoints - Character.dmgdeal;
                    if (zombie.lifepoints <= 0)
                    {
                        Console.WriteLine($"Die Mumie verhädert sich in ihren Bandagen und zerfällt. Du erhältst {zombie.dmgdeal} Punkte!");
                        Character.points = Character.points + zombie.dmgdeal;
                        Key_Enter();
                        break;
                    }
                    Console.WriteLine($"Die Mumie hat nur noch {zombie.lifepoints} Lebenspunkte.");
                    Key_Enter();
                }
                else if (getchoice == 1)
                {
                    Random random = new Random();
                    int i = random.Next(0, 100);
                    if (i < 50)
                    {
                        Console.WriteLine("Du bist entkommen");
                        Key_Enter();
                        zombie.lifepoints = 0;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Flucht versuch gescheitert!");
                        Key_Enter();
                    }
                }
                Console.WriteLine("Die Mumie greift an!");
                Character.lifepoints = Character.lifepoints - zombie.dmgdeal;
                Key_Enter();
                Console.WriteLine($"Dir verbleiben noch {Character.lifepoints}/100 LP");
                Key_Enter();

            }
            if(Character.lifepoints <= 0)
            {
                Console.WriteLine("Du hauchst dein Leben aus...");
                Key_Enter();
            }
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Mysterious_Dungeon.wav", 0.02f);
        }


        internal void Spider()
        {
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Prepare_for_Battle.wav", 0.02f);
            TakeChoice choice = new TakeChoice();
            Spider spider = new Spider();
            Console.Write("Was möchtest du tun?\n");

            Key_Enter();
            while (spider.lifepoints > 0 && Character.lifepoints > 0)
            {
                int getchoice = choice.Choice(options);
                ClearLines.Clear(2);

                if (getchoice == 0)
                {
                    spider.lifepoints = spider.lifepoints - Character.dmgdeal;
                    if (spider.lifepoints <= 0)
                    {
                        Console.WriteLine($"Du hast die Riesenspinne so schwer verletzt das sie sich kreischen und mit den Beinen rudernt zurückzieht. Du erhältst {spider.dmgdeal} Punkte!");
                        Character.points = Character.points + spider.dmgdeal;
                        break;
                    }
                    Console.WriteLine($"Die Spinne hat nur noch {spider.lifepoints} Lebenspunkte.");
                    Key_Enter();
                }
                else if (getchoice == 1)
                {
                    Random random = new Random();
                    int i = random.Next(0, 100);
                    if (i < 50)
                    {
                        Console.WriteLine("Du bist entkommen");
                        Key_Enter();
                        spider.lifepoints = 0;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Flucht versuch gescheitert!");
                        Key_Enter();
                    }
                }
                Console.WriteLine("Die Spinne greift an!");
                Character.lifepoints = Character.lifepoints - spider.dmgdeal;
                Key_Enter();
                Console.WriteLine($"Dir verbleiben noch {Character.lifepoints}/100 LP");
                Key_Enter();

            }
            if (Character.lifepoints <= 0)
            {
                Console.WriteLine("Du hauchst dein Leben aus...");
                Key_Enter();
            }
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Mysterious_Dungeon.wav", 0.02f);
        }


        internal void Snake()
        {
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Prepare_for_Battle.wav", 0.02f);
            TakeChoice choice = new TakeChoice();
            Snake snake = new Snake();
            Console.Write("Was möchtest du tun?\n");

            Key_Enter();
            while (snake.lifepoints > 0 && Character.lifepoints > 0)
            {
                int getchoice = choice.Choice(options);
                ClearLines.Clear(2);

                if (getchoice == 0)
                {
                    snake.lifepoints = snake.lifepoints - Character.dmgdeal;
                    if (snake.lifepoints <= 0)
                    {
                        Console.WriteLine($"Zischend haucht der Schlangenkönig sein Leben aus. Du erhältst {snake.dmgdeal} Punkte!");
                        Character.points = Character.points + snake.dmgdeal;
                        break;
                    }
                    Console.WriteLine($"Die Schlange hat nur noch {snake.lifepoints} Lebenspunkte.");
                    Key_Enter();
                }
                else if (getchoice == 1)
                {
                    Random random = new Random();
                    int i = random.Next(0, 100);
                    if (i < 50)
                    {
                        Console.WriteLine("Du bist entkommen");
                        Key_Enter();
                        snake.lifepoints = 0;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Flucht versuch gescheitert!");
                        Key_Enter();
                    }
                }
                Console.WriteLine("Die Riesenschlange greift an!");
                Character.lifepoints = Character.lifepoints - snake.dmgdeal;
                Key_Enter();
                Console.WriteLine($"Dir verbleiben noch {Character.lifepoints}/100 LP");
                Key_Enter();

            }
            if (Character.lifepoints <= 0)
            {
                Console.WriteLine("Du hauchst dein Leben aus...");
                Key_Enter();
            }
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Mysterious_Dungeon.wav", 0.02f);
        }


        internal void Goblin()
        {
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Prepare_for_Battle.wav", 0.02f);
            TakeChoice choice = new TakeChoice();
            Goblin goblin = new Goblin();
            Console.Write("Was möchtest du tun?\n");
            Key_Enter();

            while (goblin.lifepoints > 0 && Character.lifepoints > 0)
            {
                int getchoice = choice.Choice(options);
                ClearLines.Clear(2);

                if (getchoice == 0)
                {
                    goblin.lifepoints = goblin.lifepoints - Character.dmgdeal;
                    if (goblin.lifepoints <= 0)
                    {
                        Console.WriteLine($"Das hat der Kobold nicht überlebt... er fällt tot um. Du erhältst {goblin.dmgdeal} Punkte!");
                        Character.points = Character.points + goblin.dmgdeal;
                        Key_Enter();
                        break;
                    }
                    Console.WriteLine($"Der Kobold hat nur noch {goblin.lifepoints} Lebenspunkte.");
                    Key_Enter();
                }
                else if (getchoice == 1)
                {
                    Random random = new Random();
                    int i = random.Next(0, 100);
                    if (i < 50)
                    {
                        Console.WriteLine("Du bist entkommen");
                        Key_Enter();
                        goblin.lifepoints = 0;
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("Flucht versuch gescheitert!");
                        Key_Enter();
                    }
                }
                Console.WriteLine("Der Kobold greift an!");
                Character.lifepoints = Character.lifepoints - goblin.dmgdeal;
                Key_Enter();
                Console.WriteLine($"Dir verbleiben noch {Character.lifepoints}/100 LP");
                Key_Enter();

            }
            if (Character.lifepoints <= 0)
            {
                Console.WriteLine("Du hauchst dein Leben aus...");
                Key_Enter();
            }
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Mysterious_Dungeon.wav", 0.02f);
        }


        internal void Dragon()
        {
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Prepare_for_Battle.wav", 0.02f);
            TakeChoice choice = new TakeChoice();
            Dragon dragon = new Dragon();
            Console.Write("Was möchtest du tun?\n");
            Key_Enter();

            while (dragon.lifepoints > 0 && Character.lifepoints > 0)
            {
                int getchoice = choice.Choice(options);
                ClearLines.Clear(2);

                if (getchoice == 0)
                {
                    dragon.lifepoints = dragon.lifepoints - Character.dmgdeal;
                    if (dragon.lifepoints <= 0)
                    {
                        Console.WriteLine($"Das hat der Drache nicht überlebt... Brüllend fällt er tot um. Du erhältst {dragon.dmgdeal} Punkte!");
                        Character.points = Character.points + dragon.dmgdeal;
                        break;
                    }
                    Console.WriteLine($"Der Drache hat nur noch {dragon.lifepoints} Lebenspunkte.");
                    Key_Enter();
                }
                else if (getchoice == 1)
                {
                    Random random = new Random();
                    int i = random.Next(0, 100);
                    if (i < 50)
                    {
                        Console.WriteLine("Du bist entkommen");
                        Key_Enter();
                        dragon.lifepoints = 0;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Flucht versuch gescheitert!");
                        Key_Enter();
                    }
                }
                Console.WriteLine("Der Drache greift an und speit auf dich Feuer!");
                Character.lifepoints = Character.lifepoints - dragon.dmgdeal;
                Key_Enter();
                Console.WriteLine($"Dir verbleiben noch {Character.lifepoints}/100 LP");
                Key_Enter();

            }
            if (Character.lifepoints <= 0)
            {
                Console.WriteLine("Du hauchst dein Leben aus...");
                Key_Enter();
            }
            SoundsSet.output.Stop();
            SoundsSet.Music("xDeviruchi_Mysterious_Dungeon.wav", 0.02f);
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
            ClearLines.Clear(1);
            


        }


    }
}
