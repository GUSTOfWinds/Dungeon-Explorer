using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektVT2020_ClassExplorer
{
    class Creature
    {
        //Public values that are used by all subclasses
        public static Random randomgenerator = new Random();

        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;



        public bool ContestStrength(float enemyStrength)
        {
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