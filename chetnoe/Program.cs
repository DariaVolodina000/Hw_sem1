// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Давайте проверим число на четность. ");
Console.WriteLine("Введите целое цисло: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0 ) // если остаток после деления числа на 2 == 0, оно четное. В противном случае - нечетное
{
    Console.WriteLine("Введенное число - четное ");
}
else
{
      Console.WriteLine("Введенное число - нечетное ");
}
