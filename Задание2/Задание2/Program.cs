// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите позицию строки: ");
int rowsPozition = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите позицию столбца: ");
int columnsPozition = int.Parse(Console.ReadLine() ?? "");


Console.WriteLine();
ElementPozition(array, rowsPozition, columnsPozition, rows, columns); 




int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ElementPozition(int[,] arr, int rowsPoz, int columnsPoz, int rows1, int columns1)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (rowsPoz < 1 || columnsPoz < 1)
            {
                Console.Write("Позиции строк не могут быть отрицательными");
            }
            else if (rowsPoz <= rows1 + 1 && columnsPoz <= columns1 + 1)
            {
                Console.Write($"Значение элемента = {arr[rowsPoz - 1, columnsPoz - 1]}");
            }
            else Console.Write("Такого элемента в массиве нет");
            break;
        }
        break;
    }

}