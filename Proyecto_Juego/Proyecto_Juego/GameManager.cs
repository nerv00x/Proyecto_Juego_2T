using Proyecto_Juego.probandomapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Juego
{
    public class GameManager
    {
        Mapa map;
        Jugador player;
        Random rng = new Random();
        Spawns spawns;

        public GameManager(Mapa map, Jugador player, Spawns spawns)
        {
            this.map = map;
            this.player = player;
            this.spawns = spawns;
        }


        public void iniciojugador()
        {
            int x;
            int y;
            do
            {
                x = rng.Next(map.tablero.GetLength(0));
                y = rng.Next(map.tablero.GetLength(1));

            } while (map.tablero[x, y].terreno != materiales.hierba);

            player.x = x;
            player.y = y;
        }

        public void mueveplayer(ConsoleKey tecla)
        {
            Console.SetCursorPosition(player.x, player.y);
            Celda celda = map.tablero[player.x, player.y];
            celda.Dibuja();
           
            switch (tecla)
            {
                case ConsoleKey.UpArrow:
                    MueveArriba();
                    break;
                case ConsoleKey.DownArrow:
                    MueveAbajo();
                    break;
                case ConsoleKey.LeftArrow:
                    MueveIzquierda();
                    break;
                case ConsoleKey.RightArrow:
                    MueveDerecha();
                    break;
            }
            if (map.tablero[player.x, player.y].terreno == materiales.final)
            {
                
                map.randomwalker();
                map.Dibuja();
                iniciojugador();
                spawns.spwansArmas();
                spawns.spwansPociones();
                spawns.spwansEnemmigosDeNivel();
               


            }
            
        }

     



        void MueveArriba()
        {
            Mueve(0, -1);
        }
        void MueveAbajo()
        {
            Mueve(0, 1);
        }
        void MueveIzquierda()
        {
            Mueve(-1, 0);
        }
        void MueveDerecha()
        {
            Mueve(1, 0);
        }


        void Mueve(int pasosx, int pasosy)
        {
            int nuevaX = player.x + pasosx;
            int nuevaY = player.y + pasosy;

            if (nuevaX >= 0 &&
                nuevaX < map.tablero.GetLength(0) &&
                nuevaY >= 0 &&
                nuevaY < map.tablero.GetLength(1) &&
                map.tablero[nuevaX, nuevaY].terreno != materiales.muro

                )
            {

                player.x = nuevaX;
                player.y = nuevaY;
            }
        }
      



    }

}