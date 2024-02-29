int[] mas = new int[5];
int a;
var b=8;
Console.WriteLine(mas.Length);
Console.WriteLine(mas.Rank);
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
Console.WriteLine(mas[2]);
Console.WriteLine(mas.GetValue(2));
mas[3] = 6;
mas.SetValue(6,3);
Console.WriteLine(mas[3]);
//copy
int[] mas2 = { 3, 2, 1, 7, 2, 8 };
int[] mas3 = new int[8];
mas2.CopyTo(mas3,2);
foreach(int i in mas3)
{
    Console.Write(i+" ");
}
Console.WriteLine();
//sort
Array.Sort(mas3);
foreach (int item in mas3)
{
    Console.Write(item+" ");
}
Console.WriteLine();
string[] strMas = {"qwerty","lilo",
"asdrtdg","whoami"};
Array.Sort(strMas);
foreach (string i in strMas)
{
    Console.Write(i+" ");
}
Console.WriteLine();
//reverse
//Array.Reverse(mas3);
foreach (int item in mas3 ) Console.Write(item+" ");
Console.WriteLine();
//IndexOf, LastIndexOf,BinarySearch
Console.WriteLine(Array.IndexOf(mas2,2));
Console.WriteLine(Array.LastIndexOf(mas2,2));
Console.WriteLine(Array.LastIndexOf(mas2,5));
Console.WriteLine(Array.BinarySearch(mas3,7));
Console.WriteLine(Array.BinarySearch(mas3, 5));

//Concat
int[] sumMas = mas.Concat(mas2).ToArray();
foreach (var i in sumMas) Console.Write(i+" ");
Console.WriteLine();
Console.WriteLine(sumMas.Length);
//Clear()
Array.Clear(sumMas);
foreach (var i in sumMas) Console.Write(i + " ");
Console.WriteLine();
Console.WriteLine(sumMas.Length);
//Resize
Array.Resize(ref mas2, 4);
foreach (var i in mas2) Console.Write(i + " ");
Console.WriteLine();
