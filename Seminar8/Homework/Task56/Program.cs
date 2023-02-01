// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int SumRowElements(int[,] matrix, int i)
{
  int sumRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumRow += matrix[i,j];
  }
  return sumRow;
}

int minSumRow = 0;
int sumRow = SumRowElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumRow = SumRowElements(matrix, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}

Console.WriteLine($"{minSumRow} - строка с наименьшей суммой элементов.");
