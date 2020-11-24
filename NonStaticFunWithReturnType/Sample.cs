using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticFunWithReturnType
{
    class Sample
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            double s = d.fun3();
            Console.WriteLine("Vishal salary is " + s);
            
        }
    }
}
