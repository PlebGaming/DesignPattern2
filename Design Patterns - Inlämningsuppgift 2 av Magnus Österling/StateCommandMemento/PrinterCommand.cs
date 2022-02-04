using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class PrinterCommand : ICommand
    {
        public string output { get; set; }

        public void Do()
        {
            Console.WriteLine(output);
        }
    }
}
