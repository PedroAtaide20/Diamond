using System;

namespace Diamond.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colunas;
        inicio:

            //numero de colunas - impar 
            Console.WriteLine("Insira as colunas do seu DIAMANTE! ");
            colunas = Convert.ToInt32(Console.ReadLine());
            if (colunas % 2 != 0)
            {
                int var = colunas / 2;
                for (int i = 0; i < var; i++)
                {
                    for (int j = 0; j < var - i; j++)
                    {
                        Console.Write(" ");
                    }

                    int contador = (2 * i) + 1;
                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write("x");

                    }
                    Console.WriteLine();
                }
                // contador invertido para a parte de baixo do diamante
                for (int i = var; i >= 0; i--)
                {
                    for (int j = 0; j < var - i; j++)
                    {
                        Console.Write(" ");
                    }
                    int contador = (2 * i) + 1;
                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write("x");

                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("O número não é impar! Repita o processo");
                goto inicio;
            }
            Console.ReadKey();
        }
    }
}
