Random random = new Random();
char[] rabbits = new char[random.Next(10,20)];
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
        Console.WriteLine();
    }
    for (int i=0;i<rabbits.Length;i++)
    {
        square[random.Next(20), random.Next(20)] = 'R';
    }
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            if (square[i, j] != 'R') square[i, j] = '.';
            Console.Write(square[i,j]);
        }
        Console.WriteLine();
    }
    Thread.Sleep(800);
}
while (play);