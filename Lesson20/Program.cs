//Console.Write("Введите количество строк массива:");
//int n = int.Parse(Console.ReadLine());
//int[][] mas = new int[n][];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//	mas[i] =new int[random.Next(1, 10)];
//}
//for (int i = 0; i <mas.Length; i++)
//{
//	for (int j = 0; j < mas[i].Length; j++)
//	{
//		mas[i][j] = random.Next(10, 100);
//		Console.Write(mas[i][j]+" ");
//	}
//	Console.WriteLine();
//}
//char[,] mas = new char[8, 8];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j <mas.GetLength(1); j++)
//	{
//		if (( i + j ) % 2 == 0) mas[i, j] = 'W';
//		else mas[i, j] = 'B';
//		Console.Write(mas[i,j]+" ");
//	}
//	Console.WriteLine();
//}

//Random random = new Random();
//string[] mast = new string[] { "Пики", "Крести", "Черви", "Буби" };
//string[] nominal = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" };
//string[,,] players = new string[4, 2, 2];
//int[] setmast = new int[8];
//int[] setNom = new int[8];
//int count = 0;
//for (int i = 0; i < players.GetLength(0); i++)
//{
//	Console.Write(i+1+". ");
//	for (int j = 0; j < players.GetLength(1);)
//	{
//		int n = random.Next(4);
//        int m = random.Next(13);
//		bool yes = false;
//		for (int k = 0; k < 8;k++)
//		{
//			if (setmast[k] == n && setNom[k] == m)
//			{
//				yes = true;
//				break;
//            }
//		}
//		if (yes == true) continue;
//        players[i, j, 0] = mast[n];
//        players[i, j, 1] = nominal[m];
//		setmast[count] = n;
//		setNom[count] = m;
//        Console.Write(players[i, j, 1]+" " + players[i,j,0]+"\t");
//		j++;
//		count++;
//	}
//	Console.WriteLine();
//}
//for (int i = 0; i < 8; i++)
//{
//	Console.WriteLine(setmast[i]+" " + setNom[i]);
//}

//int[,,] mas = new int[4, 6, 8];
//Random random = new Random();
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//	for (int i = 0; i < mas.GetLength(0); i++)
//	{
//		for (int j = 0; j < mas.GetLength(1); j++)
//		{
//            mas[i, j, k] = random.Next(10, 100);
//            Console.Write(mas[i, j, k] + " ");
//		}
//		Console.WriteLine();
//	}
//	Console.WriteLine();
//}
//Console.Write("Введите число:");
//int m = int.Parse(Console.ReadLine());
//mas[3, 5, 7] = m;
//mas[0, 0, 0] = m;
//mas[1, 2, 3] = m;
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//Random random = new Random();
//int[,] mas1 = new int[3, 3];
//int[,] mas2 = new int[3, 3];
//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//	for (int j = 0; j < mas1.GetLength(1); j++)
//	{
//		mas1[i, j] = random.Next(10, 100);
//		Console.Write(mas1[i,j]+" ");
//	}
//	Console.WriteLine();
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.GetLength(0); i++)
//{
//    for (int j = 0; j < mas2.GetLength(1); j++)
//    {
//        mas2[i, j] = random.Next(10, 100);
//        Console.Write(mas2[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//int[,,] mas = new int[3, 3,2];
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            if (k == 0) mas[i, j, k] = mas1[i, j];
//            if (k == 1) mas[i, j, k] = mas2[i, j];
//            Console.Write(mas[i,j,k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}

//int[] mas1 = { 4, 8 };
//int[] mas2 = { 16, 2 };
//double[] masTotal1 = new double[2];
//for (int i = 0; i < mas1.Length; i++)
//{
//    masTotal1[i] = ( mas1[i] + mas2[i] ) / 2;
//    Console.Write($"{masTotal1[i]:F2} ");
//}
//Console.WriteLine();
//int[] mas3 = { 1, 22 };
//int[] mas4 = { 13, 3 };
//double[] masTotal2 = new double[2];
//for (int i = 0; i < mas3.Length; i++)
//{
//    masTotal2[i] = ( mas3[i] + mas4[i] ) / 2.0;
//    Console.Write($"{masTotal2[i]:F2} ");
//}
//Console.WriteLine();
//double[] masTotal3 = new double[2];

//for (int i = 0; i < masTotal3.Length; i++)
//{
//    masTotal3[i] = masTotal1[i] * masTotal2[i];
//    Console.Write($"{masTotal3[i]:F2} ");
//}

//string str = "ABCDZabz019";
//Random random = new Random();
//string res = "";
//for (int i = 0; i < 4; i++)
//{
//    res += str[random.Next(str.Length)];
//}
//Console.WriteLine(res);
//int[,] mas =new int[4, 3];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		mas[i, j] = int.Parse(Console.ReadLine());
//	}
//}
//Console.Write("Введите число:");
//int c = int.Parse(Console.ReadLine());
//mas[2, 2] = c;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i,j]+" "); ;
//    }
//    Console.WriteLine();
//}
Random random = new Random();
int[,] mas1 = new int[4, 3];
int[,] mas2 = new int[4, 3];
for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i, j] = random.Next(-50, 51);
        Console.Write(mas1[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < mas2.GetLength(0); i++)
{
    for (int j = 0; j < mas2.GetLength(1); j++)
    {
        mas2[i, j] = random.Next(-50, 51);
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] masSum = Sum(mas1, mas2);
for (int i = 0; i < masSum.GetLength(0); i++)
{
    for (int j = 0; j < masSum.GetLength(1); j++)
    {
        Console.Write(masSum[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Max="+Max(masSum));
int[,] Sum(int[,] m1, int[,] m2)
{
    int[,] mas = new int[m1.GetLength(0), m1.GetLength(1)];
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m1.GetLength(1); j++)
        {
            mas[i,j] = m1[i, j] + m2[i, j];
        }
    }
    return mas;
}
int Max(int[,] mas)
{
    int max = mas[0, 0];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] > max) max = mas[i, j];
        }
    }
    return max;
}