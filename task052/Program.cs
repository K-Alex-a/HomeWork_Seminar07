// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Random rnd = new Random();
Console.WriteLine("Например, задан массив:");
int m = rnd.Next(2, 5);
Console.WriteLine($"- с количеством строк: {m}");
int n = rnd.Next(2, 5);
Console.WriteLine($"- с количеством столбцов: {n}");

int[,] arr = new int[m, n];

FillArrayRandom(arr);
PrintArr(arr);
Console.Write("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < arr.GetLength(1); j++)  // условие при котором будет просчитываться среднее арифметическое
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i, j];  // складываем значения столбца, т.к. проводим цикл под значением cтрок (0=m)
    }
    sum = Math.Round((sum / arr.GetLength(0)), 1);  // делим полученную сумму всех чисел столбца на кол-во этих чисел с округлением результата до десятых
    Console.Write($" {sum}; ");
}
Console.Write("\b\b."); // меняем последнюю ; на .



void FillArrayRandom(int[,] arr)    // создаем рандомный двумерный массив из целых чисел
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(0, 10);
            }
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



