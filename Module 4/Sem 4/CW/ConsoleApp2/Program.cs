using System;
using System.Collections;

namespace ConsoleApp2
{
    class MyClass
    {
        char[] chrs = { 'A', 'B', 'C', 'D' };
        public System.Collections.IEnumerable GetEnumerator()
        {
            foreach (char ch in chrs)
                yield return ch;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int yield 
            MyClass mc = new MyClass();
            foreach (char ch in mc)

        }
    }
}
