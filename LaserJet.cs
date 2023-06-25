using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_10
{
    public class Laserjet : IPrinter
    {
        void IPrinter.Print(Printer printer)
        {
            Console.WriteLine("LasetJet printer printing....");
        }

        void IPrinter.Show(Printer printer)
        {
            Console.WriteLine("LasetJet display dimension : 11*12");
        }
    }
}