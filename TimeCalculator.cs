using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftBreedingCalculatorGui
{
    public class TimeCalculator
    {
        /*
         * This function works as follows- we need to get the total animals to be greater than the goal.
         * This is done using an int queue, where we then dequeue after 4 iterations, as then the number at the start of the queue would have completed growth.
         */
        public static int TimeCalculation(int totalAnimals, int animalsToGet)
        {
            int animalsActive = totalAnimals - (totalAnimals % 2);
            Queue<int> babyAnimals = new Queue<int>();
            int i = 0;
            //iterating through the amount of animals, incrementing time by five every time. 
            while (animalsToGet > totalAnimals)
            {
                totalAnimals += (animalsActive / 2);
                if (i > 3)
                {
                    animalsActive = totalAnimals - (totalAnimals % 2);
                    babyAnimals.Dequeue();
                }
                babyAnimals.Enqueue(animalsActive / 2);
                i++;
            }

            return i*5; //return iterations *5 (as this is all done in intervals of 5 minutes (animals have a 5 minute cooldown))
        }
    }
    
}
