namespace ArrrayLibrary
{
    public class ArrayClass
    {
        private Type type;
        private int length;
        public ArrayClass(Type t, int l)
        {
            this.type = t;
            this.length = l;
        }

        public void Fill(int low,int high)
        {
            Random random = new Random();
            if (type==typeof(int))
            {
                int[] mas = new int[length];
                for (int i = 0; i < length; i++)
                {
                    mas[i] = (int)random.Next(low, high);
                    Console.Write(mas[i]+" ");
                }
            }
            else if (type == typeof(double))
            {
                double[] mas = new double[length];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = (double)random.NextDouble()*(low+high)-high;
                    Console.Write(mas[i].ToString("F2") + " ");
                }
            }
        }

        public void Fill(int high)
        {
            Random random = new Random();
            if (type == typeof(string))
            {
                string[] mas = new string[length];
                for (int i = 0; i < mas.Length; i++)
                {
                    string res = String.Empty;
                    for (int j = 0; j < high; j++)
                        res += (char)random.Next(60, 127);
                    mas[i] = res;
                    Console.Write(mas[i] + " ");
                }
            }
            else if (type == typeof(bool))
            {
                bool[] mas = new bool[length];
                for (int i = 0; i < mas.Length; i++)
                {
                    if (random.Next(0, 2) == 0) mas[i] = false;
                    else mas[i] = true;
                    Console.Write(mas[i] + " ");
                }
            }
        }
    }
}