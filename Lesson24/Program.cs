//namespace Application
//{
//    class Program
//    {
//        static void Main ( string[] args )
//        {
//            Console.Write("Введите a:");
//            double a = double.Parse(Console.ReadLine());
//            Console.Write("Введите b:");
//            double b = double.Parse(Console.ReadLine());
//            Console.Write("Введите d:");
//            double d = double.Parse(Console.ReadLine());
//            double c = gipothenus(a, b);
//            double e = gipothenus(c, d);
//            Console.WriteLine($"P={a + b + d + e:F2}");
//        }
//        static double gipothenus ( double x, double y )
//        {
//            return Math.Sqrt(x * x + y * y);
//        }
//    }
//}

//double x = ( Math.Sqrt(6) + 6 ) / 2 + 
//           ( Math.Sqrt(13) + 13 ) / 2 + 
//           ( Math.Sqrt(21) + 21 ) / 2;
//Console.WriteLine($"{x:F2}");
//x = Func(6) - Func(13) * Func(21);
//Console.WriteLine($"{x:F2}");
//double Func(int y)
//{
//    return ( Math.Sqrt(y) + y ) / 2;
//}

//Console.Write("Введите a:");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//int b = int.Parse(Console.ReadLine());
//int z = Max(a, 2 * b) * Max(2 * a - b, b);
//Console.WriteLine(z);
//Console.WriteLine(sign(a)+sign(b));
//int Max(int x,int y)
//{
//    if (x > y) return x;
//    else if(x<y) return y;
//    return x;
//}
//int sign(double a)
//{
//    if (a < 0) return -1;
//    else if (a > 0) return 1;
//    return 0;
//}

//double gipothenus ( double x, double y )
//{
//    return Math.Sqrt(x * x + y * y);
//}

//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите d:");
//double d = double.Parse(Console.ReadLine());
//double c = gipothenus(a, b);
//double e= gipothenus(c, d);
//Console.WriteLine($"P={a+b+d+e:F2}");

//for (int i = 100; i < 1000; i++)
//{
//    if (IsSimple(i) == true) Console.Write(i+" ");
//}

//bool IsSimple(int x)
//{
//    int k = 0;
//    for(int i = 2; i < x; i++)
//    {
//        if (x % i == 0) k++;
//    }
//    if (k == 0) return true;
//    return false;
//}

//long Fact ( int x )
//{
//    long f = 1;
//    for (int i = 1; i <= x; i++) f *= i;
//    return f;
//}
//double y = ( 2.0 * Fact(5) + 3 * Fact(8) ) / (Fact(6)+Fact(4));
//Console.WriteLine(y.ToString("F2"));

//рамка
//void Draw ()
//{
//	for (int k = 0; k < Console.WindowHeight; k++)
//	{
//		if (k == 0 || k == Console.WindowHeight - 1)
//		{
//			for (int i = 0; i < Console.WindowWidth; i++)
//			{
//				Console.Write("*");
//			}
//			Console.WriteLine();
//		}
//		else
//		{
//			for (int i = 0; i < Console.WindowWidth; i++)
//			{
//				if (i == 0 || i == Console.WindowWidth - 1) Console.Write("*");
//				else Console.Write(" ");
//			}
//			Console.WriteLine();
//		}
//	}
//}
//Draw();
//double Avg ( int[] mas )
//{
//    double s = 0;
//	foreach (var item in mas) s += item;
//	return s / mas.Length;
//}
//Random random = new Random();
//int[] mas = new int[random.Next(10,20)];
//for (int i = 0; i < mas.Length; i++)
//{
//	mas[i] = random.Next(100);
//	Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Console.WriteLine($"{Avg(mas):F2}");

//string Reverse(string str )
//{
//    string res = "";
//    for(int i = str.Length - 1; i >= 0; i--) res += str[i];
//    return res;
//}
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//Console.WriteLine(Reverse(str));

//bool IsAnogram(string str1,string str2)
//{
//    string withOutRepeat = "";
//    int AddStr ( string str )
//    {

//        for (int i = 0; i < str.Length; i++)
//        {
//            if (!withOutRepeat.Contains(str[i])) withOutRepeat += str[i];
//        }
//        return withOutRepeat.Length;
//    }
//    int l1 = AddStr(str1);
//    int l2 = AddStr(str2);
//    if (l1 == l2) return true;
//    return false;
//}
//Console.Write("Введите первую строку:");
//string str1 = Console.ReadLine();
//Console.Write("Введите вторую строку:");
//string str2 = Console.ReadLine();
//if (IsAnogram(str1, str2)) Console.WriteLine("Анограммы");
//else Console.WriteLine("Не анограммы");


//void Swap(ref int a,ref int b )//ref - передача по ссылке
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//int func ( in int x )//in - входной
//{
//    return 2 * x + 1;
//}
//void Add ( int x, int y, out int s )
//{
//    s = x + y;
//}
//int x = 7, y = 9;
//Console.WriteLine(x+" "+y);
//Swap(ref x,ref y);
//Console.WriteLine(x + " " + y);
//x = 10;
//Console.WriteLine(func(x));

//int s = 0;
//Add(x, y, out s);
//Console.WriteLine(s);

int n;
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine(n);



