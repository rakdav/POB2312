//int x = 10;
//int y = 15;
//int S = x + y;
//Console.WriteLine(S);
//int[] mas = new int[5];
//Array.Fill(mas, 5);
//foreach (int i in mas) Console.Write(i+" ");
//Console.WriteLine();
//int[] mas2 = mas;
//Array.Fill(mas2, 3, 0, 3);
//foreach (int i in mas) Console.Write(i + " ");
//Console.WriteLine();
//foreach (int i in mas2) Console.Write(i + " ");
//Console.WriteLine();

//1
//void Swap(ref int x,ref int y)
//{
//    int temp = x;
//    x = y;
//    y = temp;
//}

//Console.Write("Введите 1 число:");
//int x;
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите 2 число:");
//int y;
//int.TryParse(Console.ReadLine(), out y);
//Console.WriteLine(x+" "+y);
//Swap(ref x,ref y);
//Console.WriteLine(x + " " + y);

//2
//void Divide(int x,int y,out int result)
//{
//    if (y == 0)
//    {
//        Console.WriteLine("Делить на ноль нельзя");
//        result = 0;
//    }
//    else
//    {
//        result = x / y;
//    }
//}

//int div;
//Console.Write("Введите 1 число:");
//int x;
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите 2 число:");
//int y;
//int.TryParse(Console.ReadLine(), out y);
//Divide(x, y, out div);
//Console.WriteLine($"{x}/{y}={div}");

//3
//double CalculateAverage(params double[] mas)
//{
//    double s = 0;
//    for (int i = 0; i < mas.Length; i++) s += mas[i];
//    return s / mas.Length;
//}

//Console.WriteLine(CalculateAverage(4,2,7,5));
//Console.WriteLine(CalculateAverage(8,5,12,45,7,9));

//4
//void ModifyArray(int[] mas,out int count)
//{
//	count = 0;
//	for (int i = 0; i < mas.Length; i++)
//	{
//		mas[i] = mas[i] * mas[i];
//		count++;
//	}
//}
//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//	mas[i] = random.Next(10);
//	Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//int[] newMas = new int[10];
//Array.Copy(mas, newMas, mas.Length);
//int count;
//ModifyArray(mas, out count);
//Console.WriteLine("count="+count);
//for (int i = 0; i < mas.Length; i++)
//{ 
//    Console.Write(mas[i] + " ");
//}

//120,300,125,64,5
//bool IsStep5(int n)
//{
//    bool isTrue = true;
//    while (n != 1)
//    {
//        if (n % 5 != 0)
//        {
//            isTrue = false;
//            break;
//        }
//        n /= 5;
//    }
//    return isTrue;
//}
//int[] mas = new int[6];
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите элемент массива:");
//    mas[i] = int.Parse(Console.ReadLine());
//    if (IsStep5(mas[i])) count++;
//}
//Console.WriteLine(count);

//bool IsSimple(int n)
//{
//	bool isTrue = true;
//	for (int i = 2; i < n; i++)
//	{
//		if (n % i == 0)
//		{
//			isTrue = false;
//			break;
//		}
//	}
//	return isTrue;
//}
//bool ISPair(int a,int b)
//{
//	if (IsSimple(a) && IsSimple(b) && Math.Abs(b - a) == 2) return true;
//	return false;
//}
//for(int i = 2; i <= 200; i++)
//{
//	if (ISPair(i, i - 2)) Console.WriteLine((i-2)+" "+i);
//}

using System.Diagnostics;

int Sum(int p)
{
    int s = 0;
    while (p != 0)
    {
        s += p % 10;
        p /= 10;
    }
    return s;
}
void SortMas(int[] mas)
{
    for(int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = i+1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                int temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
}
//Stopwatch stpWatch = new Stopwatch();
//stpWatch.Start();
//int count = 0;
//for(int i = 100000; i < 1000000; i++)
//{
//    if (Sum(i % 1000) == Sum(i / 1000))
//    {
//        //Console.WriteLine(i);
//        count++;
//    }
//}
//Console.WriteLine(count);
//stpWatch.Stop();
//Console.WriteLine("StopWatch: "+(stpWatch.ElapsedMilliseconds/1000.0).ToString());
int[] mas = new int[100000];
Random random = new Random();
for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(1000);
int[] mas1 = new int[100000];
Array.Copy(mas, mas1, mas.Length);
Stopwatch stpWatch = new Stopwatch();
stpWatch.Start();
SortMas(mas);
stpWatch.Stop();
Console.WriteLine("StopWatch: " + (stpWatch.ElapsedMilliseconds / 1000.0).ToString());
Stopwatch stpWatch1 = new Stopwatch();
stpWatch1.Start();
Array.Sort(mas1);
stpWatch1.Stop();
Console.WriteLine("StopWatch: " + (stpWatch1.ElapsedMilliseconds / 1000.0).ToString());


Console.WriteLine();
