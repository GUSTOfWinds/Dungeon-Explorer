using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektVT2020_ClassExplorer
{
    //References directly to Hero, as this is a class used by the player, and thus it should be able to use any functions any player class would be able to use, which would be within the hero class
    class Failure : Hero
    {
        //A constructor for generating the "ability scores" of the hero character, called upon during the "character creation" process of program.cs
        public Failure()
        {
            strength = 0;
            dexterity = 0;
            constitution = 0;
            intelligence = 0;
        }
    }
}