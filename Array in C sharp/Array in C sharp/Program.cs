using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_in_C_sharp
{
    class Program
    {
        private String[] pandavas;
        
        static void Main(string[] args)
        {
            ArrayDemo arrayDemo = new ArrayDemo();
            Program program = new Program();
            program.pandavas = arrayDemo.getPandavasNames();
            program.printPandavaNames();
        }
        
        private void printPandavaNames()
        {
            for(int i =0;i<pandavas.Length;i++)
            {
                Console.WriteLine("Name "+i+": "+pandavas[i]);
            }
        }
    }
}
