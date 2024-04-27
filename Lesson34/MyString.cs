public class MyString
{
    private string str;
    public MyString(string s)
    {
        str = s;
    }
    public string Reverse()
    {
        string res = "";
        for (int i = str.Length - 1; i >= 0; i--) res += str[i];
        return res;
    }
    public bool IsPolindrom() => (Reverse() == str) ? true : false;
    public string[] Split(char c) => str.Split(c);
    public string[] Split(string c) => str.Split(c);
    public string ToUpper() => str.ToUpper();
    public string ToLower() => str.ToLower();
    public string[] Split(int index)
    {
        if (index >= 0 && index <= str.Length - 1)
        {
            char c = str[index];
            return str.Split(c);
        }
        else throw new Exception("Выход за гарницы строки");
    }
    public bool Find(string word) => str.Contains(word);
}