//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int [,] SortMatrix(int[,] matrix)
{
    int tempValue = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(1)-1; k++)
           {
            if (matrix[i,k] < matrix [i,k+1])
            {
                tempValue = matrix[i,k];
                matrix[i,k] = matrix [i,k+1];
                matrix [i,k+1] = tempValue;
            }
           }
        }
    }
    return matrix;
}


//Клиентский код
int[,] myMatrix = GiveMatrix(10, 8);
FillMatrix(myMatrix);
System.Console.WriteLine("Old matrix:");
System.Console.WriteLine(PrintMatrix(myMatrix));
SortMatrix(myMatrix);
System.Console.WriteLine("Sorted matrix:");
System.Console.WriteLine(PrintMatrix(myMatrix));
