using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Juego
{
    public class Pociones : Item
    {
        public void Usar() {
        
        base.Usar();
            
        
        }

        public override void dibuja()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("^");
        }

    }
}