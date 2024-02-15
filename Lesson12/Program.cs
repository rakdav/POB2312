//Console.Write("Введите номер дня недели:");
//byte n = byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1: Console.WriteLine("Понедельник"); break;
//    case 2: Console.WriteLine("Вторник"); break;
//    case 3: Console.WriteLine("Среда"); break;
//    case 4: Console.WriteLine("Четверг"); break;
//    case 5: Console.WriteLine("Пятница"); break;
//    case 6: Console.WriteLine("Суббота"); break;
//    case 7: Console.WriteLine("Воскресенье"); break;
//    default: Console.WriteLine("Такого дня недели нет"); break;
//}

//Console.Write("Введите номер месяца:");
//byte n = byte.Parse(Console.ReadLine());
//Console.Write("Введите температуру:");
//double t = double.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:case 2:case 12: {
//            Console.WriteLine("Зима");
//        }; break;
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
//    default: Console.WriteLine("Такого месяца нет"); break;
//}

//Random random = new Random();
//Console.WriteLine("Выберите какие числа сгенерировать:\n" +
//    "1 - целые\n" +
//    "2 - с плавающей точкой\n" +
//    "3 - числа в диапазоне\n");
//Console.Write("Введите число:");
//byte n = byte.Parse(Console.ReadLine());
//switch(n)
//{
//    case 1:
//        {
//            Console.Write("Введите максимальное значение:");
//            int max = int.Parse(Console.ReadLine());
//            Console.WriteLine(random.Next(max)+1);
//        }
//        break;
//    case 2:
//        {
//            Console.Write("Введите максимальное значение:");
//            int max = int.Parse(Console.ReadLine());
//            Console.WriteLine($"{random.NextDouble()*max:F2}");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Введите минимальное значение:");
//            int min = int.Parse(Console.ReadLine());
//            Console.Write("Введите максимальное значение:");
//            int max = int.Parse(Console.ReadLine());
//            if (max < min)
//            {
//                int temp = max;
//                max = min;
//                min = temp;
//            }
//            Console.WriteLine($"{random.Next(min,max)}");
//        }
//        break;
//    default:
//        Console.WriteLine("Такого варианта нет");break;
//}
//Console.Write("Введите камень, ножницы или бумага:");
//string user = Console.ReadLine();
//Random random = new Random();
//string pc="";
//switch (random.Next(1, 4))
//{
//    case 1:pc = "камень";break;
//    case 2: pc = "ножницы"; break;
//    case 3: pc = "бумага"; break;
//}
////if(user==pc) Console.WriteLine("Ничья");
////else if(user=="ножницы"&&pc=="бумага") Console.WriteLine("Вы выиграл и");
//Console.WriteLine(user+" "+pc);
//Random random = new Random();
//int sum = 0;
////1
//int n = random.Next(100);
//int m = random.Next(100);
//int var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n + m; Console.WriteLine($"{n}+{m}=");}break;
//    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//}
//Console.Write("Введите ответ:");
//int res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
////2
//n = random.Next(100);
//m = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n + m; Console.WriteLine($"{n}+{m}="); } break;
//    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//}
//Console.Write("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
////3
//n = random.Next(100);
//m = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n + m; Console.WriteLine($"{n}+{m}="); } break;
//    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//}
//Console.Write("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
////4
//n = random.Next(100);
//m = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n + m; Console.WriteLine($"{n}+{m}="); } break;
//    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//}
//Console.Write("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
////5
//n = random.Next(100);
//m = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n + m; Console.WriteLine($"{n}+{m}="); } break;
//    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//}
//Console.Write("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;

//Console.WriteLine($"Ваш результат:{sum}");
//switch (sum)
//{
//    case 0: case 1:
//        Console.WriteLine("Единица.Вы больны?");break;
//    case 2:
//        Console.WriteLine("Два"); break;
//    case 3:
//        Console.WriteLine("Три"); break;
//    case 4:
//        Console.WriteLine("Четыре"); break;
//    case 5:
//        Console.WriteLine("Пять"); break;
//}
//Console.Write("Введите количество месяцев прошедших с начала 1990 года:");
//int n = int.Parse(Console.ReadLine());
//switch (n % 12 + 1)
//{
//    case 1: Console.WriteLine("Январь");break;
//    case 2: Console.WriteLine("Январь"); break;
//    case 3: Console.WriteLine("Январь"); break;
//    case 4: Console.WriteLine("Январь"); break;
//    case 5: Console.WriteLine("Январь"); break;
//    case 6: Console.WriteLine("Январь"); break;
//    case 7: Console.WriteLine("Январь"); break;
//    case 8: Console.WriteLine("Январь"); break;
//    case 9: Console.WriteLine("Январь"); break;
//    case 10: Console.WriteLine("Январь"); break;
//    case 11: Console.WriteLine("Январь"); break;
//    case 12: Console.WriteLine("Январь"); break;
//}

//Console.Write("Введите сумму:");
//int rub = int.Parse(Console.ReadLine());
//if(rub%100>=11&&rub%100<=14) Console.WriteLine($"{rub} рублей");
//else
//switch (rub % 10)
//{
//    case 1:
//        Console.WriteLine($"{rub} рубль");break;
//    case 2: case 3: case 4: Console.WriteLine($"{rub} рубля"); break;
////    default: Console.WriteLine($"{rub} рублей"); break;
//}
int a;
double Sum = 0;
int CountGreat10 = 0;
int CountLess10 = 0;
double avg = 0;
int min;
int max;
Console.Write("Введите 1 число:");
a= int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (a < 10) ? CountLess10++ : CountLess10;
min = a;
max = a;

Console.Write("Введите 2 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (a < 10) ? CountLess10++ : CountLess10;
if(a<min) min = a;
if(a>max) max= a;

Console.Write("Введите 3 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (a < 10) ? CountLess10++ : CountLess10;
if (a < min) min = a;
if (a > max) max = a;

Console.Write("Введите 4 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (a < 10) ? CountLess10++ : CountLess10;
if (a < min) min = a;
if (a > max) max = a;

Console.WriteLine("Sum="+Sum);
Console.WriteLine(">10="+CountGreat10);
Console.WriteLine("<=10"+CountLess10);
Console.WriteLine("AVG="+(Sum/4));
Console.WriteLine(min);
Console.WriteLine(max);