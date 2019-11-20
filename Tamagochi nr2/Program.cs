using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_nr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagochi NewT = new Tamagochi();
            Console.WriteLine(@"
A egg starts to hatch, what could it be?
A cute little fluffy ball rolls out from the egg and yeeps at you
What will you name the little fella?
");

            NewT.Name = Console.ReadLine();

            Console.WriteLine(@"
Sweet! Now its time to take care of " + NewT.Name + @" You will need to keep an eye of its Hunger, Boredom and Sleep 
...Welp, good luck!");

            while (NewT.isAlive())
            {
                Console.WriteLine(@"
What to do?
a) Play?
b) Eat?
c) Sleep?
d) Check my stats?");

                Console.ReadLine();

                if ()
                {

                }



                NewT.Tick();
            }

            Console.ReadLine();
        }
    }
}
