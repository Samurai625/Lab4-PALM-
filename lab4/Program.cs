using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Оберіть дію або 0 для виходу:");
            Console.WriteLine("1 — string += (додавання в кінець)");
            Console.WriteLine("2 — string + (додавання на початок)");
            Console.WriteLine("3 — StringBuilder.Append (додавання в кінець)");
            Console.WriteLine("4 — StringBuilder.Insert (додавання на початок)");
            Console.WriteLine("5 — Обробка рядка (букви вперед, цифри назад)");
            Console.WriteLine("0 — Вихід");

            Console.Write("Ваш вибір (0-5): ");
            string choice = Console.ReadLine()!;

            if (choice == "0") break;

            if (!Regex.IsMatch(choice, @"^\d+$")|| !int.TryParse(choice, out int version) || version < 0 || version > 5 || version == -0)
            {
                Console.WriteLine("Некоректний вибір! Спробуйте ще раз.");
                continue;
            }

            // Якщо обрана задача 1–4, запитуємо n
            int n = 0;
            if (version >= 1 && version <= 4)
            {
                Console.Write("Введіть натуральне число n: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Некоректне число!");
                    continue;
                }
            }

            string result = "";
            Stopwatch sw = Stopwatch.StartNew();

            switch (version)
            {
                case 1:
                    result = Version1.StringPlusEqual(n);
                    break;
                case 2:
                    result = Version2.StringPlusFront(n);
                    break;
                case 3:
                    result = Version3.StringBuilderAppend(n);
                    break;
                case 4:
                    result = Version4.StringBuilderInsert(n);
                    break;
                case 5:
                    sw.Stop();  // Не потрібно вимірювати час тут
                    StringTask.Run();  // Просто запускаємо завдання
                    break;
            }

            if (version >= 1 && version <= 4)
            {
                sw.Stop();
                Output.PrintResult(result, sw.ElapsedMilliseconds);
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("Програма завершена.");
    }
}
