//Console.Write("Введите строку:");
//string text = Console.ReadLine();
//Console.Write("Введите слово для проверки:");
//string word = Console.ReadLine();
//string result = "Результат: ";
//if (text.Contains(word)) result += "Строка содержит указанное слово.";
//else result += "Строка не содержит указанное слово.";
//Console.WriteLine(result);

//Console.Write("Введите строку:");
//string text = Console.ReadLine();
//Console.Write("Введите символ для замены:");
//char s = char.Parse(Console.ReadLine());
//Console.Write("Введите символ, на который нужно заменить:");
//char c = char.Parse(Console.ReadLine());
//text = text.Replace(s, c);
//Console.WriteLine(text);

//Console.Write("Введите строку:");
//string text = Console.ReadLine();
//Console.Write("Введите слово для подсчета:");
//string word = Console.ReadLine();
//string[] mas = text.Split(" ");
//int count = 0;
//for (int i = 0; i <mas.Length; i++)
//{
//    if (mas[i].Contains(word)) count++;
//}
//Console.WriteLine("Количество вхождений:"+count);
//count = 0;
//int index = 0;
//while (text.IndexOf(word,index) != -1)
//{
//        count++;
//        index = text.IndexOf(word, index) + word.Length;
//}
//Console.WriteLine("Количество вхождений:" + count);

//Console.Write("Введите строку:");
//string text = Console.ReadLine();
//Console.Write("Введите слово для подсчета:");
//string word = Console.ReadLine();
//string replace = "";
//foreach (var item in word) replace += "*";
//text = text.Replace(word,replace);
//Console.WriteLine(text);

//Console.Write("Введите строку:");
//string text = Console.ReadLine();
//string[] mas = text.Split(' ');
//double x = .7;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Contains(',')) Console.WriteLine(double.Parse(mas[i]).GetType());
//    else Console.WriteLine(int.Parse(mas[i]).GetType());
//}

//Console.Write("Введите строку ключевых слов через запятую:");
//string keyText = Console.ReadLine();
//Console.Write("Введите текст для проверки:");
//string text= Console.ReadLine();
//string[] keys = keyText.Split(',');
//foreach(string key in keys)
//{
//    if (text.Contains(key)) Console.WriteLine(key);
}