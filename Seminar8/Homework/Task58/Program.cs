// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

const int ROWS = 2;
const int COLUMNS = 2;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 9;

int [,] matrix = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(matrix);
Console.WriteLine();
int [,] matrix2 = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(matrix2);
Console.WriteLine();
int [,] resultMatrix = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);


void MultiplyMatrix (int [,] matrix, int [,] matrix2, int [,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[i,k] * matrix2[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}

MultiplyMatrix(matrix, matrix2, resultMatrix);
PrintMatrix(resultMatrix);