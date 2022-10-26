using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2_2
{
    internal class HCN
    {
        private double cd, cr;
        public HCN(double cd, double cr)
        {
            this.cd = cd;
            this.cr = cr;
        }

        public HCN()
        {
        }

        public double dientich()
        {
            return this.cd * this.cr;
        }

        public double chuvi()
        {
            return (this.cd + this.cr)*2;
        }
    }
}
