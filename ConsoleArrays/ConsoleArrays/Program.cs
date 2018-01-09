using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Array OneDemention

            int[] arrOne = new int[5];
            for (int i = 0; i < arrOne.Length; i++)
            {
                arrOne[i] += i;
            }

            for (int i = 0; i < arrOne.Length; i++)
            {
                Console.WriteLine("OneDem {0}", arrOne[i]);
            }

            #endregion

            #region Array TwoDemention

               int[,] arrTwo = 
               {
                   { 11, 12, 13, 14, 15 },
                   { 21, 22, 23, 24, 25 }
               };

            for (int i = 0; i < arrTwo.GetLength(0); i++)
            {
                for (int w = 0; w < arrTwo.GetLength(1); w++)
                {
                    Console.WriteLine("TwoDem {0}", arrTwo[i,w]);
                }
            }



            #endregion

            #region JaggetArray

            int[][] arrJag = new int[3][];

            arrJag[0] = new int[] { 1, 2 };
            arrJag[1] = new int[] { 1, 2, 3, 5 };
            arrJag[2] = new int[] { 1, 2, 6, 7, 99 };

            for (int i = 0; i < arrJag.Length; i++)
            {
                for (int w = 0; w < arrJag[i].Length; w++)
                {
                    Console.WriteLine("ArrJag {0}", arrJag[i][w]);
                }
            }



            #endregion

            Console.ReadKey();

        }
    }
}
