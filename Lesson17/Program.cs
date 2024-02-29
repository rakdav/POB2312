//int[] mas = new int[5];
//int a;
//var b = 8;
//Console.WriteLine("****Length****");
//Console.WriteLine(mas.Length);
//Console.WriteLine("****Rank****");
//Console.WriteLine(mas.Rank);
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine(mas[2]);
//Console.WriteLine(mas.GetValue(2));
//mas[3] = 6;
//mas.SetValue(6, 3);
//Console.WriteLine(mas[3]);
////copy
//Console.WriteLine("****Copy****");
//int[] mas2 = { 3, 2, 1, 7, 2, 8 };
//int[] mas3 = new int[8];
//mas2.CopyTo(mas3, 2);
//foreach (int i in mas3)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
////sort
//Console.WriteLine("****sort****");
//Array.Sort(mas3);
//foreach (int item in mas3)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//string[] strMas = {"qwerty","lilo",
//"asdrtdg","whoami"};
//Array.Sort(strMas);
//foreach (string i in strMas)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
////reverse
//Console.WriteLine("****Reverse****");
////Array.Reverse(mas3);
//foreach (int item in mas3) Console.Write(item + " ");
//Console.WriteLine();
////IndexOf, LastIndexOf,BinarySearch
//Console.WriteLine(Array.IndexOf(mas2, 2));
//Console.WriteLine(Array.LastIndexOf(mas2, 2));
//Console.WriteLine(Array.LastIndexOf(mas2, 5));
//Console.WriteLine(Array.BinarySearch(mas3, 7));
//Console.WriteLine(Array.BinarySearch(mas3, 5));

////Concat
//Console.WriteLine("****Concat****");
//int[] sumMas = mas.Concat(mas2).ToArray();
//foreach (var i in sumMas) Console.Write(i + " ");
//Console.WriteLine();
//Console.WriteLine(sumMas.Length);
////Clear()
//Console.WriteLine("****Clear****");
//Array.Clear(sumMas);
//foreach (var i in sumMas) Console.Write(i + " ");
//Console.WriteLine();
//Console.WriteLine(sumMas.Length);
////Resize
//Console.WriteLine("****Resize****");
//Array.Resize(ref mas2, 4);
//foreach (var i in mas2) Console.Write(i + " ");
//Console.WriteLine();

//1. Напишите программу, которая запрашивает у пользователя 5 чисел и 
//сохраняет их в массиве. Затем программа выводит на экран все числа 
//из массива в обратном порядке. 
//Random random = new Random();
//int[] mas = new int[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//Array.Reverse(mas);
//foreach (int i in mas) Console.Write(i+" ");
//Console.WriteLine();

//2. Напишите программу, которая запрашивает у пользователя 5 слов и 
//сохраняет их в массиве. Затем программа находит и выводит самое длинное слово из массива. 

//string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите " + ( i + 1 ) + " слово:");
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas) Console.Write(i+" ");
//Console.WriteLine();
//int max = mas[0].Length;
//string res = mas[0];
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        res = mas[i];
//    }
//}
//Console.WriteLine(res);

//3.Создайте 2 массива случайных чисел. Соедините их с помощью метода Concat(). Затем программа находит и выводит среднее  арифметическое всех чисел в массиве. 

//int[] mas1 = new int[5];
//int[] mas2 = new int[4];
//Random random = new Random();
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(10);
//    Console.Write(mas1[i]+" ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = random.Next(10);
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//int[] mas3 = mas1.Concat(mas2).ToArray();
//double sum = 0;
//foreach(int i in mas3)
//{
//    sum += i;
//    Console.Write(i+" ");
//}
//Console.WriteLine();
//Console.WriteLine($"Avg:{sum/mas3.Length:F2}");

//4.Напишите программу, которая запрашивает у пользователя 10 чисел 
//и сохраняет их в массиве. Затем программа находит и выводит на экран 
//наименьшее и наибольшее число в массиве. 

//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine(mas.Max());
//Console.WriteLine(mas.Min());

//5.Напишите программу, которая запрашивает у пользователя 5 слов и 
//сохраняет их в массиве. Затем программа выводит на экран все слова 
//из массива, начинающиеся на определенную букву, которую вводит 
//пользователь. Для данной задачи используйте метод “IndexOf()”

//string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите " + ( i + 1 ) + " слово:");
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas) Console.Write(i+" ");
//Console.WriteLine();
//Console.Write("Введите символ:");
//char c = char.Parse(Console.ReadLine());
//foreach(string i in mas)
//{
//    if (Array.IndexOf(i.ToArray(), c) == 0) 
//        Console.Write(i +" ");
//}

//Задание 1. 
//● Инициализируйте генератор случайных значений. 
//● Объявите переменные и укажите в них значения имен 
//пользователей. Необходимо 6 разных имен. 
//● Создайте пустой одномерный строковый массив размером в 6 
//ячеек. 
//● С помощью генератора, в случайном порядке заполните массив 
//именами из переменных. 
//● Выведите значения массива на экран, в строку. 
//● Задача: 
//После объявления массива имен, от пользователя берутся имена,
//которые необходимо удалить и удаляются, заменяясь на “Удален” 
//Затем, необходимо вывести список имен без “Удален”. 

Random random = new Random();
string a = "Tom";
string b = "Jerry";
string c = "Bob";
string d = "Mike";
string e = "Stive";
string f = "John";
string[] names = new string[6];
for (int i = 0; i < names.Length; i++)
{
    switch (random.Next(6))
    {
        case 0: names[i] = a; break;
        case 1: names[i] = b; break;
        case 2: names[i] = c; break;
        case 3: names[i] = d; break;
        case 4: names[i] = e; break;
        case 5: names[i] = f; break;
    }
    Console.Write(names[i]+" ");
}
Console.WriteLine();
do
{
    Console.Write("Введите имя:");
    string name = Console.ReadLine();
    while (Array.IndexOf(names, name) != -1)
    {
        names[Array.IndexOf(names, name)] = "Удален";
    }
    Console.Write("Продолжить y/n:");
    char answer = char.Parse(Console.ReadLine());
    if (answer == 'n') break;
}
while (true);
foreach (string i in names) 
    if(i!= "Удален") Console.Write(i+" ");
