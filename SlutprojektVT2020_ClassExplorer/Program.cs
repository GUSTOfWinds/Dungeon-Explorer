using System;

namespace SlutprojektVT2020_ClassExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a randomgenerator for later use, as well as a definition of the hero class, so that the "character creation" if/else functions later down can decide which subclass to make it
            Random randomgenerator = new Random();
            Hero hero;

            //Text messages which tell the user what to do, as well as allows them to select a name for their character
            Console.WriteLine("Greetings, Hero. You are about to enter the dungeon. Before you enter, please select a name and class");
            Console.WriteLine("To begin with, please write in your name, and then hit enter to confirm");
            string HeroName = Console.ReadLine();
            //Text messages that tell the user how to pick a character class, as well as presents the options
            Console.WriteLine("Now, " + HeroName + ", please select your class by writing the respective number (1, 2, 3 etc.) and hit enter to confirm");
            Console.WriteLine("The avaliable classes are as follows:");
            Console.WriteLine("1: Warrior. A combatant focusing on strength and durability, with average speed and lacking intelligence");
            Console.WriteLine("NOTE: If you do not select a class properly, I am not responsible for the consequences.");
            string HeroClass = Console.ReadLine();
            //uses an if/else statement, along with a string function to determine which class to select, with a failsafe if the user enters it incorrectly so the program does not break
            if (HeroClass == "1")
            {
                Console.WriteLine(HeroName + " is a Warrior!");
                hero = new Warrior();
            }
            //TO ADD: MORE CLASSES TO PICK FROM
            else
            {
                Console.WriteLine(HeroName + " is a Failure...");
                hero = new Warrior();

            }
            Console.ReadLine();
            Console.WriteLine("Now, into the dungeon you go. Good luck!");
            Console.ReadLine();


            //TEST: What is below functions as a testing of the functions implemented, more specifically of the generation of a goblin class, as well as a method in the creature class
            Console.WriteLine("A Goblin Appears!");
            Goblin TestEnemy = new Goblin();
            Console.ReadLine();
            Console.WriteLine("The Goblin & The Hero Fight!");

            //This calls upon a method to generate a bool, which is then used to determine a "winner"
            bool HeroWin = hero.ContestStrength(TestEnemy.strength);
            if (HeroWin == true)
            {
                Console.WriteLine("Hero Wins!");
            }
            else
            {
                Console.WriteLine("Hero Lose!");
            }
            Console.WriteLine("TestEnd");
            Console.ReadLine();
        }
    }
}