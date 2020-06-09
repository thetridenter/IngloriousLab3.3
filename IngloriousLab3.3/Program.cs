using System;
using System.IO;

namespace IngloriousLab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipath = @"/Users/kostiantyn/Desktop/University/Object_Oriented_Programming/Assets/Lab3/input.txt";
            string opath = @"/Users/kostiantyn/Desktop/University/Object_Oriented_Programming/Assets/Lab3/output.txt";

            StreamReader ifile = new StreamReader(ipath);
            FileInfo ofile = new FileInfo(opath);

            string s = ifile.ReadToEnd();
            string[] wordbyword = s.Split(' ');
            int n = wordbyword.Length;

            Console.WriteLine("Файл прочитано");

            StreamWriter sw;

            if (ofile.Exists)
            {
                ofile.Delete();
            }

            sw = ofile.CreateText();
            sw.Write("Кількість символів у файлі input.txt = " + s.Length);
            sw.WriteLine("Кількість слів у файлі input.txt =" + n);
            sw.Close();

            Console.WriteLine("Кількість символів у файлі input.txt = " + s.Length);
            Console.WriteLine("Кількість слів у файлі input.txt =" + n);
        }
    }
}
