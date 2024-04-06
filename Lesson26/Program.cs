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
//using (StreamReader reader=new StreamReader("First.txt"))
//{
//    string text = await reader.ReadToEndAsync();
//    Console.WriteLine(text);
//}

//using (StreamReader reader = new StreamReader("First.txt"))
//{
//    string text = "";
//    while((text=await reader.ReadLineAsync()) != null)
//    {
//        Console.WriteLine(text);
//    }
//}

//Работа с дисками
//DriveInfo[] drives = DriveInfo.GetDrives();
//foreach (DriveInfo drive in drives)
//{
//    Console.WriteLine(drive.Name);
//    Console.WriteLine(drive.DriveType);
//    if (drive.IsReady)
//    {
//        Console.WriteLine($"{drive.TotalSize/1024} кБайт");
//        Console.WriteLine(drive.TotalFreeSpace);
//        Console.WriteLine(drive.VolumeLabel);
//    }
//    Console.WriteLine();
//}

//Directory
//string dirName = @"C:\";
//if (Directory.Exists(dirName))
//{
//    Console.WriteLine("Папки:");
//    string[] dirs = Directory.GetDirectories(dirName);
//    foreach(string dir in dirs)
//    {
//        Console.WriteLine(dir);
//    }
//    Console.WriteLine("Файлы:");
//    string[] files = Directory.GetFiles(dirName);
//    foreach (string file in files)
//    {
//        Console.WriteLine(file);
//    }
//}

//DirectoryInfo
//DirectoryInfo dirInfo = new DirectoryInfo(dirName);
//if (dirInfo.Exists)
//{
//    Console.WriteLine("Папки:");
//    DirectoryInfo[] dirs = dirInfo.GetDirectories();
//    foreach (DirectoryInfo dir in dirs)
//    {
//        Console.WriteLine(dir.FullName);
//    }
//    Console.WriteLine("Файлы:");
//    FileInfo[] files = dirInfo.GetFiles();
//    foreach (FileInfo file in files)
//    {
//        Console.WriteLine(file.Name);
//    }
//}

//Задача 3: Копирование файла
//Попросите пользователя ввести имя исходного файла и имя файла назначения.
//Скопируйте содержимое исходного файла в файл назначения.

//string file1 = "File.txt";
//string file2 = "First.txt";
//FileInfo fi = new FileInfo(file1);
//if (fi.Exists)
//{
//    fi.CopyTo(file2,true);
//}

//Задача 4: Поиск файлов по расширению
//Попросите пользователя ввести путь к папке и расширение файла.
//Найдите все файлы с указанным расширением в указанной папке и
//выведите их имена на экран.
//Console.WriteLine("Введите путь к папке:");
//string path = Console.ReadLine();
//DirectoryInfo dirInfo = new DirectoryInfo(@$"{path}");
//FileInfo[] files = dirInfo.GetFiles();
//Console.Write("Введите расширение для поиска:");
//string extension = Console.ReadLine();
//foreach (FileInfo file in files)
//{
//    if (file.Extension =="."+extension) Console.WriteLine(file.FullName);
//}
