using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    class Hinhtron
    {
        private double r;
        public Hinhtron(double r)
        {
            this.r = r;
        }
        public double dienTich()
        {
            return 3.14 * r * r;
        }
    }
    class Hinhtru : Hinhtron
    {
        double d;
        public Hinhtru(double r, double d) : base(r)
        {
            this.d = d;
        }
        public double thetich()
        {
            return d * dienTich();
        }
    }

    class HinhCN
    {
        double cd, cr;
        public HinhCN(double cd, double cr)
        {
            this.cd = cd;
            this.cr = cr;
        }
        public double chuvi()
        {
            return (cd + cr) * 2;
        }
        public double dientich()
        {
            return cd * cr;
        }
    }

    class HinhHop : HinhCN
    {
        double d;
        public HinhHop(double cd, double cr, double d) : base(cd, cr)
        {
            this.d = d;
        }
        public double thetich()
        {
            return d * dientich();
        }
        public double dientichXQ()
        {
            return d * chuvi();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            /* Hinhtru d = new Hinhtru(6, 10);
             Console.WriteLine("dien tich hinh tron {0}", d.dienTich());
             Console.WriteLine("the tich hinh tru {0}", d.thetich());*/

            HinhCN cn = new HinhCN(3, 4);
            Console.WriteLine("Chu vi va dien tich hinh chu nhat: {0} va {1}", cn.chuvi(), cn.dientich());

            HinhHop hop = new HinhHop(3, 4, 5);
            Console.WriteLine("The tich va dien tich xung quang hinh chu nhat: {0} va {1}", hop.thetich(), hop.dientichXQ());
        }
    }
}