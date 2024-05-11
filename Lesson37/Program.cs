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

string moon = "Moon";
if (!Enum.IsDefined(typeof(DistanceSun), moon))
{
    Console.WriteLine("Не планета");
}
foreach(DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
{
    Console.WriteLine("{0,-10} {1,-10} {2,20}",
                     Enum.Format(typeof(DistanceSun),item,"G"),
                     Enum.Format(typeof(DistanceSun), item, "D"),
                     Enum.Format(typeof(DistanceSun), item, "X")
                     );
}

foreach (string item in Enum.GetNames(typeof(DistanceSun)))
{
    Console.WriteLine(item);
}


enum DistanceSun : ulong
{
    Sun=0,
    Mercury=5790000,
    Venus=108200000,
    Earth=149600000,
    Mars=227900000,
    Jupiter=708300000,
    Saturn=1427000000,
    Uranus=2870000000,
    Neptune=4496000000,
    Pluto=5946000000
}
