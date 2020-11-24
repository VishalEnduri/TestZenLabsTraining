using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Sample
    {
        public static void Main(string[] args)
        {
            Demo d = new Demo();
            d.fun(10);
            d.fun("Raj");
            d.fun( 24 , " Vishal ");
        }
    }
}
