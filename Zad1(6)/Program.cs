using System;

namespace Zad1_6_
{
    class Program
    {
         static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Enter n:");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Ошибка, Введите n заново\n");
            Console.WriteLine("Enter m:");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0)
                Console.WriteLine("Ошибка, Введите m заново\n");
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {

                    Console.Write("a[{0},{1}]= ", i, j) ;
                    while (!int.TryParse(Console.ReadLine(), out arr[i,j]))
                    {
                        Console.Write("Ошибка"+$"Введите заново [{i},{j}]: ");                        
                    }
                   
                }
            int sum = 0;
            double count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i, j];

                    count++;

                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Среднее арифметическое =" + sum/ count);

            Console.ReadLine();
            return arr;
        }
        static void Main()
        {
            int n;
            int m;
            int[,] myArray = Input(out n, out m);
        }
    }
}

