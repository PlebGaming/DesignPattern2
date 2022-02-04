using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public interface ICommand
    {
        public string output { get; set; }
        void Do();
    }
}
