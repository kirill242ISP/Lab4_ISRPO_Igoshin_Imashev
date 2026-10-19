// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Привет!");
//         Console.WriteLine("ФИО: Имашев Наиль, Игошин Кирилл");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Привет!");
//         Console.WriteLine("ФИО: Имашев Наиль Игошин Кирилл");
//         Console.WriteLine("Группа: ИСП-242");
//         Console.WriteLine("Дата и время: " + DateTime.Now);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Привет!");
//         Console.WriteLine("ФИО: Игошин Кирилл Имашев Наиль");
//         Console.WriteLine("Группа: ИСП-242");
//         Console.WriteLine("Дата и время: " + DateTime.Now);

//         Console.WriteLine("\nМеню:");
//         Console.WriteLine("1 - Показать ФИО");
//         Console.WriteLine("2 - Показать группу");
//         Console.WriteLine("3 - Показать дату");
//         Console.WriteLine("4 - Выход");
//     }
// }
class Program
{
    static void Main()
    {
        Console.WriteLine("Привет!");
        Console.WriteLine("ФИО: Игошин Имашев");
        Console.WriteLine("Группа: ИСП-242");
        Console.WriteLine("Дата и время: " + DateTime.Now);

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 - Показать ФИО");
            Console.WriteLine("2 - Показать группу");
            Console.WriteLine("3 - Показать дату");
            Console.WriteLine("4 - Выход");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("ФИО: Игошин Кирилл Имашев Наиль");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Группа: ИСП-242");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Дата и время: " + DateTime.Now);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Выход");
            }
            else
            {
                Console.WriteLine("Такого варианта нет. Попробуйте снова.");
            }
        }
    }
}