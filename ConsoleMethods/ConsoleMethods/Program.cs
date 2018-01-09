using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethods
{
    class Program
    {

        #region Method

        static void Summa(int summand1, int summand2)
        {
            Console.WriteLine(summand1 + summand2);
        }

        #endregion

        #region Method optional params

        static int MethodTwo(int summand1 = 1, int summand2 = 2)
        {
            return summand1 + summand2;
        }

        #endregion

        #region Method Ref

        static int MethodRef(ref int summand1, int summand2 = 1)
        {
           return summand1 = summand1 + summand2; 

        }

        #endregion

        #region Method array params

        static string MethodArr(string str = "Hallo", params int[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                str += param[i].ToString();
            }

            return str;
        }

        #endregion



        static void Main(string[] args)
        {

            Summa(5, 7);
            int methodTwo = MethodTwo(5, 10);

            int summand = 5;
            MethodRef(ref summand, 111);

            Console.WriteLine(MethodArr("Ololo - ", 1, 2, 3, 4, 5,666));

            Console.WriteLine(summand);

            Console.WriteLine(methodTwo);
            Console.ReadKey();
        }
    }
}
