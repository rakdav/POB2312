//Задача 2.8
//Console.Write("Введите количество дней с начала года:");
//int k = int.Parse(Console.ReadLine());
//Console.Write("Введите номер дня недели 1 января:");
//int d = int.Parse(Console.ReadLine());
//Console.WriteLine($"Номер дня недели:{(k+d-1)%7}");
//k = 90;

//Контсанты и литералы
//const float g = 9.8f;
//const double PI = 3.5;
//const decimal d = 5.8m;
////g = 90;

//double m = 86;
//Console.WriteLine($"F={m * g}");

//const float K = 273.15f;
//const int FAR = 32;
//Console.Write("Введите температуру в цельсиях:");
//double t = double.Parse(Console.ReadLine());
//double T = t + K;
//Console.WriteLine($"{t} C={T:F2} К");
//double F = (t * 9 / 5) + FAR;
//Console.WriteLine($"{t} C={F:F2} F");

//const double BR = 1.0e-5;
//const double RS = 7.50062e-3;
//const double ATM = 1.01e-5;
//Console.Write("Введите давление в Паскалях:");
//double P = double.Parse(Console.ReadLine());
//Console.WriteLine($"{P} Па={P*BR} Бар");
//Console.WriteLine($"{P} Па={P*RS} мм.рт.ст");
//Console.WriteLine($"{P} Па={P*ATM} атм");

Console.Write("Введите двухзначное число:");
int n = int.Parse(Console.ReadLine());
int a = n % 10;
Console.WriteLine($"Число единиц:{a}");
int b = n / 10;
Console.WriteLine($"Число десятков:{b}");
Console.WriteLine($"Сумма цифр:{a+b}");
Console.WriteLine($"Произведение цифр:{a * b}");
Console.WriteLine($"Число при перестановке {a*10+b}");