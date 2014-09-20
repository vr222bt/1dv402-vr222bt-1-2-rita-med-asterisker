﻿using System;
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
                
                //if-sats som skriver ut ett mellanslag varannan gång
                if (row % 2 == 1) 
                {
                    Console.Write(" ");
                }

                //switch-sats som ändrar färgen på asterisken 
                switch (row % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    
                }

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
