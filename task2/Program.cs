 //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int result, enterNumber;
            Console.Write("Введите любое число: ");
            enterNumber = Convert.ToInt32(Console.ReadLine());
            result = 0;
            while (enterNumber != 0)
            {
                result += enterNumber % 10;
                enterNumber /= 10;
            }

            Console.WriteLine($"Сумма цифр в числе = {result}");