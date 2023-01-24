// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// 5 9 2 3
// ​8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

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
const int COLUMNS = 4;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

int [,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);


Console.Write($"Введите номер строки: ");
int RowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите номер столбца: ");
int ColumnNumber = Convert.ToInt32(Console.ReadLine());

void ArrayNumber (int [,]matrix)
{
    if (RowNumber < array.GetLength(0) && ColumnNumber < array.GetLength(1))
    {
        int i = RowNumber;
        int j = ColumnNumber;
        Console.WriteLine(array[i,j]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

ArrayNumber(array);