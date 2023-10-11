//x^2 - sin(x) = 0
using MVkyrsachDD.Graph;
using MVkyrsachDD.Method;
using MVkyrsachDD.Methods;
void Info()
{
    Console.WriteLine("Заданное уравнение x^2 - sin(x) = 0 \n" +
    "Выберите метод, которым хотите его решить: \n" +
    "1 - Метод Ньютона \n" +
    "2 - Метод Простых итераций \n" +
    "3 - Метод хорд \n" +
    "4 - Метод половинного деления \n" +
    "info - Повторно вывести информацию \n" +
    "graph - Нарисовать график функции \n" +
    "clear - Очистить консоль \n" +
    "exit - Выход из программы");
}
Info();
string? answer = Console.ReadLine();
while (answer != "exit")
{
    switch (answer)
    {
        case "1":
            new NewtonMethod(0.0001, 1, 15).Print();
            Console.WriteLine("____________________________");
            break;
        case "2":
            new SimpleIterMethod(0.0001, 3).Print();
            Console.WriteLine("____________________________");
            break;
        case "3":
            new HordMethod(0.0001, 1, 15).Print();
            Console.WriteLine("____________________________");
            break;
        case "4":
            new HalfDivided(0.0001, 0.0001, 5).Print();
            Console.WriteLine("____________________________");
            break;
        case "info":
            Info();
            break;
        case "graph":
            new Graphics().Draw();
            break;
        case "clear":
            Console.Clear();
            Info();
            break;
        default:
            Console.WriteLine("Неверный ввод данных");
            break;
    }
    answer = Console.ReadLine();
}
