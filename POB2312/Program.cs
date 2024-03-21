//Console.Write("Введите ваше имя:");
//string name = Console.ReadLine();
//Console.WriteLine("Меня зовут, " + name);


int n =int.Parse(Console.ReadLine()); 
int m =int.Parse(Console.ReadLine());
int[,] mas = new int[n,m]; 
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (i + j + 1 > 6) mas[i,j] = i + j - 5;
        else
        {
            mas[i,j] = i + j + 1;
        }
        Console.Write(mas[i,j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine();
 int k = 0; 
int[,] mas1 = new int[6,6];
for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        if (i == 0) mas1[i, j] = m - k;
        else
        {
            mas1[i, j] = mas1[i - 1, j] + 10;

            Console.Write(mas1[i, j] + " ");
            k++;
        }
        Console.WriteLine();
    }
}
   


