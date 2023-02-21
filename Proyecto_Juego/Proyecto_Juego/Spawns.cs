using Proyecto_Juego.probandomapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Juego
{
    public class Spawns
    {
        Random rng = new Random();
        Mapa map;
        Armas arma;
        Pociones pociones;
        room enemigosNivel;
       
        public Spawns( Mapa map)
        {
           
            this.map = map;
           
          
        }

        public void spwansArmas() {
            
            int x;
            int y;

            for (int i = 0; i < 5; i++)
            {
                do
                {

                    x = rng.Next(map.tablero.GetLength(0));
                    y = rng.Next(map.tablero.GetLength(1));

                } while (map.tablero[x, y].terreno != materiales.hierba);

                Console.SetCursorPosition(x, y);
                arma = new Armas();
                arma.dibuja();

                

            }
            arma.Usar();




        }


        public void spwansPociones()
        {

            int x;
            int y;

            for (int i = 0; i < 3; i++)
            {
                do
                {

                    x = rng.Next(map.tablero.GetLength(0));
                    y = rng.Next(map.tablero.GetLength(1));

                } while (map.tablero[x, y].terreno != materiales.hierba);

                Console.SetCursorPosition(x, y);
                pociones = new Pociones();
                pociones.dibuja();



            }
            
        }


        public void spwansEnemmigosDeNivel()
        {

            int x;
            int y;

            for (int i = 0; i < 7; i++)
            {
                do
                {

                    x = rng.Next(map.tablero.GetLength(0));
                    y = rng.Next(map.tablero.GetLength(1));

                } while (map.tablero[x, y].terreno != materiales.hierba);

                Console.SetCursorPosition(x, y);
                enemigosNivel = new room();
                enemigosNivel.dibuja();



            }

        }

    }
}