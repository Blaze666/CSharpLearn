using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region While, doWhile

            short counter = 0;
            short doCounter = 0;

            while (counter < 5)
            {
                Console.WriteLine(counter);

                counter++;
            }


            do
            {

                doCounter++;

                Console.WriteLine(doCounter);

            } while (doCounter < 5);



            #endregion

            #region For, continue, break

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("GO break {0}", i);

                break;

                Console.WriteLine("Never GO!");

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("GO continue {0}", i);

                continue;

                Console.WriteLine("Never GO!");

            }

            #endregion

            Console.ReadKey();
        }
    }
}
