using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Juego
{
    public class Celda
    {
        public int terreno;
        public Item objeto;
        public Celda(int t)
        {
            terreno = t;
           
        }

        public void Dibuja()
        {
            if (terreno == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("$");
            }
            else if (terreno == 1)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("$");

            }
            else if (terreno == 2)
            {
                
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(".");
            }
            else if (terreno == 5 )
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("♣");
            }
        }
    }
}
