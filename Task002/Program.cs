// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int InputUser(string message)
{
    Console.Write($"{message} => ");
    return Convert.ToInt32(Console.ReadLine());
}

// Метод создания двумерного массива
int[,] CreationMatrix(int row, int col)
{
    int[,] array = new int[row, col];
    return array;
}

// Метод заполнения массива псевдорандомными числами
int[,] FillMatrix(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-101, 101);
        }
    }
    return array;
}

// Метод вывода массива
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

// Метод поиска элемента массива по позиции
int SearchElementPosition(int[,] array, int row, int col)
{
    return array[row, col];
}

// Обработка исключений
try
{
    int userRow = InputUser("Введите количество строк в двумерном массиве");
    int userCol = InputUser("Введите количество колонок в двумерном массиве");
    int[,] userMatrix = CreationMatrix(userRow, userCol);
    PrintMatrix(FillMatrix(userMatrix));
    int searchRow = InputUser("Введите позицию строки");
    int searchCol = InputUser("Введите позицию колонки");
    Console.WriteLine($"Элемент с позицией [{searchRow},{searchCol}] = {SearchElementPosition(userMatrix, searchRow, searchCol)}");
}
catch (FormatException)
{
    Console.WriteLine("Вы ввели не число =(");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Такого элемента в массиве нет =(");
}

