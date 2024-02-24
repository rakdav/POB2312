//Random random = new Random();
//int n;
//do
//{
//    n = random.Next(1, 11);
//    Console.Write(n + " ");
//}
//while (n!=7);

//Создайте массив из 20 случайных действительных чисел и
//найдите в нем индекс первого отрицательного элемента.
//double[] mas = new double[20];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100 - 50;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();

//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i]<0)
//    {
//        int index = i;
//        Console.WriteLine("Индекс первого отрицательного:" + index);
//        break;
//    } 
//}

//Создайте массив из 15 случайных целых чисел и выведите на экран 
//только те элементы, которые делятся на 2 и не делятся на 3. 

//int[] mas = new int[15];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(1, 100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//foreach(int i in mas)
//{
//    if(i%2==0&&i%3!=0) Console.Write(i+" "); 
//}

//Создайте массив из 12 случайных целых чисел и найдите в нем 
//наибольший элемент, наименьший элемент и среднее арифметическое 
//всех элементов. 
//int[] mas = new int[12];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//int min = mas[0], max = mas[0];
//double sum = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] > max) max = mas[i];
//    if (mas[i] < min) min = mas[i];
//    sum += mas[i];
//}
//Console.WriteLine("Max="+max);
//Console.WriteLine("Min="+min);
//Console.WriteLine($"Avg={sum/mas.Length:F2}");

//Создайте массив из 8 строк и найдите в нем самую короткую и 
//самую длинную строку, а также выведите на экран все строки,
//содержащие букву "а". 
//string[] mas = new string[8];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    string temp = "";
//    for(int j = 1; j < random.Next(1,30); j++)
//    {
//        temp += (char)random.Next(97, 123);
//    }
//    mas[i] = temp;
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//int max = mas[0].Length, min = mas[0].Length;
//string minStr = mas[0], maxStr = mas[0];
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        maxStr = mas[i];
//    }
//    if (mas[i].Length < min)
//    {
//        min = mas[i].Length;
//        minStr = mas[i];
//    }
//    if (mas[i].Contains("a")) Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Console.WriteLine("max="+maxStr);
//Console.WriteLine("min="+minStr);

//Сортировка массива
//Random random = new Random();
//int[] mas = new int[random.Next(20)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(1,100);
//    Console.Write(mas[i]+" ");
//}
//for (int i = 0; i < mas.Length-1; i++)
//{
//    for (int j = i+1; j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//Console.WriteLine();
//foreach (int i in mas)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();

//Создайте массив из 30 случайных целых чисел и выведите на экран 
//все элементы, которые встречаются в массиве больше одного раза.

int[] mas = new int[30];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(20);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
Array.Sort(mas);
foreach (int item in mas)
{
    Console.Write(item + " ");
}
Console.WriteLine();
int count = 0;
int temp=-1;
for(int i = 1; i < mas.Length; i++)
{
    if (mas[i] == mas[i - 1])
    {
        temp = mas[i];
        count++;
    }
    else if(mas[i] != mas[i - 1])
    {
        if (count > 0)
        {
            Console.Write(temp + " ");
            count = 0;
        }
    }
    if (i == mas.Length - 1)
    {
        if (count > 0)
        {
            Console.Write(temp + " ");
        }
    }
}




