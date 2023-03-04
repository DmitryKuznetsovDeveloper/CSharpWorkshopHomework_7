// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Метод получения числа от пользователя
int InputUser(string message)
{
    Console.Write($"{message} => ");
    return Convert.ToInt32(Console.ReadLine());
}

// Метод создания двумерного массива
double[,] CreationMatrix(int row, int col)
{
    double[,] array = new double[row, col];
    return array;
}

// Метод заполнения массива псевдорандомными числами
double[,] FillMatrix(double[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(random.Next(-101, 101) / 10.0);
        }
    }
    return array;
}

// Метод вывода массива
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

// Обработка исключений
try
{
    int userRow = InputUser("Введите количество строк в двумерном массиве");
    int userCol = InputUser("Введите количество колонок в двумерном массиве");
    double[,] userMatrix = CreationMatrix(userRow, userCol);
    PrintMatrix(FillMatrix(userMatrix));
}
catch (Exception)
{
    Console.WriteLine("Это не число =(");
}
