//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов. Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
int [,] GiveMatrix(int row, int col)
{
    return new int[row, col];
}

int [,] FillMatrix(int[,] matrix)
{
    int minValue = 1;
    int maxValue = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;
}

string PrintMatrix(int[,] matrix)
{
    string result = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += $"{matrix[i,j], 2}";
        }
        result +="\n";
    }
    return result;
}

int[] CountLine(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        array[i] = sum;
    }
    return array;
}

int MinSumLine(int[] array)
{
    int min = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if (array[min] > array[i]) min = i;
    }
    return min;
}

//Клиентский код
int sizeMatr = 5;
int[,] myMatrix = GiveMatrix(sizeMatr, sizeMatr);
FillMatrix(myMatrix);
System.Console.WriteLine(PrintMatrix(myMatrix));
System.Console.WriteLine($"В этой строке мин сумма элементов: {MinSumLine(CountLine(myMatrix))+1}");
