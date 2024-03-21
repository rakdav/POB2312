Random random = new Random();
char[] rabbits = new char[random.Next(10,20)];
int[,] rabbitGeo = new int[rabbits.Length, 3];
for(int i = 0; i < rabbitGeo.GetLength(0); i++)
{
    int k = random.Next(20);
    int m = random.Next(20);
    rabbitGeo[i, 0] = i;
    rabbitGeo[i, 1] = k;
    rabbitGeo[i, 2] = m;
}
char[] wolfs = new char[random.Next(5)+2];
char[] female = new char[random.Next(5) + 2];
char[,] square = new char[20, 20];
int rCount = rabbits.Length;
int wCount = wolfs.Length;
int fCount = female.Length;
bool play = true;
do
{

    Console.Clear();
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            square[i, j] = '.';
        }
    }
    for (int i=0;i<rabbits.Length;i++)
    {
        int k = random.Next(20);
        int m = random.Next(20);
        square[k,m] = 'R';
        rabbitGeo[i, 0] = i;
        rabbitGeo[i, 1] = k;
        rabbitGeo[i, 2] = m;
        int probably = (int)(random.NextDouble()*100);
        if (probably == 20) Array.Resize(ref rabbits, rabbits.Length + 1);
    }
    for(int i = 0; i < wolfs.Length; i++)
    {

        int k = random.Next(20);
        int m = random.Next(20);
        if (square[k, m] == 'R')
        {
            Array.Resize(ref rabbits, rabbits.Length - 1);
        }
        square[k, m] = 'W';
    }
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            if (square[i, j] != 'R'&& square[i, j] != 'W') square[i, j] = '.';
            Console.Write(square[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine("Кролики:"+rabbits.Length);
    Console.WriteLine("Волки:" + wolfs.Length);
    Thread.Sleep(800);
}
while (play);

