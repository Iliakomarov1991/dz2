using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 52;
            int row = 3;
            Console.WriteLine("Count of rows: "+summ/row);
            Console.WriteLine("Paints left: " + summ % row);


        }
    }
}
