// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Random rnd = new Random();
int m = rnd.Next(1, 5);
Console.WriteLine($"Строк будет: {m}");
int n = rnd.Next(1, 10);
Console.WriteLine($"Столбцов будет: {n}");

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rnd.NextDouble() * 100 ), 0);
        }
    }
}

PrintArr(arr);



void PrintArr(double[,] arry)  // метод вывода на печать массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],8}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();


for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {double sum=0;
            if (i  == 0 )
            {
                sum =arr[i, j] + arr[i+1, j]+ arr[i+2, j];
            }Console.WriteLine(sum);
        }
    }