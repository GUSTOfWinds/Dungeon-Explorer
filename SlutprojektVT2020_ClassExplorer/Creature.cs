using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektVT2020_ClassExplorer
{
    class Creature
    {
        //A Random generator for use both with Creature's methods, as well as any methods that monsters or Hero's might use
        public static Random randomgenerator = new Random();

        //A defining block for all the "ability scores" that serve as a primary influence next to the randomly generated numbers in methods. This is so that all subclasses can reference it.
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;


        //This bool returns true or false, based on whether the hero won(true) or lost (false) against an enemy in a strength contest. It takes in an enemy strength value, and compares it to the user's (in this case the hero's) strength value.
        public bool ContestStrength(float enemyStrength)
        {
            //This makes two floats using a randomgenerator and base values, akin to rolling dice, which are then compared in an if/else statement
            float resultMe = strength + randomgenerator.Next(1, 101);
            float resultEnemy = enemyStrength + randomgenerator.Next(1, 101);
            if (resultMe >= resultEnemy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //The same function as ContestStrength, but for a different "ability score".
        public bool ContestDexterity(float enemyDexterity)
        {
            float resultMe = dexterity + randomgenerator.Next(1, 101);
            float resultEnemy = enemyDexterity + randomgenerator.Next(1, 101);
            if (resultMe >= resultEnemy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //The same function as ContestStrength, but for a different "ability score".
        public bool ContestConstitution(float enemyConstitution)
        {
            float resultMe = constitution + randomgenerator.Next(1, 101);
            float resultEnemy = enemyConstitution + randomgenerator.Next(1, 101);
            if (resultMe >= resultEnemy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //The same function as ContestStrength, but for a different "ability score".
        public bool ContestIntelligence(float enemyIntelligence)
        {
            float resultMe = intelligence + randomgenerator.Next(1, 101);
            float resultEnemy = enemyIntelligence + randomgenerator.Next(1, 101);
            if (resultMe >= resultEnemy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}