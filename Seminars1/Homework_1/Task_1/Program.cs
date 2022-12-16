// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
   Console.WriteLine($"max {number2}");
   Console.WriteLine($"min {number1}"); 
}
else if (number1 > number2)
{
   Console.WriteLine($"max {number1}"); 
   Console.WriteLine($"min {number2}");
}
else
{
    Console.WriteLine($"{number1} = {number2}");
}