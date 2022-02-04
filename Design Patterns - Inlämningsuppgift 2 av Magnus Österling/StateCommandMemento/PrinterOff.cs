using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class PrinterOff : IState
    {
        Printer printer;
        public PrinterOff(Printer printer)
        {
            this.printer = printer;            
        }

        public void Print(ICommand command)
        {
            printer.toPrint.Enqueue(command);
        }
    }
}
