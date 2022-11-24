// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Давайте выясним какое число больше..");

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if( num1 < num2)
{
    max= num2;
}
else
{
    max= num1;
}
Console.Write("Наибольшим является: ");
Console.WriteLine(max);