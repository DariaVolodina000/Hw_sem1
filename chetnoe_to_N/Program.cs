
Console.WriteLine("Введите целое цисло: ");

        int num = Convert.ToInt32(Console.ReadLine());
        int num2 = 1;
       
        if (num2 == 1)

        {
         num2 += 1;
        }

        while (num2 <= num)

        {
            Console.Write("Все четные числа до вашего: ");
            Console.WriteLine(num2);
            num2 += 2;
        }