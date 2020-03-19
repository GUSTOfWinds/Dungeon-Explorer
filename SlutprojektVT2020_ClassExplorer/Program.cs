using System;

namespace SlutprojektVT2020_ClassExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomgenerator = new Random();

            //Character Creator that generates both a statblock for the hero, as well as a name. Both of these are chosen by the user.
            Console.WriteLine("Greetings, Hero. You are about to enter the dungeon. Before you enter, please select a name and class");
            Console.WriteLine("To begin with, please write in your name, and then hit enter to confirm");
            string HeroName = Console.ReadLine();
            Console.WriteLine("Now, " + HeroName + ", please select your class by writing the respective number (1, 2, 3 etc.) and hit enter to confirm");
            Console.WriteLine("The avaliable classes are as follows:");
            Console.WriteLine("1: Warrior. A combatant focusing on strength and durability, with average speed and lacking intelligence");
            Console.WriteLine("NOTE: If you do not select a class properly, I am not responsible for the consequences.");
            string HeroClass = Console.ReadLine();
            if (HeroClass == "1")
            {
                Console.WriteLine(HeroName + " is a Warrior!");
            }
            //MORE CLASSES
            else
            {
                Console.WriteLine(HeroName + " is a Failure...");
            }
            Console.ReadLine();
            Console.WriteLine("Now, into the dungeon you go. Good luck!");
            Console.ReadLine();

            //ACTUAL DUNGEON GAME
        }
    }
}