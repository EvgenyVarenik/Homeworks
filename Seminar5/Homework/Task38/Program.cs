// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] GetRandomArray (int size, int LeftRange, int RightRange)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange);
    }
    return array;
}
Console.WriteLine("Введите кол-во эл-тов массива: ");
int Size = Convert.ToInt32(Console.ReadLine());

int [] massive = GetRandomArray(Math.Abs(Size), 0, 100);
Console.WriteLine(string.Join(", ", massive));

int MaxNumber (int [] massive)
{
    int Max = massive[0];
    for (int i = 1; i < massive.Length; i++)
    {
        if (massive[i] > Max)
        {
            Max = massive[i];
        }
    }
    return Max;
}

int MinNumber (int [] massive)
{
    int Min = massive[0];
    for (int i = 1; i < massive.Length; i++)
    {
        if (massive[i] < Min)
        {
            Min = massive[i];
        }
    }
    return Min;
}

int MaxArray = MaxNumber(massive);
int MinArray = MinNumber(massive);
int Diff = MaxArray - MinArray;

Console.WriteLine(Diff);
