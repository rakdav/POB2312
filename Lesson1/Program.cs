Console.Write("Введите первое число:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
double b = double.Parse(Console.ReadLine());
double s = a + b;

//Console.WriteLine(a + "+" + b + "=" + s);
//Console.WriteLine("Cумма равна:" + s);

Console.WriteLine($"{a}+{b}={s}");
Console.WriteLine($"Cумма равна:{s}");

//Console.WriteLine("{0}+{1}={2}", a, b, s);
//Console.WriteLine("Cумма равна:{0}", s);