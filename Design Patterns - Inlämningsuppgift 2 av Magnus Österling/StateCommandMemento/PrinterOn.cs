using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class PrinterOn : IState
    {
        Printer printer;
        public PrinterOn(Printer printer)
        {
            this.printer = printer;            
            while (printer.toPrint.Count > 0)
            {
                Print(printer.toPrint.Dequeue());                
            }
        }

        public void Print(ICommand command)
        {
            command.Do();
        }
    }
}
