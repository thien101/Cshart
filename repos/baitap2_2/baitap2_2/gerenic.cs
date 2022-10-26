using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2_2
{
    class gerenic<A, B>
    {
        A x;
        B y;
        public gerenic(A x, B y)
        {
            this.x = x;
            this.y = y;
        }
        public A getx()
        {
            return x;
        }

        public B gety()
        {
            return y;
        }
    }
}
