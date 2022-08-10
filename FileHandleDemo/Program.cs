using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPSConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHand Call = new FileHand();
           // Call.WriteFile();
            Call.ReadFile();
        }
    }
}