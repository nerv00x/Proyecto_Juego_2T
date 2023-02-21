using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Juego
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    namespace probandomapa
    {
        public class Mapa
        {
            public Celda[,] tablero;
            Random rng = new Random();
            int nivel;
            int x = 30;
            int y = 10;
            int i = 0;
            int j = 0;
            int posicionrng;
            int numeroposiciones = 0;

            int posmetax;
            int posmetay;
            int poslagox;
            int poslagoy;
            public Mapa(int ancho, int alto)
            {
                tablero = new Celda[ancho, alto];
                randomwalker();

            }



            public void randomwalker()
            {

                numeroposiciones = 0;
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        tablero[i, j] = new Celda(materiales.muro);

                    }
                }


                do
                {
                    if (tablero[i, j].terreno == materiales.muro)
                    {
                        tablero[x, y].terreno = materiales.hierba;

                    }
                    else if (tablero[i, j].terreno == materiales.hierba)
                    {
                        tablero[x, y].terreno = materiales.hierba;
                        numeroposiciones--;
                    }
                    else if (tablero[i, j].terreno == materiales.hierba)
                    {
                        poslagox = rng.Next(60);
                        poslagoy = rng.Next(20);
                        tablero[posmetax, posmetay].terreno = materiales.agua;
                    }
                    posicionrng = rng.Next(1, 5);
                    if (posicionrng == 1)
                    {
                        if (x > 2)
                        {
                            x--;
                            numeroposiciones++;
                        }
                        else
                            x = x + 3;

                    }
                    else if (posicionrng == 2)
                    {
                        if (x < 58)
                        {
                            x++;
                            numeroposiciones++;
                        }
                        else
                            x = x - 3;
                    }
                    else if (posicionrng == 3)
                    {
                        if (y > 2)
                        {
                            y--;
                            numeroposiciones++;
                        }
                        else
                            y = y + 3;
                    }
                    else
                    {
                        if (y < 18)
                        {
                            y++;
                            numeroposiciones++;
                        }
                        else
                            y = y - 3;
                    }
                } while (numeroposiciones != 1500);

                do
                {
                    posmetax = rng.Next(tablero.GetLength(0));
                    posmetay = rng.Next(tablero.GetLength(1));
                } while (tablero[posmetax, posmetay].terreno == materiales.muro);
                tablero[posmetax, posmetay].terreno = materiales.final;

            }

        



            public void Dibuja()
            {
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(i, j);
                        tablero[i, j].Dibuja();
                    }
                }
            }
        }
    }



}
  