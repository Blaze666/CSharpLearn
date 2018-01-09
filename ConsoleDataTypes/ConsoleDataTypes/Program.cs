using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Data Types in C#

            bool @bool = true;

            byte @byte = 255;
            sbyte @sbyte = -128;

            char @char = 'k';

            short @short = -32000;
            ushort @ushort = 64000;

            int @int = -2000000000;
            uint @uint = 4000000000;

            long @long = -10000000000000;
            ulong @ulong = 10000000000000;

            float @float = 3.14f;
            double @double = 21.41111d;
            decimal @decimal = 2.212145454m;


            string @string = "ololo";

            Console.WriteLine(@bool);
            Console.WriteLine(@byte);
            Console.WriteLine(@sbyte);
            Console.WriteLine(@char);
            Console.WriteLine(@short);
            Console.WriteLine(@ushort);
            Console.WriteLine(@int);
            Console.WriteLine(@uint);
            Console.WriteLine(@long);
            Console.WriteLine(@ulong);
            Console.WriteLine(@float);
            Console.WriteLine(@double);
            Console.WriteLine(@decimal);

            Console.ReadKey();

            #endregion


        }
    }
}
