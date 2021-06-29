using System;
using System.Collections.Generic;
using System.Text;

namespace Fotografias
{
    class TipoFotos : Fotografias
    {
        public TipoFotos(int numeroFotos, char[,] colorPixel, char[] colorPixelFila, char[] colorPixelColumna)
            : base(numeroFotos, colorPixel, colorPixelFila, colorPixelColumna)
        {

        }

        public TipoFotos()
        {

        }

        public void encontrarTipoFoto(int numFila)
        {

            char[] colores = { 'C', 'M', 'Y', 'W', 'G', 'B' };
            colorPixelFila = new char[numFila];
            colorPixelColumna = new char[numFila];

            Random seleccionarFila = new Random();
            Random seleccionarColumna = new Random();

            for (int i = 0; i <= colorPixelFila.Length; i++)
            {
                for (int j = 0; j <= colorPixelFila.Length; j++)

                {

                    colorPixel = new char[numFila, 2];
                    colorPixelFila[i] = colores[seleccionarFila.Next(0, colorPixelFila.Length)];
                    colorPixelColumna[j] = colores[seleccionarColumna.Next(0, colorPixelFila.Length)];


                    if (colorPixelFila[i] == 'C' || colorPixelFila[i] == 'M' || colorPixelFila[i] == 'Y' ||
                        colorPixelColumna[j] == 'C' || colorPixelColumna[j] == 'M' || colorPixelColumna[j] == 'Y')
                    {
                        Console.WriteLine(i + j + " Color fila : " + colorPixelFila[i] + " color columna : " + colorPixelColumna[j] + " # Color");
                    }
                    if (colorPixelFila[i] != 'C' && colorPixelFila[i] != 'M' && colorPixelFila[i] != 'Y' &&
                        colorPixelColumna[j] != 'C' && colorPixelColumna[j] != 'M' && colorPixelColumna[j] != 'Y')
                    {
                        Console.WriteLine(i + j + " Color fila : " + colorPixelFila[i] + " color columna : " + colorPixelColumna[j] + " # Blanco y Negro");
                    }


                }

            }


        }
        public void encontrarTipoFoto(char numFila)
        {

            char[] colores = { 'C', 'M', 'Y', 'W', 'G', 'B' };
            colorPixelFila = new char[numFila];
            colorPixelColumna = new char[numFila];

            Random seleccionarFila = new Random();
            Random seleccionarColumna = new Random();

            for (int i = 0; i <= colorPixelFila.Length; i++)
            {
                for (int j = 0; j <= colorPixelFila.Length; j++)

                {

                    colorPixel = new char[numFila, 2];
                    colorPixelFila[i] = colores[seleccionarFila.Next(0, colorPixelFila.Length)];
                    colorPixelColumna[j] = colores[seleccionarColumna.Next(0, colorPixelFila.Length)];


                    if (colorPixelFila[i] == 'C' || colorPixelFila[i] == 'M' || colorPixelFila[i] == 'Y' ||
                        colorPixelColumna[j] == 'C' || colorPixelColumna[j] == 'M' || colorPixelColumna[j] == 'Y')
                    {
                        Console.WriteLine(i + j + " Color fila : " + colorPixelFila[i] + " color columna : " + colorPixelColumna[j] + " # Color");
                    }
                    if (colorPixelFila[i] != 'C' && colorPixelFila[i] != 'M' && colorPixelFila[i] != 'Y' &&
                        colorPixelColumna[j] != 'C' && colorPixelColumna[j] != 'M' && colorPixelColumna[j] != 'Y')
                    {
                        Console.WriteLine(i + j + " Color fila : " + colorPixelFila[i] + " color columna : " + colorPixelColumna[j] + " # Blanco y Negro");
                    }


                }

            }
        }
    }
}