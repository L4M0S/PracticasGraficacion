using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Numero de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            float[,] matriz;

            matriz = new float[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese valor [" + (j) + "],[" + (i) + "]: ");
                    float val;
                    val = float.Parse(Console.ReadLine());
                    matriz[j, i] = val;
                }
            }

            imprimir(matriz);

            int fila;
            int columna;

            float[,] matriz2;
            matriz2 = new float[columnas, filas];


            //Console.Write("Fila de la casilla a calcular: ");
            //fila = int.Parse(Console.ReadLine());
            //Console.Write("Columna de la casilla a calcular: ");
            //columna = int.Parse(Console.ReadLine());
            fila = 0;
            columna = 0;
            for(int i = fila;i<filas;i++)
            {
                for (int j=columna; j < columnas; j++)
                {
                    matriz2[j, i] = calcular(matriz, i, j);

                }
            }
            //matriz2[columna,fila] = calcular(matriz,fila,columna);

            imprimir(matriz2);
            
            /*
            for (int i = 0; i < matriz2.GetLength(1); i++)
            {
                for (int j = 0; j < matriz2.GetLength(0); j++)
                {
                    matriz2[j,i] = calcular(matriz, i, j);
                }

            }
            imprimir(matriz2);
            */
            Console.ReadLine();
        }

        public static void imprimir(float[,] matriz)
        {
            Console.WriteLine("La Matriz es: ");

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write(" " + matriz[j, i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static float calcular(float[,] matriz3, int fila, int columna)
        {
            float resultado;
            int filas = matriz3.GetLength(1);
            int columnas = matriz3.GetLength(0);
            resultado = (matriz3[(columna - 1 + columnas) % columnas, (fila - 1 + filas) % filas] + matriz3[(columna - 1 + columnas) % columnas, (fila + filas) % filas] + matriz3[(columna - 1 + columnas) % columnas, (fila + 1 + filas) % filas] +
                         matriz3[(columna + columnas) % columnas, (fila - 1 + filas) % filas] + matriz3[(columna + columnas) % columnas, (fila + filas) % filas] + matriz3[(columna + columnas) % columnas, (fila + 1 + filas) % filas] +
                         matriz3[(columna + 1 + columnas) % columnas, (fila - 1 + filas) % filas] + matriz3[(columna + 1 + columnas) % columnas, (fila + filas) % filas] + matriz3[(columna + 1 + columnas) % columnas, (fila + 1 + filas) % filas]
                        ) /9;

            return resultado;
        }

    }
}
