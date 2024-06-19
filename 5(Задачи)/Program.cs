using System;

class Program
{
    static void Main()
    {
        // Запрос числа
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        // Преобразование введенного значения в число
        if (int.TryParse(input, out int number))
        {
            // Проверка, находится ли число в диапазоне от 5 до 10 включительно
            if (number >= 5 && number <= 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число.");
            }
        }
        else
        {
            // Сообщение об ошибке при некорректном вводе
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }
    }
}
