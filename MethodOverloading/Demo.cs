using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Demo
    {
        private int b = 10;
        public void fun(int a)
        {
            int i = a + b;
            Console.WriteLine(i);
        }
        public void fun(string s)
        {
            Console.WriteLine(s);
        }
        public void fun(int j, string d)
        {
            Console.WriteLine(d + " age is " +j );
        }
    }
}
