// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int LeftRange = 100;
int RightRange = 1000;
int [] massive = GetRandomArray(Math.Abs(Size), LeftRange, RightRange);
Console.WriteLine(string.Join(", ", massive));

int count = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i]%2 == 0) count++;
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");