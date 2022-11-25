// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Давайте выясним какое число больше..");

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max= num1;

if( max < num2)
{
    max = num2;    
}

if (num2 < num3)
{
    max = num3;
}

Console.Write("Наибольшим является: ");
Console.WriteLine(max);


