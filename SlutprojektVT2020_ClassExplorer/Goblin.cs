using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektVT2020_ClassExplorer
{
    //References directly to monster, as this is a monster the player encounters, and should thus be able to do whatever a monster can do, which would be within the monster class
    class Goblin : Monster
    {
        
        public Goblin()
        {
            strength = 15;
            dexterity = 50;
            constitution = 5;
            intelligence = 25;
        }
    }
}