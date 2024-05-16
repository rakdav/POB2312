//Console.BackgroundColor = ConsoleColor.Red;
//Console.WriteLine(ToRussia(PrintMessage()));
//DayTime PrintMessage()
//{
//    int hour = DateTime.Now.Hour;
//    DayTime dayTime;
//    if (hour > 5 && hour < 12) dayTime = DayTime.Morning;
//    else if (hour > 12 && hour < 17) dayTime = DayTime.Afternoon;
//    else if (hour > 17 && hour < 24) dayTime = DayTime.Evening;
//    else dayTime = DayTime.Night;
//    return dayTime;
//}
//string ToRussia(DayTime dayTime)
//{
//    switch ((int)dayTime)
//    {
//        //case DayTime.Morning: return "Доброе утро!";
//        //case DayTime.Afternoon: return "Добрый день!";
//        //case DayTime.Evening: return "Добрый вечер!";
//        case 1: return "Доброе утро!";
//        case 2: return "Добрый день!";
//        case 3: return "Добрый вечер!";
//    }
//    return "Доброй ночи!";
//}
//enum DayTime
//{
//    Morning=1,
//    Afternoon,
//    Evening,
//    Night
//}

//Console.Write("Введите первое число:");
//double a = double.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число:");
//double b = double.Parse(Console.ReadLine()!);
//DoOperation(a,b,Operation.Add);
//DoOperation(a, b, Operation.Subtract);
//DoOperation(a, b, Operation.Multiply);
//DoOperation(a, b, Operation.Divide);
//void DoOperation(double x,double y,Operation op)
//{
//    double result = op switch
//    { 
//        Operation.Add=>x+y,
//        Operation.Subtract => x - y,
//        Operation.Multiply=>x*y,
//        Operation.Divide=>x/y
//    };
//    Console.WriteLine(result);
//}



//enum Operation
//{
//    Add,
//    Subtract,
//    Multiply,
//    Divide
//}

//string moon = "Moon";
//if (!Enum.IsDefined(typeof(DistanceSun), moon))
//{
//    Console.WriteLine("Не планета");
//}
//foreach(DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
//{
//    Console.WriteLine("{0,-10} {1,-10} {2,20}",
//                     Enum.Format(typeof(DistanceSun),item,"G"),
//                     Enum.Format(typeof(DistanceSun), item, "D"),
//                     Enum.Format(typeof(DistanceSun), item, "X")
//                     );
//}

//foreach (string item in Enum.GetNames(typeof(DistanceSun)))
//{
//    Console.WriteLine(item);
//}


//enum DistanceSun : ulong
//{
//    Sun=0,
//    Mercury=5790000,
//    Venus=108200000,
//    Earth=149600000,
//    Mars=227900000,
//    Jupiter=708300000,
//    Saturn=1427000000,
//    Uranus=2870000000,
//    Neptune=4496000000,
//    Pluto=5946000000
//}

//string str = Console.ReadLine()!;
//string res = "";
//for (int i = str.Length - 1; i >= 0; i--)
//{
//    res += str[i];
//}
//Console.WriteLine(res);
//if (str == res) Console.WriteLine("Полиндром");

//Console.WriteLine("Введите число:");
//int n;
//int.TryParse(Console.ReadLine()!, out n);
//int s = 0;
//for(int i = 1; i < n; i++)
//{
//    if (n % i == 0) s += i; 
//}
//if (s == n) Console.WriteLine("Число совершенное");
//else Console.WriteLine("Число не совершеннное");


//string abc = "";
//for (int i = (int)'A'; i <(int)'z'; i++)
//{
//   if(Char.IsLetter((char)i)) abc += (char)i;
//}
//Console.WriteLine(abc);

//for(int i = 1; i <= 100; i++)
//{
//    int k = 0;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0) k++;
//    }
//    if (k == 0) Console.Write(i+" ");
//}

string abc = "";
for (int i = (int)'а'; i <=(int)'я'; i++)
{
    if (Char.IsLetter((char)i)) abc += (char)i;
}
Console.WriteLine(abc);

string res = "";
string str = Console.ReadLine()!;

for(int i = 0; i < str.Length; i++)
{
    if (!res.Contains(str[i]) && Char.IsLetter(str[i])) res += Char.ToLower(str[i]);
}
char[] mas = res.ToArray();
Array.Sort(mas);
res = new string(mas);
Console.WriteLine(res);
if (abc == res) Console.WriteLine("Анграмма");
else Console.WriteLine("Не анграмма");