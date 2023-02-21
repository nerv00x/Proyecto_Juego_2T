using Proyecto_Juego.probandomapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Juego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager game;
            Mapa map;
            Jugador player;
            Spawns spawns;


            map = new Mapa(60, 20);
            player = new Jugador(10, 10, map);
            spawns = new Spawns(map);
            game = new GameManager(map, player, spawns);



            map.Dibuja();
            game.iniciojugador();
            spawns.spwansEnemmigosDeNivel();
            spawns.spwansPociones();
            spawns.spwansArmas();
             
           
           
            ConsoleKey tecla;
            do
            {
                player.dibuja();
                tecla = Console.ReadKey(true).Key;
                game.mueveplayer(tecla);


            } while (tecla != ConsoleKey.Escape);


            Random rng = new Random();
            //Item[] inventario = new Item[10];
            List<Item> inventario = new List<Item>();

            


        }
    }
}
