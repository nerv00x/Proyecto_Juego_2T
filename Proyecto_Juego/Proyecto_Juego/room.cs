using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Juego
{
    public class room : Enemigos
    {

        public int vida = 10;
        public int daño = 5;


        public void atacar()
        {




        }

        public void dibuja()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("?");


        }

    }
}