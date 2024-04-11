int n,m;

do
{
    FileStream fs = null;
   
    try
    {
        Console.Write("Введите 1 число:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Введите 2 число:");
        m = int.Parse(Console.ReadLine());
        if (n < m) throw new ArithmeticException();
        int div = n / m;
        Console.WriteLine(div);
        int[] mas=new int[10];
        mas[8] = 10;
        Console.Write("Введите строку длиной 7 символов:");
        string str = Console.ReadLine();
        if (str.Length != 7) throw new Exception();
        fs = File.OpenRead("file.txt");
        break;
    }
    catch(FormatException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine(e.Message);
    }
    catch(IndexOutOfRangeException e)
    {
        Console.WriteLine(e.Message);
    }
    catch(InvalidCastException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (ArithmeticException)
    {
        Console.WriteLine("Числитель должен быть больше знаменателя");
    }
    catch(IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception)
    {
        Console.WriteLine("Длина должна быть 7 символов");
    }
    finally
    {
        fs.Close();
    }
}
while (true);
