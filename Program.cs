using System;

namespace Fotografias
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoFotos analizarFotos = new TipoFotos();
            
            Console.WriteLine("Menu");
            Console.WriteLine("1. Desea analizar fotografias");
            
            
            String menuKey = Console.ReadLine();
            try
            {
                if (menuKey == "1")
                {
                    try
                    {
                        Console.WriteLine("Escriba el numero de fotografias");
                        int numFotosM = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba el numero de pixeles");
                        int numFila = Convert.ToInt32(Console.ReadLine());
                        analizarFotos.encontrarTipoFoto(numFotosM);
                    }
                    catch (FormatException)
                    {
                        System.Console.WriteLine("El dato que escribiste no es un numero");
                    }
                    catch (NullReferenceException)
                    {
                        System.Console.WriteLine("El dato no se ha inicializado");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        System.Console.WriteLine("El dato esta fuera del arreglo");
                    }

                    catch (OverflowException)
                    {
                        System.Console.WriteLine("El dato no puede guardar el valor");
                    }

                }
            }
            catch (FormatException)
            {
                System.Console.WriteLine("El dato que escribiste no es una opcion disponible");
            }
        
           
        }
    }
}
