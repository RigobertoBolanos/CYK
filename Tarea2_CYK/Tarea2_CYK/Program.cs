using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_CYK
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vista());
            //List<string> variable1 = new List<string>();
            //variable1.Add("S");
            //variable1.Add("AB");
            //variable1.Add("BC");

            //List<string> variable2 = new List<string>();
            //variable2.Add("A");
            //variable2.Add("BA");
            //variable2.Add("a");

            //List<string> variable3 = new List<string>();
            //variable3.Add("B");
            //variable3.Add("CC");
            //variable3.Add("b");

            //List<string> variable4 = new List<string>();
            //variable4.Add("C");
            //variable4.Add("AB");
            //variable4.Add("a");

            //List<List<string>> grammar1 = new List<List<string>>();
            //grammar1.Add(variable1);
            //grammar1.Add(variable2);
            //grammar1.Add(variable3);
            //grammar1.Add(variable4);

            //Console.WriteLine(CYK.doCYK(grammar1, "baaba"));
        }
    }
}
