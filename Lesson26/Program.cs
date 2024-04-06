using System.Text;
//FileStream fStream = null;
//try
//{
//    fStream = new FileStream("file.txt",FileMode.Open);
//    byte[] b = new byte[fStream.Length];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while (fStream.Read(b, 0, b.Length) > 0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}
//catch(Exception ex)
//{

//}
//finally
//{
//    fStream.Close();
//}

//синхронное чтение
//using (FileStream fs=new FileStream("file.txt",
//    FileMode.Open))
//{
//    byte[] b = new byte[fs.Length];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while (fs.Read(b,0,b.Length)>0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}

//асинхронная запись в файл
//Console.Write("Введите текст:");
//string text = Console.ReadLine();
//using(FileStream fStream=new FileStream("First.txt", FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fStream.WriteAsync(buffer, 0, buffer.Length);
//    Console.WriteLine("Файл сохранен");
//}
//асинхронное чтение из файла
//using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
//{
//    byte[] buffer = new byte[fStream.Length];
//    await fStream.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}
//асинхронное чтение части файла
//using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
//{
//    fStream.Seek(10, SeekOrigin.Begin);
//    byte[] buffer = new byte[10];
//    await fStream.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}

//Работа с тесктовыми файлами
//запись в файл
//Console.Write("Введите текст:");
//string text = Console.ReadLine();
////перезапись файла
//using (StreamWriter writer = new StreamWriter("First.txt", false))
//{
//    await writer.WriteAsync(text);
//}
////добавление в файл
//using (StreamWriter writer = new StreamWriter("First.txt", true))
//{
//    await writer.WriteLineAsync(" на лапу Азора");
//}

//чтение из файла
using (StreamReader reader=new StreamReader("First.txt"))
{
    string text = await reader.ReadToEndAsync();
    Console.WriteLine(text);
}

using (StreamReader reader = new StreamReader("First.txt"))
{
    string text = "";
    while((text=await reader.ReadLineAsync()) != null)
    {
        Console.WriteLine(text);
    }
}

