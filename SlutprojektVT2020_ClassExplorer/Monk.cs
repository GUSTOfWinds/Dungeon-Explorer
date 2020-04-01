using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektVT2020_ClassExplorer
{
    //References directly to Hero, working identical to the Warrior or Failure class, or any other classes based off Hero to be picked by the player
    class Monk : Hero
    {
        //Constructor for generating "ability scores" for the entity, which are used by the various methods that Hero & Creature have
        public Monk()
        {
            strength = 50;
            dexterity = 75;
            constitution = 0;
            intelligence = 25;
        }
    }
}