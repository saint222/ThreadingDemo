using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var threadTest = new ThreadClass();
            threadTest.ShowThreads();
            Console.ReadLine();
        }
    }
}
