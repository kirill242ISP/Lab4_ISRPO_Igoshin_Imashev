// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Привет!");
//         Console.WriteLine("ФИО: Имашев Наиль, Игошин Кирилл");
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Привет!");
//         Console.WriteLine("ФИО: Имашев Наиль Игошин Кирилл");
//         Console.WriteLine("Группа: ИСРПО-21-1");
//         Console.WriteLine("Дата и время: " + DateTime.Now);
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Привет!");
//         Console.WriteLine("ФИО: Игошин Кирилл Имашев Наиль");
//         Console.WriteLine("Группа: ИСП-242");
//         Console.WriteLine("Дата и время: " + DateTime.Now);

//         Console.WriteLine("\nМеню:");
//         Console.WriteLine("1 — Показать ФИО");
//         Console.WriteLine("2 — Показать группу");
//         Console.WriteLine("3 — Показать дату");
//         Console.WriteLine("4 — Выход");
//     }
// }
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привет!");
        Console.WriteLine("ФИО: Иванов Иван Иванович");
        Console.WriteLine("Группа: ИСРПО-21-1");
        Console.WriteLine("Дата и время: " + DateTime.Now);

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату");
            Console.WriteLine("4 — Выход");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("ФИО: Иванов Иван Иванович");
                    break;
                case "2":
                    Console.WriteLine("Группа: ИСРПО-21-1");
                    break;
                case "3":
                    Console.WriteLine("Дата и время: " + DateTime.Now);
                    break;
                case "4":
                    Console.WriteLine("Выход...");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}