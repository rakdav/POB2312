//Console.WriteLine($"{Math.PI:F2}");
//Console.WriteLine($"{Math.E:F1}");
//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {n}");
//Console.WriteLine($"{1} {13} {49}");
//Console.WriteLine("7  15  100");
//Console.Write("Введите три числа:");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//Console.WriteLine($"{a}  {b}  {c}");
//1 
//Console.WriteLine(50);
//Console.WriteLine(10);
//2

//1.12
//a
//Console.WriteLine("50 10\n7 cm");
//б
/*
Console.Write("Введите две переменные:");
int t = int.Parse(Console.ReadLine());
int v = int.Parse(Console.ReadLine());
Console.WriteLine($"100 {t}\n1949 {v}");
*/
//в
//1.17
//a
//Console.Write("Введите x1:");
//double x1 = double.Parse(Console.ReadLine());
//Console.Write("Введите x2:");
//double x2 = double.Parse(Console.ReadLine());
//double res = Math.Sqrt(x1*x1+x2*x2);
//Console.WriteLine($"Результат={res:F2}");
//в
//Console.Write("Введите v0:");
//double v0 = double.Parse(Console.ReadLine());
//Console.Write("Введите t:");
//double t = double.Parse(Console.ReadLine());
//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//double s = v0 * t + (a * t * t) / 2;
//Console.WriteLine($"s={s:F2}");
//1.22a
try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double y = 7 * x * x - 3 * x + 6;
    Console.WriteLine($"y={y:F2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

