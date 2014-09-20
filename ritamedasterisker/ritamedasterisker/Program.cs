using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritamedasterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop som körs 25 gånger
            for (int row = 0; row < 25; row++)
            {
                //for loop som skirver ut "* " 39 gånger
                for (int col = 0; col < 39; col++)
                {
                    Console.Write("* ");
                }


                //Byter rad efter att asteriskerna skrivits ut
                Console.WriteLine();
            }

           




        }
    }
}
