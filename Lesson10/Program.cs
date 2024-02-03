//Console.Title = "Тема 10";
//Console.Write("Введите первое число:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Max(x,y));
//Console.WriteLine($"|{x}|={Math.Abs(x)} |{y}|={Math.Abs(y)}");
//Console.WriteLine(Math.Floor(x));
//Console.WriteLine($"{Math.Sqrt(x):F2}");
//Console.WriteLine(Math.Ceiling(x));
//Console.WriteLine(Math.Pow(x,y));
//Console.WriteLine(Math.Round(x));
//Console.WriteLine(Math.DivRem((int)x,(int)y));
//Console.WriteLine($"{Math.Sqrt(x*x+y*y):F2}");

//1
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double y = (x >= 0) ? x : -x;
//Console.WriteLine($"|{x}|={y}");

//2
//Console.Write("Введите x:");
//int x = int.Parse(Console.ReadLine());
//string res = (x % 2 == 0) ? "Четное" : "Нечетное";
//Console.WriteLine(res);

//3
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());

//if(x>0) Console.WriteLine("Положительное");
//else if(x<0) Console.WriteLine("Отрицательное");
//     else Console.WriteLine("Равно нулю");

//Console.WriteLine((x>0)? "Положительное":(x<0)? "Отрицательное": "Равно нулю");

//4
using System.Threading.Channels;

Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите x:");
double y = double.Parse(Console.ReadLine());
if(x>y) Console.WriteLine($"наибольшее {x}");
else if(x<y) Console.WriteLine($"наибольшее {y}");
     else Console.WriteLine("равны");

string res=(x>y)?$"наибольшее {x}":
    (x<y)?$"наибольшее {y}":"равны";
Console.WriteLine(res);