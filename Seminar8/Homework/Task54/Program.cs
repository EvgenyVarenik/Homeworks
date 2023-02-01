// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] GetRandomMatrix(int rows, int columns, int LeftRange, int RightRange)
{
    int [,] matrix = new int [rows, columns];

    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(LeftRange, RightRange + 1);
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

const int ROWS = 3;
const int COLUMNS = 3;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 9;

int [,] matrix = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(matrix);

void ChangeMatrix (int [,] matrix)
{
    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine();
ChangeMatrix(matrix);
PrintMatrix(matrix);

