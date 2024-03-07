Console.Write("Введите максимальное количество задач:");
int n = int.Parse(Console.ReadLine());
string[,] mas = new string[n, 4];
int count = 0;//количество задач
int number;
bool start = true;
do
{
    Console.Clear();
    Console.WriteLine($"Всего задач {n}, свободных {n-count}");
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Добавить задачу\n" +
        "2. Удалить задачу\n" +
        "3. Перезаписать задачу\n" +
        "4. Вывести список задач\n" +
        "5. Выход");
    try
    {
        Console.Write("Введите действие:");
        number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                {
                    if (count < n)
                    {
                        Console.Write("Введите название задачи:");
                        string name = Console.ReadLine();
                        Console.Write("Введите дату задачи:");
                        string date = Console.ReadLine();
                        Console.Write("Введите время задачи:");
                        string time = Console.ReadLine();
                        Console.Write("Введите приоритет задачи:");
                        string priority = Console.ReadLine();
                        mas[count, 0] = name;
                        mas[count, 1] = date;
                        mas[count, 2] = time;
                        mas[count, 3] = priority;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Нет свободных мест");
                        Console.ReadKey();
                    }
                }
                break;
            case 2:
                {
                    Console.Write("Введите номер задачи для удаления:");
                    int m = int.Parse(Console.ReadLine());
                    for (int i = 0; i < mas.GetLength(1); i++)
                    {
                        mas[m - 1, i] = "";
                    }
                }
                break;
            case 3:
                {
                    Console.Write("Введите номер задачи для изменения:");
                    int m = int.Parse(Console.ReadLine());
                    Console.Write("Введите название задачи:");
                    string name = Console.ReadLine();
                    Console.Write("Введите дату задачи:");
                    string date = Console.ReadLine();
                    Console.Write("Введите время задачи:");
                    string time = Console.ReadLine();
                    Console.Write("Введите приоритет задачи:");
                    string priority = Console.ReadLine();
                    mas[m, 0] = name;
                    mas[m, 1] = date;
                    mas[m, 2] = time;
                    mas[m, 3] = priority;
                }
                break;
            case 4:
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}" +
                            $"{mas[i, 2],-10}{mas[i, 3],5}");
                    }
                    Console.ReadKey();
                }
                break;
            case 5:
                start = false;
                break;
            default:
                Console.WriteLine("Введите правильное действие");
                Console.ReadKey();
                break;
        }
    }
    catch
    {

    }
}
while (start);
