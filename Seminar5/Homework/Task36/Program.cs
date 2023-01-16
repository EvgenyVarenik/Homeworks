// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int [] massive = GetRandomArray(Math.Abs(Size), -100, 100);
Console.WriteLine(string.Join(", ", massive));

int count = 0;
for (int i = 1; i < massive.Length; i+=2)
{
    count+=massive[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях= {count}");