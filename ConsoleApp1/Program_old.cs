using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public event EventHandler TextAdd;

        static void Main(string[] args)
        {
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
            }
        }
    }
}
