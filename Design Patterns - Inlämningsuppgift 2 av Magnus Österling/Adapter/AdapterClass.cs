using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    internal class AdapterClass
    {
        public void Print()
        {
            ReturningStrings returningStrings = new ReturningStrings();
            PrintingInts printingInts = new PrintingInts();

            var value = Int32.Parse(returningStrings.ReturnString());

            printingInts.Print(value);
        }
    }
}
