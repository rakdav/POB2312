//Тема 27. Методы. Практика
//Задание 1.
//Создайте класс "Генератор случайных чисел", содержащий методы для
//генерации случайных чисел разных типов, таких как целые числа,
//вещественные числа, булевы значения и т.д. Напишите код, который
//использует эти методы для генерации случайных чисел.
RandomClass rc = new RandomClass();
Console.WriteLine(rc.RandomInt(100));
Console.WriteLine($"{rc.RandomDouble(200):F2}");
Console.WriteLine(rc.RandomBool());
class RandomClass
{
    private Random random;

    public RandomClass()
    {
        random = new Random();
    }
    public int RandomInt(int n) => random.Next(n);
    public double RandomDouble(int n) => random.NextDouble() * n;
    public bool RandomBool() => (random.Next(0, 2) == 0) ? false : true;
}
