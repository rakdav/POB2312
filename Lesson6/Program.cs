// See https://aka.ms/new-console-template for more information

//using System.Diagnostics;

//double a= new Random().NextDouble()*100000+30000;
//Console.WriteLine((int)Math.Round(a));
//string myPerson = "Andrey\nDubinin";
//Console.WriteLine(myPerson);
//string myString = "78";
//int i = int.Parse(myString);
//Console.WriteLine(i+" "+i.GetType());
//Console.WriteLine(myString+" "+myString.GetType());

//byte b = 200;
//string s = b.ToString();
//Console.WriteLine(s);
//sbyte sb = (sbyte)b;
//Console.WriteLine(sb);

//char ch = (char)b;
//Console.WriteLine(ch);

Console.Write("Введите число n:");
int n = int.Parse(Console.ReadLine());
int a = n / 1000;
int b = n % 1000 / 100;
int c = n % 100 / 10;
int d = n % 10;
Console.WriteLine($"Сумма цифр:{a+b+c+d}");
Console.WriteLine($"Произведение цифр:{a*b*c*d}");

