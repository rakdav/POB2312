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

//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите x:");
//double y = double.Parse(Console.ReadLine());
//if(x>y) Console.WriteLine($"наибольшее {x}");
//else if(x<y) Console.WriteLine($"наибольшее {y}");
//     else Console.WriteLine("равны");

//string res=(x>y)?$"наибольшее {x}":
//    (x<y)?$"наибольшее {y}":"равны";
//Console.WriteLine(res);

//5
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите z:");
//double z = double.Parse(Console.ReadLine());
//if (x > y && y > z) Console.WriteLine(z);
//else if (y > z && z > x) Console.WriteLine(x);
//     else if (z > x && x > y) Console.WriteLine(y);
//          else if (z>y&&y>x) Console.WriteLine(x);

//double min = Math.Min(x, y);
//min = Math.Min(min, z);

//Console.Write("Введите рост:");
//int x= int.Parse(Console.ReadLine());
//Console.Write("Введите вес:");
//int y = int.Parse(Console.ReadLine());
//if(x-100<y) Console.WriteLine("лишний вес");
//else if(x - 100 > y) Console.WriteLine("недостаточный вес");
//else Console.WriteLine("нормальный вес");

//6
//Console.Write("Введите номер месяца:");
//byte m = byte.Parse(Console.ReadLine());
//if(m==12||m==1||m==2) Console.WriteLine("Зима");
//else if(m==3||m==4||m==5) Console.WriteLine("Весна");
//     else if (m == 6 || m == 7 || m == 8)                   Console.WriteLine("Лето");
//          else if(m == 9 || m == 10 || m == 11)           Console.WriteLine("Осень");
//               else Console.WriteLine("Такого месяца нет");

//7
Console.WriteLine("Введите площадь окружность");
double s1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите площадь квадрата");
double s2 = double.Parse(Console.ReadLine());
double R = Math.Sqrt(s1/Math.PI);//радиус окружности
double a = Math.Sqrt(s2);//сторона квадрата
if(2*R<=a) Console.WriteLine("Круг входит в квадрат");
else Console.WriteLine("Круг не входит в квадрат");
if(2*R>=a*Math.Sqrt(2)) Console.WriteLine("Квадрат входит в круг");
else Console.WriteLine("Квадрат не входит в круг");








