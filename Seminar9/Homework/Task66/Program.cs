// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write($"Число M = ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write($"Число N = ");
int N = Convert.ToInt32(Console.ReadLine()); 

int SumNum (int a, int b)
{
    if (a == b+1) return 0;
    return (a + SumNum(a+1,b));
    
}


Console.WriteLine($"{SumNum(M,N)}");