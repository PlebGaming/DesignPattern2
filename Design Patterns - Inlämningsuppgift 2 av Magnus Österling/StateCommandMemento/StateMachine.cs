using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class StateMachine
    {
        private Printer printer;
        public IState CurrentState { get; set; }

        public StateMachine(Printer printer)
        {
            this.printer = printer;
            CurrentState = new PrinterOff(printer);
        }
        public void SetState()
        {
            if (CurrentState.GetType() == typeof(PrinterOff))
            {
                CurrentState = new PrinterOn(printer);
                Console.WriteLine("Printer is now on");
            }
            else
            {
                CurrentState = new PrinterOff(printer);
                Console.WriteLine("Printer is now off");
            }
        }

        public void Print(ICommand command)
        {
            CurrentState.Print(command);
        }
    }
}
