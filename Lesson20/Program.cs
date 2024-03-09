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
Random random = new Random();
string[] mast = new string[] { "Пики", "Крести", "Черви", "Буби" };
string[] nominal = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" };
string[,,] players = new string[4, 2, 2];
int[] setmast = new int[8];
int[] setNom = new int[8];
int count = 0;
for (int i = 0; i < players.GetLength(0); i++)
{
	Console.Write(i+1+". ");
	for (int j = 0; j < players.GetLength(1);)
	{
		int n = random.Next(4);
        int m = random.Next(13);
		bool yes = false;
		for (int k = 0; k < 8;k++)
		{
			if (setmast[k] == n && setNom[k] == m)
			{
				yes = true;
				break;
            }
		}
		if (yes == true) continue;
        players[i, j, 0] = mast[n];
        players[i, j, 1] = nominal[m];
		setmast[count] = n;
		setNom[count] = m;
        Console.Write(players[i, j, 1]+" " + players[i,j,0]+"\t");
		j++;
		count++;
	}
	Console.WriteLine();
}
