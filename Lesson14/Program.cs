//for(int i = 35; i <= 87; i++)
//{
//    if(i%7==1||i%7==2||i%7==5) Console.Write(i+" ");
//}
//int i = 35;
//while (i <= 87)
//{
//    if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5) Console.Write(i + " ");
//    i++;
//}
//int k = 0;
//for (;true;k++) Console.WriteLine(k);

//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//int s = 0;
//for (int i = 1; i <= n; s += i, i++); 
//Console.WriteLine(s);

//1
//Напишите программу, которая запрашивает у пользователя строку - 
//слово и выводит его в обратном порядке. 
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//for(int i=str.Length-1;i>=0;i--) Console.Write(str[i]);

//2
//Напишите программу, где от пользователя берется на ввод строка - 
//слово и производится проверка - является ли слово палиндромом или 
//нет. С выводом пользователю результата 
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//string rts = "";
//for (int i = str.Length - 1; i >= 0; i--) rts += str[i];
//if(str==rts) Console.WriteLine("Палиндром");
//else Console.WriteLine("Не палиндром");

//Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран все его делители. 
//Console.Write("Введите целое число:");
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    if (n % i == 0) Console.Write(i + " ");
//}
//int j = 1;
//while (j <= n)
//{
//    if (n % j == 0) Console.Write(j + " ");
//    j++;
//}

//Напишите программу, которая запрашивает у пользователя целое
//число и проверяет, является ли это число простым. 
//Console.Write("Введите целое число:");
//int n = int.Parse(Console.ReadLine());
//int k = 0;//количество делителей
//for (int i = 2; i <n; i++)
//{
//    if (n % i == 0) k++;
//}
//if(k==0) Console.WriteLine("Простое число");
//else Console.WriteLine("Не простое");

//Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран все простые числа от 1 до этого числа
//включительно
//Console.Write("Введите целое число:");
//int n = int.Parse(Console.ReadLine());

//int i = 1;
//while (i <= n)
//{
//    int k = 0;
//    int j = 2;//внутренний счетчик, перебор делителей
//    while (j < i)
//    {
//        if (i % j == 0) k++;
//        j++;
//    }
//    if(k==0) Console.Write(i+" ");
//    i++;
//}

//for (int i = 1; i <= n; i++)
//{
//    int k = 0;//количество делителей
//    for (int j = 2; j < i; j++) if(i%j==0) k++;
//    if (k == 0) Console.Write(i + " ");
//}

//. Напишите программу, которая запрашивает у пользователя целое число и выводит на экран его двоичное представление. 
//Console.Write("Введите целое число:");
//int n = int.Parse(Console.ReadLine());
//string str = "";
//while (n != 1)
//{
//    str += n % 2;
//    n /= 2;
//}
//str += "1";
//for (; n != 1; str += n % 2, n /= 2) ;
//str += "1";
//for (int i = str.Length - 1;i >= 0;i--)
//    Console.Write(str[i]);

//Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран его факториал. Факториал числа n это 
//произведение всех целых чисел от 1 до n. Например, факториал числа 5 
//равен 1 * 2 * 3 * 4 * 5 = 120. 
//Console.Write("Введите целое число:");
//int n = int.Parse(Console.ReadLine());
//long f = 1;
//for (int i = 1; i <= n; f *= i++) ;
//Console.WriteLine(f);

//Напишите программу, которая запрашивает у пользователя два целых 
//числа a и b и выводит на экран все числа от a до b включительно,
//которые делятся на 3 или на 5 без остатка. 

//Console.Write("Введите число a:");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите число b:");
//int b = int.Parse(Console.ReadLine());
//for (int i = a; i <=b; i++)
//{
//    if(i%3==0||i%5==0) Console.Write(i+" ");
//}

Console.Write("Введите число:");
int n = int.Parse(Console.ReadLine());
int i = 1;
for(int j = 1; j <= n; j+=i)
{
    Console.Write(j+" ");
    i = j - i;
}
