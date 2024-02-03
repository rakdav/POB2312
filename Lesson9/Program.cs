//byte a = 254;
//Console.WriteLine(Convert.ToString(a, 2));

//Console.WriteLine(Convert.ToString(~a, 2));
//Console.WriteLine(16>>3);
//int x = 1, y = -1;
//Console.WriteLine(x*x+y*y<=4);
//x = 1;y = 2;
//Console.WriteLine((x>=0)||(y*y!=4));
//Console.Write("Введите N:");
//int N = int.Parse(Console.ReadLine());
//Console.WriteLine(N%5==0||N%7==0);
//Console.WriteLine(N%4==0&&N%10!=0);
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
if ((x >= 2) && (y >= 1 || y <= -1.5))
    Console.WriteLine("Попал");
else
    Console.WriteLine("Не попал");

