using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace lesson4
{
    public static class StaticClass
    {
        public static void Print(int[] arr)
        {
            Program p = new Program();
            p.result(arr);
        }

        public static void arr(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);
                string[] ss = File.ReadAllLines(filename);
                Console.WriteLine(ss.Length);
            }

        }

    }
}
