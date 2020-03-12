using System;

namespace SlutprojektVT2020_ClassExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomgenerator = new Random();

            Console.WriteLine("Greetings, Hero. You are about to enter the dungeon. Before you enter, please select a name and class");
            Console.ReadLine();
            Console.WriteLine("Please write in your name, and then hit enter to confirm");
            string HeroName = Console.ReadLine();
            Console.WriteLine("Now, " + HeroName + ", please select your class by writing the respective number (1, 2, 3 etc.) and hit enter to confirm");
            string HeroClass = Console.ReadLine();
            string HeroClassWriteout = "empty";
            if (HeroClass == "1")
            {

            }
            if (HeroClass == "2")
            {

            }
            if (HeroClass == "3")
            {

            }
            else
            {

            }
            Console.WriteLine("You selected " + HeroClassWriteout + ". Your name is" + HeroName + ". And now, you enter the dungeon...");


            //ACTUAL DUNGEON GAME
        }
    }
}
