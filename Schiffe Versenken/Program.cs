using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffe_Versenken
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3;i++)
            {
                if (Ships.battleship._bcnt > 0)
                {
                    Ships.battleship B = new Ships.battleship(22, 44, 55, 66);
                    Console.WriteLine("funkt");
                }
                else
                {
                    Console.WriteLine(Ships.battleship._bcnt);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
