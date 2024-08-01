using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftBreedingCalculatorGui
{
    public class TimeCalculator
    {
        public static int TimeCalculation(int totalAnimals, int animalsToGet)
        {
            int animalsActive = totalAnimals - (totalAnimals % 2);
            Queue<int> babyAnimals = new Queue<int>();
            int time = 0;
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
                time += 5;
                i++;
            }

            return time;
        }
    }
    
}
