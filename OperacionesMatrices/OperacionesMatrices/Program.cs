using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primera matriz");
            
            Console.Write("Numero de columnas: ");
            int columnas1 = int.Parse(Console.ReadLine());
            Console.Write("Numero de filas: ");
            int filas1 = int.Parse(Console.ReadLine());

            float[,] matriz1;

            matriz1 = new float[columnas1, filas1];

            for (int i = 0; i < filas1; i++)
            {
                for (int j = 0; j < columnas1; j++)
                {
                    Console.Write("Ingrese valor [" + (j) + "],[" + (i) + "]: ");
                    float val;
                    val = float.Parse(Console.ReadLine());
                    matriz1[j, i] = val;
                }
            }
            imprimir(matriz1);

            Console.WriteLine("Segunda matriz");
            
            Console.Write("Numero de columnas: ");
            int columnas2 = int.Parse(Console.ReadLine());
            Console.Write("Numero de filas: ");
            int filas2 = int.Parse(Console.ReadLine());

            float[,] matriz2;

            matriz2 = new float[columnas2, filas2];

            for (int i = 0; i < filas2; i++)
            {
                for (int j = 0; j < columnas2; j++)
                {
                    Console.Write("Ingrese valor [" + (j) + "],[" + (i) + "]: ");
                    float val;
                    val = float.Parse(Console.ReadLine());
                    matriz2[j, i] = val;
                }
            }

            imprimir(matriz2);



            Console.WriteLine("1)Sumar matriz");
            Console.WriteLine("2)Restar matriz");
            Console.WriteLine("3)Multiplicar matriz");

            int opc = int.Parse(Console.ReadLine()); ;

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Sumar matriz");
                    sumar(matriz1, matriz2);
                    break;
                case 2:
                    Console.WriteLine("Restar matriz");
                    restar(matriz1, matriz2);
                    break;
                case 3:
                    Console.WriteLine("Multiplicar matriz");
                    multiplicar(matriz1, matriz2);
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }

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

        public static void sumar(float[,] matriz1, float[,] matriz2)
        {
            if(matriz1.GetLength(0)!= matriz2.GetLength(0) && matriz1.GetLength(1) != matriz2.GetLength(1))
            {
                Console.WriteLine("Las dimensiones no son adecuadas");
                return;
            }
            int filas = matriz1.GetLength(1);
            int columnas = matriz1.GetLength(0);

            float[,] matriz;

            matriz = new float[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[j, i] = matriz1[j, i] + matriz2[j, i];
                }
            }

            imprimir(matriz);
        }

        public static void restar(float[,] matriz1, float[,] matriz2)
        {
            if (matriz1.GetLength(0) != matriz2.GetLength(0) && matriz1.GetLength(1) != matriz2.GetLength(1))
            {
                Console.WriteLine("Las dimensiones no son adecuadas");
                return;
            }
            int filas = matriz1.GetLength(1);
            int columnas = matriz1.GetLength(0);

            float[,] matriz;

            matriz = new float[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[j, i] = matriz1[j, i] - matriz2[j, i];
                }
            }

            imprimir(matriz);
        }

        public static void multiplicar(float[,] matriz1, float[,] matriz2)
        {
            if (matriz1.GetLength(0) != matriz2.GetLength(1))       
            {
                Console.WriteLine("Las dimensiones no son adecuadas ");
                return;
            }

            int filas = matriz1.GetLength(1);
            int columnas = matriz2.GetLength(0);

            float[,] matriz;

            matriz = new float[columnas, filas];

            float suma = 0;

            for (int i = 0; i < matriz1.GetLength(1); i++)
            {

                for (int j = 0; j < matriz2.GetLength(0); j++)
                {
                    matriz[j, i] = 0;
                    //matriz[j, i] = (matriz1[0,j]*matriz2[j,0]) + (matriz1[1,j] * matriz2[j,1]) + (matriz1[2,j] * matriz2[j, 2]);
                    for (int k = 0; k < matriz1.GetLength(0); k++)
                    {
                        matriz[j, i] = matriz[j, i] + matriz1[k, i] * matriz2[j,k];
                        ///suma += (matriz1[j, k] * matriz2[k, i]);
                    }
                    //matriz[j, i] = (matriz1[j,i] * matriz2[i,j]) + (matriz1[1, j] * matriz2[j, 1]) + (matriz1[2, j] * matriz2[j, 2]);
                    ///matriz[j, i] = suma;
                    ///suma = 0;
                }
            }

            imprimir(matriz);
        }

    }
}
