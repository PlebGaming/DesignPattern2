using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Printer
    {

        StateMachine stateMachine;
        public Queue<ICommand> toPrint;
        bool running = true;
        public StateMachine StateMachine { get => stateMachine; set => stateMachine = value; }

        public Printer()
        {
            StateMachine = new StateMachine(this); 
            toPrint = new Queue<ICommand>();
            
        }
        public void Run()
        {            
            PrinterMemento savedPrinter = CreateMemento(new Printer());

            Console.WriteLine();
            Console.WriteLine("Press O to turn on/off the printer");
            Console.WriteLine("Press P to print");
            Console.WriteLine("Press R to restore");
            Console.WriteLine("Press F10 to exit!");
            while (running)
            {                
                var userinput = Console.ReadKey(true).Key;
                
                switch (userinput)
                {
                    case ConsoleKey.O:
                        StateMachine.SetState();
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Enter text to be printed please!");
                        ICommand command = new PrinterCommand();
                        var printInput = (Console.ReadLine());
                        
                        command.output = printInput;
                        StateMachine.Print(command);
                        break;
                    case ConsoleKey.R:
                        RestorePrinter(savedPrinter);
                        Console.WriteLine(savedPrinter.printer.toPrint.Count);
                        Console.WriteLine("Printer restored");
                        break;
                    case ConsoleKey.F10:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Guru Meditation");
                        break;
                }       
            }
        }
        public PrinterMemento CreateMemento(Printer printer)
        {
            return new PrinterMemento(printer);            
        }

        private void RestorePrinter(PrinterMemento printerMemento)
        {
            this.toPrint = new Queue<ICommand>(printerMemento.printer.toPrint);
        }
    }
}
