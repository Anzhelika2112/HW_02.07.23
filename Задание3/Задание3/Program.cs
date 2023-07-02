//  Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] averageColumns = GetAverageColumns(array);
PrintArray1(averageColumns); 


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


double[] GetAverageColumns(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0; 
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j]; 
            result[j] = sum / arr.GetLength(1); 
        }
    }
    return result; 
}

void PrintArray1(double[] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]}; ");
    }
}