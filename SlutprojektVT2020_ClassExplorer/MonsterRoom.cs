using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektVT2020_ClassExplorer
{
    class MonsterRoom : Room
    {
        public int monsterAmount;
        List<Monster> monsterList = new List<Monster>();

        public void monsterGenerator()
        {
            monsterAmount = randomgenerator.Next(6);

            for (int i = 0; i < monsterAmount; i++)
            {
                Goblin genericGoblin = new Goblin();
                monsterList.Add(genericGoblin);
            }
        }
    }
}