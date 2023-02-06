// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Вариант 1 (через ввод размера пользователем):
Console.Write("Введите кол-во строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rnd.NextDouble() * 100 - 50), 1);
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



// Вариант 2 (полный рандом):
// Random rnd = new Random();
// int m = rnd.Next(1, 20);
// Console.WriteLine($"Строк будет: {m}");
// int n = rnd.Next(1, 10);
// Console.WriteLine($"Столбцов будет: {n}");

// double[,] arr = new double[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = Math.Round((rnd.NextDouble() * 100 - 50 ), 1);
//         }
//     }
// }

// PrintArr(arr);



// void PrintArr(double[,] arry)  // метод вывода на печать массива
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j],8}");
//         }
//         Console.WriteLine();
//     }
// }