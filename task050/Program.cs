// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9
// *попробовать через Split

// Вариант 1:
Random rnd = new Random();
Console.WriteLine("Например, задан массив:");
int[,] arr = new int[rnd.Next(3, 10), rnd.Next(5, 10)];
Console.WriteLine($"- с количеством строк: {arr.GetLength(0)}");
Console.WriteLine($"- с количеством столбцов: {arr.GetLength(1)}");
FillArrayRandom(arr);
PrintArr(arr);
Console.Write("Введите номер строки: ");
int k = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца: ");
int l = Convert.ToInt32(Console.ReadLine()) - 1;


if (k < 0 | k >= arr.GetLength(0) | l < 0 | l >= arr.GetLength(1))
{
    Console.WriteLine($"arr[{k}, {l}] -> такого значения нет!");
}
else
{
    Console.WriteLine($"arr[{k}, {l}] -> {arr[k, l]}");
}


void FillArrayRandom(int[,] arr)    // создаем рандомный двумерный массив из целых чисел
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);

        }

    }
}

void PrintArr(int[,] arry)  // метод вывода на печать массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],2}");
        }
        Console.WriteLine();
    }
}


// Вариант 2(*через Split):

// Random rnd = new Random();
// Console.WriteLine("Например, задан массив:");
// int[,] arr = new int[rnd.Next(3, 10), rnd.Next(5, 10)];
// Console.WriteLine($"- с количеством строк: {arr.GetLength(0)}");
// Console.WriteLine($"- с количеством столбцов: {arr.GetLength(1)}");
// FillArrayRandom(arr);
// PrintArr(arr);
// Console.Write("Введите координаты искомого числа через запятую (строка, столбец): ");
// int[] coordinate = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
// int k = coordinate[0]-1;
// int l = coordinate[1]-1;

// if (k < 0 | k >= arr.GetLength(0) | l < 0 | l >= arr.GetLength(1))    // проверка условия
// {
//     Console.WriteLine($"arr[{k}, {l}] -> такого значения нет!");
// }
// else
// {
//     Console.WriteLine($"arr[{k}, {l}] -> {arr[k, l]}");
// }




// void FillArrayRandom(int[,] arr)    // создаем рандомный двумерный массив из целых чисел
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(0, 10);

//         }

//     }
// }

// void PrintArr(int[,] arry)  // метод вывода на печать массива
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j],2}");
//         }
//         Console.WriteLine();
//     }
// }