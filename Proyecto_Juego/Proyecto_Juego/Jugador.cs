using Proyecto_Juego.probandomapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Juego
{
    public class Jugador
    {
        public int x, y;
        public Mapa map;

        public Jugador(int x,int y, Mapa m)
        {
           
           this.y = y;
           this.x= x;
           this.map = m;

            
        }
        public void dibuja() 
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x,y);
            Console.WriteLine("☺");
        }


    }


}
