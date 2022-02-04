using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class PrinterMemento
    {
        public Printer printer;
        public PrinterMemento(Printer printer)
        {
            this.printer = printer;            
        }
    }
}
