char[,] grid = new char[18, 18];
char[] snake = new char[4];
int[,] geoSnake =new int[4,2]
{
    {0,3},{0,2},{0,1},{0,0}
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
                    int temp = ++geoSnake[0, 1];
                    geoSnake[0, 1] = temp;
                    for (int i = 1; i < snake.Length; i++)
                    {
                        geoSnake[i, 0] = geoSnake[i - 1, 0];
                        geoSnake[i, 1] = geoSnake[i - 1, 1];
                    }
                    for (int i = 0; i < snake.Length; i++)
                    {
                        int x = geoSnake[i, 0];
                        int y = geoSnake[i, 1];
                        grid[x, y] = 'X';
                    }
            }
            break;
        case 's': 
            {
                    int temp = geoSnake[0, 0];
                    geoSnake[1, 0] = geoSnake[0, 0];
                    geoSnake[1, 1] = geoSnake[0, 1];
                    temp++;
                    geoSnake[0, 0] = temp;
                    int x1 = geoSnake[0, 0];
                    int y1 = geoSnake[0, 1];
                    int x2 = geoSnake[1, 0];
                    int y2 = geoSnake[1, 1];
                    grid[x1, y1] = 'X';
                    grid[x2, y2] = 'X';
            }
            break;
        case 'a':
            {
                    int temp = geoSnake[0, 1];
                    geoSnake[1, 0] = geoSnake[0, 0];
                    geoSnake[1, 1] = geoSnake[0, 1];
                    temp--;
                    geoSnake[0, 1] = temp;
                    int x1 = geoSnake[0, 0];
                    int y1 = geoSnake[0, 1];
                    int x2 = geoSnake[1, 0];
                    int y2 = geoSnake[1, 1];
                    grid[x1, y1] = 'X';
                    grid[x2, y2] = 'X';
            }
            break;
        case 'w':
            {

                    int temp = geoSnake[0, 0];
                    geoSnake[1, 0] = geoSnake[0, 0];
                    geoSnake[1, 1] = geoSnake[0, 1];
                    temp--;
                    geoSnake[0, 0] = temp;
                    int x1 = geoSnake[0, 0];
                    int y1 = geoSnake[0, 1];
                    int x2 = geoSnake[1, 0];
                    int y2 = geoSnake[1, 1];
                    grid[x1, y1] = 'X';
                    grid[x2, y2] = 'X';
            }
            break;
    }
    
    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (Console.KeyAvailable)
    {
        geo = Console.ReadKey().KeyChar;
    }
    Thread.Sleep(500);
}
while (true);

