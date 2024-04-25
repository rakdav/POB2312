
//using System;

//Console.Write("Введите ФИО:");
//string fio = Console.ReadLine();
//Person person1 = new Person(fio,34,180);
//Person person2 = new Person("Петров", 34, 180);
//Console.WriteLine(person1.getFIO());
//class Person
//{
//    private string FIO;
//    private int age;
//    private double rost;
//    private double weight;

//    public Person(string fIO, int age, double rost)
//    {
//        FIO = fIO;
//        this.age = age;
//        this.rost = rost;
//    }

//    public string getFIO()
//    {
//        return FIO;
//    }
//    public void setFIO(string fio)
//    {
//        FIO = fio;
//    }
//    public int getAge()
//    {
//        return age;
//    }
//    public void setAge(int a)
//    {
//        age = a;
//    }
//    public double getRost()
//    {
//        return rost;
//    }
//    public void setRost(double r)
//    {
//        rost = r;
//    }
//    public double getWeight()
//    {
//        weight = Massa();
//        return Massa();
//    }
//    private double Massa()
//    {
//        return rost - 100;
//    }
//}

//Задание 1.
//Создайте класс "Калькулятор" с методами для выполнения
//арифметических операций, таких как сложение, вычитание, умножение и
//деление. Напишите код, который вызывает эти методы для выполнения
//операций с заданными числами.
//Console.Write("Введите x:");
//double x,y;
//double.TryParse(Console.ReadLine(),out x);
//Console.Write("Введите y:");
//double.TryParse(Console.ReadLine(), out y);
//Calculator calc = new Calculator(x, y);
//Console.WriteLine(calc.Add());
//Console.WriteLine(calc.Sub());
//Console.WriteLine(calc.Mult());
//Console.WriteLine(calc.Div());
//class Calculator
//{
//    private double X;
//    private double Y;
//    public Calculator(double x, double y)
//    {
//        X = x;
//        Y= y;
//    }
//    public double Add()
//    {
//        return X + Y;
//    }
//    public double Mult()
//    {
//        return X * Y;
//    }
//    public double Sub()
//    {
//        return X - Y;
//    }
//    public double Div()=>X / Y;
//}

//Задание 2.
//Создайте класс "Строковый анализатор", содержащий методы для анализа
//строковых данных, таких как подсчет количества символов, проверка
//наличия подстроки, преобразование строки в верхний/нижний регистр и
//т.д. Напишите код, который использует эти методы для анализа и
//обработки заданных строк
Console.Write("Введите строку:");
string str = Console.ReadLine();
StringAnalizer analiz = new StringAnalizer(str);
Console.WriteLine(analiz.getLength());
Console.Write("Введите подстроку:");
string sub = Console.ReadLine();
Console.WriteLine(analiz.SubStr(sub));
Console.WriteLine(analiz.OurToLower());
Console.WriteLine(analiz.OurToUpper());
class StringAnalizer
{
    private string Stroka;
    public StringAnalizer(string stroka)
    {
        Stroka = stroka;
    }
    public int getLength()
    {
        return Stroka.Length;
    }
    public bool SubStr(string substr)
    {
        return Stroka.Contains(substr);
    }
    public string OurToUpper()
    {
        return Stroka.ToUpper();
    }
    public string OurToLower()
    {
        return Stroka.ToLower();
    }
}