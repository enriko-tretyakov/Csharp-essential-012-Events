using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void MyDelegate(string str);

        public static event MyDelegate TextAdd;

        static void Main(string[] args)
        {
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    if (TextAdd != null) TextAdd.Invoke(str);
                }
            }
        }
    }
}