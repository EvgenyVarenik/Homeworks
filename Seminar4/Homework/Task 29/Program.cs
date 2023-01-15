// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

// int ReadNumber (string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

int[] FillNewArray(int size)
{
    int[] array = new int[size];
         
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int[] array1 = FillNewArray(8);
Console.WriteLine(string.Join (", ", array1));