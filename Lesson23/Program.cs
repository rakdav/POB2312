char[,] grid = new char[18, 18];
char[] snake = new char[1];
int[,] geoSnake =new int[1,2]
{
    {0,0}
};
char geo = 'd';
do
{
    Console.Clear();
    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
           grid[i, j] = '.';
        }
    }
    switch (geo) {
        case 'd':
            {
                for (int k = 0; k < geoSnake.GetLength(0); k++)
                {
                    int temp = geoSnake[k, 1];
                    temp++;
                    geoSnake[k, 1] = temp;
                    int x = geoSnake[k, 0];
                    int y = geoSnake[k, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 's': 
            {
                for (int k = 0; k < geoSnake.GetLength(0); k++)
                {
                    int temp = geoSnake[k, 0];
                    temp++;
                    geoSnake[k, 0] = temp;
                    int x = geoSnake[k, 0];
                    int y = geoSnake[k, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 'a':
            {
                for (int k = 0; k < geoSnake.GetLength(0); k++)
                {
                    int temp = geoSnake[k, 1];
                    temp--;
                    geoSnake[k, 1] = temp;
                    int x = geoSnake[k, 0];
                    int y = geoSnake[k, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 'w':
            {
                for (int k = 0; k < geoSnake.GetLength(0); k++)
                {
                    int temp = geoSnake[k, 0];
                    temp--;
                    geoSnake[k, 0] = temp;
                    int x = geoSnake[k, 0];
                    int y = geoSnake[k, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
    }
    
    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            if (grid[i, j] != 'X') grid[i, j] = '.';
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (Console.KeyAvailable)
    {
        geo = Console.ReadKey().KeyChar;
    }
    Thread.Sleep(1000);
}
while (true);

