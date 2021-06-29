using System;
using System.Collections.Generic;
using System.Text;

namespace Fotografias
{
    class Fotografias
    {
        //declaracion variables
        protected int numeroFotos;
        protected char[,] colorPixel;
        protected char[] colorPixelFila;
        protected char[] colorPixelColumna;
        

        //constructor
        public Fotografias(int numeroFotos, char[,] colorPixel, char[] colorPixelFila, char[] colorPixelColumna)
        {

        }

        //constructor vacio
        public Fotografias()
        {

        }

        public void info()
        {
            Console.WriteLine("\n Numero de Fotografias: " + numeroFotos);
            Console.WriteLine("\n Matriz Pixel: " + colorPixel);
            Console.WriteLine("\n Fila: " + colorPixelFila);
            Console.WriteLine("\n Columna: " + colorPixelColumna);
        }
        public int NumeroFotos
        {
            get { return this.numeroFotos; }
            set { this.numeroFotos = numeroFotos; }
        }

        public char[,] ColorPixel
        {
            get { return this.colorPixel; }
            set { this.colorPixel = colorPixel; }
        }

        public char[] ColorPixelFila
        {
            get { return this.colorPixelFila; }
            set { this.colorPixel = colorPixel; }
        }

        public char[] ColorPixelColumna
        {
            get { return this.colorPixelColumna; }
            set { this.colorPixelColumna = colorPixelColumna; }
        }
    }
}
