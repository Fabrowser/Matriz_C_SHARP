using System;

namespace Matriz_Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a ordem da matriz: ");
            int ordem = int.Parse(Console.ReadLine());


            int[,] mat = new int[ordem, ordem];
            Console.WriteLine(mat.Length);


            //Recebe Valores Matriz
            for (int i = 0; i < mat.GetLength(0); i++)
            {

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    int valor = int.Parse(Console.ReadLine());
                    mat.SetValue(valor, i, j);// poderia ser mat[i,j] = int.Parse(Console.ReadLine());

                }


            }


            //Exibe Valores matriz
            Console.WriteLine("---Matriz completa----\n");

            for (int i = 0; i < mat.GetLength(0); i++)
            {

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(" " + mat[i,j]); // Outra maneira de representar posição da matriz = mat[i,j]

                }

                Console.WriteLine();

            }

            Console.WriteLine("----------------------");



            //Exibe Diagonal principal
            Console.WriteLine("--Diagonal principal--\n");

            for (int i = 0; i < mat.GetLength(0); i++)
            {

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(" " + mat.GetValue(i, j) + " / ");
                    }


                }

            }

            Console.WriteLine("\n----------------------");


            //Exibe Valores Negativos da Matriz
            Console.WriteLine("\n--Valores Negativos---");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    int x = (int)mat.GetValue(i, j);
                    if (x < 0)
                    {
                        Console.Write(x + " / ");
                    }
                }
            }

        }
    }
}
