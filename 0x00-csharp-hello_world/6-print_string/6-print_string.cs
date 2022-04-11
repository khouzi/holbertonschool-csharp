using System;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string t = new StringBuilder(str.Length * 3).Insert(0, str, 3).ToString();
        string k = str.Substring(0, 9);
		Console.WriteLine("{0}\n{1}", t, k);
        }
}