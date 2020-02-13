using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] matriz = new int[3, 3] { { 1, 3, 5 },
                                            { 2, 4, 6 },
                                            { 3, 5, 9 }};
          


            int determiante=7;
            determiante = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) + (matriz[1, 0] * matriz[2, 1] * matriz[0, 2]) + (matriz[0, 1] * matriz[1, 2] * matriz[2, 0])) - ((matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) + (matriz[0, 1] * matriz[1, 0] * matriz[2, 2]) + (matriz[1, 2] * matriz[2, 1] * matriz[0, 0]));
          
            Console.WriteLine("EL determinante de la matriz es: {0}",determiante);
          
        }
    }
} 

        
