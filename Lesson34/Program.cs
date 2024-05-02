//Тема 27. Методы. Практика
//Задание 1.
//Создайте класс "Генератор случайных чисел", содержащий методы для
//генерации случайных чисел разных типов, таких как целые числа,
//вещественные числа, булевы значения и т.д. Напишите код, который
//использует эти методы для генерации случайных чисел.
//int? d = null;
//int x = d ?? 0;
//string str = Console.ReadLine()!;
//string res = str ?? "Empty";
//Console.WriteLine(x);
//Console.WriteLine(res);

//RandomClass rc = new RandomClass();
//Console.WriteLine(rc.RandomInt(int.Parse(Console.ReadLine()!)));
//Console.WriteLine($"{rc.RandomDouble(200):F2}");
//Console.WriteLine(rc.RandomBool());
//class RandomClass
//{
//    private Random random;

//    public RandomClass()
//    {
//        random = new Random();
//    }
//    public int RandomInt(int n) => random.Next(n);
//    public double RandomDouble(int n) => random.NextDouble() * n;
//    public bool RandomBool() => (random.Next(0, 2) == 0) ? false : true;
//}

//Задание 2.
//Создайте класс, для работы со строкой, содержащий методы переворота
//строки, проверки на палиндром, разбиения строки на части, переводящий
//всю строку в верхний регистр или нижний, режущий строку по индексу
//элемента, производящий поиск по слову.
//Console.Write("Введите строку:");
//MyString myString = new MyString(Console.ReadLine()!);
//Console.WriteLine(myString.Reverse());
//Console.WriteLine(myString.IsPolindrom()?"Полиндром":"Не полиндром");
//Console.Write("Введите символ:");
//char c = char.Parse(Console.ReadLine()!);
//foreach (var item in myString.Split(c))
//{
//    Console.WriteLine(item);
//}
//Console.Write("Введите строку:");
//string str = Console.ReadLine()!;
//foreach (var item in myString.Split(str))
//{
//    Console.WriteLine(item);
//}
//Console.Write("Введите индекс:");
//int index =int.Parse(Console.ReadLine()!);
//foreach (var item in myString.Split(index))
//{
//    Console.WriteLine(item);
//}
//Console.Write("Введите строку для поиска:");
//string findStr = Console.ReadLine()!;
//Console.WriteLine(myString.Find(findStr)?"Есть":"Нет");

using ArrrayLibrary;


ArrayClass arrayClass1 = new ArrayClass(typeof(int),10);
arrayClass1.Fill(10, 100);
Console.WriteLine();
ArrayClass arrayClass2 = new ArrayClass(typeof(double), 10);
arrayClass2.Fill(10, 100);
Console.WriteLine();
ArrayClass arrayClass3 = new ArrayClass(typeof(string), 10);
arrayClass3.Fill(10);
Console.WriteLine();
ArrayClass arrayClass4 = new ArrayClass(typeof(bool), 10);
arrayClass4.Fill(10);
Console.WriteLine();