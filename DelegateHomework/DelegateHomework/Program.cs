using System;

namespace DelegateHomework
{
    public delegate void Func(string text);
    class Run
    {
        public void RunFunc(Func func,string text)
        {
            func(text);
        }
    }
    class MyClass
    {
        public void Space(string str)
        {
            Console.WriteLine("------- Space -------");
            Console.WriteLine($"Before: {str}");
            string[] newStr = new string[str.Length * 2 - 1];
            newStr[0] = str[0].ToString();
            for (int i = 1; i < newStr.Length; i++)
            {
                if (i % 2 == 1)
                    newStr[i] = "_";
                else
                    newStr[i] = str[i / 2].ToString();

            }
            Console.Write("After: ");
            foreach (var s in newStr)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }
        public void Reverse(string str)
        {
            Console.WriteLine("------- Reverse -------");
            Console.WriteLine($"Before: {str}");
            string[] newStr = new string[str.Length];
            for (int i = 0, j = str.Length - 1; i < newStr.Length; i++, j--)
            {
                newStr[i] = str[j].ToString();
            }
            Console.Write("After: ");
            foreach (var s in newStr)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            var str = Console.ReadLine();
            MyClass my = new MyClass();
            Func funcDell = new Func(my.Space);
            funcDell += my.Reverse;
            Run run = new();
            run.RunFunc(funcDell, str);
        }
    }
}
