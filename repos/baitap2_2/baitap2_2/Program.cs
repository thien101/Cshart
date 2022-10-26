using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap2_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

/*    class ABC{
        public string chao()
        {
            return "Xin chao :))";
        }

        public string chao(string s)
        {
            return "Xin chao C# :))" +s;
        }
    }*/
}
