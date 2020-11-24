using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticFunWithReturnType
{
    public class Demo
    {
        private int i = 25;
        private string n = "Naveen";
        private double d = 5000;
        public int fun1()
        {
            return i;
        }
        public string fun2()
        {
            return n;
        }
        public double fun3()
        {
            return d;
        }
    }
}
