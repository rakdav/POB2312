//int i = 5;
//while (i > 0)
//{
//    Console.WriteLine(i--);
//}
//Console.Write("Введите число n:");
//int n = int.Parse(Console.ReadLine());
//long Fact = 1;
//int i = 1;
//while (i <= n)
//{
//    Fact *= i++;
//}
//Console.WriteLine($"Факториал {n}={Fact}");
//int a;
//double Sum = 0;
//int CountGreat10 = 0;
//int CountLess10 = 0;
//double avg = 0;
//int min=int.MaxValue;
//int max=int.MinValue;
//int i = 1;
//while (i <= 10)
//{
//    Console.Write($"Введите {i} число:");
//    a = int.Parse(Console.ReadLine());
//    Sum += a;
//    if (a > 10) CountGreat10++;
//    if (a < 10) CountLess10++;
//    if (a > max) max = a;
//    if (a < min) min = a;
//    i++;
//}
//Console.WriteLine("Sum="+Sum);
//Console.WriteLine("Count>10="+CountGreat10);
//Console.WriteLine("Count<10=" + CountLess10);
//Console.WriteLine("min="+min);
//Console.WriteLine("max="+max);
//Console.WriteLine($"avg={Sum/10}");
//do
//{
//    int n;
//    do
//    {
//        Console.Write("Введите положительное число:");
//        n = int.Parse(Console.ReadLine());
//        //if(n<=0) Console.WriteLine("Введите положительное число");
//    }
//    while (n <= 0);
//    int Sum = 0;
//    int i = 1;
//    do
//    {
//        Sum += i++;
//    }
//    while (i <= n);
//    Console.WriteLine("Sum=" + Sum);
//    Console.Write("Введите y/n:");
//    char answer = char.Parse(Console.ReadLine());
//    if (answer == 'y') break;
//}
//while (true);
//int S = 0;
//int i = 1;
//Random random = new Random();
//while (i <= 50)
//{
//    int a=random.Next(1, 50);
//    if (a % 2 != 0) continue;
//    Console.Write(a+" ");
//    S += a;
//    i++;
//}
//Console.WriteLine(S);

//2
//int a;
//int b;
//do
//{
//    Console.WriteLine("Введите два различных числа:");
//    a = int.Parse(Console.ReadLine());
//    b = int.Parse(Console.ReadLine());
//}
//while (a == b);
//if (a < b)
//{
//    int i = a;
//    while (i <= b)
//    {
//        Console.Write(i+" ");
//        i++;
//    }
//}
//else
//{
//    int i = a;
//    while (i >= b)
//    {
//        Console.Write(i+" ");
//        i--;
//    }
//}
//3
//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//while (i <= n)
//{
//    if (i % 2 != 0) Console.Write(i+" ");
//    i++;
//}
//4
Console.Write("Введите число:");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= 10)
{
    Console.Write($"{n}*{i}={n*i} ");
    i++;
}

