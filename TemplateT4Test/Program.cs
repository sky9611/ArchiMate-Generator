using System;
using ArchiLibrary;
using System.Collections.Generic;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //new CodeGeneratorTest().TestMethod();
            //// Allow user to see the output:
            //Console.ReadLine();
            MultiMap<String> mmap = new MultiMap<String>();
            mmap.Add("A", "B");
            mmap.Add("A", "C");
        }
    }
}