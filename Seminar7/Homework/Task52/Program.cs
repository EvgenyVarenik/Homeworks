// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] GetRandomMatrix(int rows, int columns, int LeftRange, int RightRange)
{
    int [,] matrix = new int [rows, columns];

    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(LeftRange,RightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)
{ 
    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            Console.Write (matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int  ROWS = 3;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int [,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);

void AverageNumbersInColumns (int [,] matrix)
{
    int count = 0;
    double sum = 0;
    for (int j=0; j < matrix.GetLength(1); j++)
    {
        for (int i=0; i < matrix.GetLength(0); i++)
        {
            sum += matrix [i,j];
            count++;
            
        }
        double average = sum / matrix.GetLength(0);
        Console.WriteLine($"{average:f2}");
        sum = 0;
    }    
}

AverageNumbersInColumns (array);