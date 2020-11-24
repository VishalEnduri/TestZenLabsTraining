using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_a_Relationship
{
    class Child : Parent
    {
        public void fun3()
        {
            int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine(" a+b = " +c);
        }
        public void fun4()
        {
            string y = "Shantan";
            Console.WriteLine(" My best friend name is " +y);
        }
    }
}
