using Proyecto_Juego;
using Proyecto_Juego.probandomapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Juego
{
    public class Armas : Item 
    {

        public int durabiliad;
        public int dano;

        public override void Usar()
        {
            base.Usar();

        }
        public override void dibuja()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*");
        }
        
    }

}

