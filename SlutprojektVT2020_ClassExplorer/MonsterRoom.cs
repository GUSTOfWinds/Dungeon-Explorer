using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektVT2020_ClassExplorer
{
    //References room, allowing it to use any room variables or methods
    class MonsterRoom : Room
    {
        //This makes an int for the method to utalize, as well as a list of monsters for the method to add to.
        public int monsterAmount;
        List<Monster> monsterList = new List<Monster>();

        public void monsterGenerator()
        {
            //The int is randomly generated to change how many monsters will be added/how much the for loop will run
            monsterAmount = randomgenerator.Next(6);

            //This for loop adds creatures monsters, and then adds them to the list depending on the above value
            for (int i = 0; i < monsterAmount; i++)
            {
                Goblin genericGoblin = new Goblin();
                monsterList.Add(genericGoblin);
            }
        }
    }
}