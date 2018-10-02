using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз2._1
{
    class Program
    {

        private static void Main(string[] args)
        {
            var mas = GenerateMatrix(5,5);
            DrawMatrix(mas);
            MaxMas(mas);



            Console.ReadLine();
        }
        public static void  MaxMas(int[,] mass)
        {             
             int[] arr = new int[5];
            for (int i = 0; i<5; i++)
            {  int sum = 0;
                for (int j = 0; j<5; j++)
                {
                    sum += mass[j, i];
                 }
                 arr[i]=sum;
            }
            Console.WriteLine("sum");
            for (int i = 0; i < 5; i++)
            {
              Console.Write(arr[i]+" | ");
                
            }
            //1. Находим минимальное значение
            int maxVal = arr.Max(); 
             //2. Находим индекс
            int indexMax = Array.IndexOf(arr, maxVal);
            Console.WriteLine(" ");
            Console.WriteLine("Max sum in column # " + (indexMax+1));
            Console.ReadLine();
        }

        public static int[,] GenerateMatrix(int x, int y, int maxRandom = 10)
        {
            int[,] matrix = new int[x, y];

            Random rnd = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rnd.Next(1, maxRandom);
                }
            }

            return matrix;
        }

        public static void DrawMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{(matrix[i, j].ToString().Length < 2 ? matrix[i, j].ToString() + "  |" : matrix[i, j].ToString() + " |")}");
                }
                Console.WriteLine();
            }
        }
    }
}
