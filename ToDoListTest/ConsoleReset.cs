using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListTest
{
    public static class ConsoleReset
    {
        private static readonly TextWriter testWriterout = Console.Out;
        private static readonly TextReader testWriterin = Console.In;
     
        public static void ResetConsole()
        {
            Console.SetOut(testWriterout);
            Console.SetIn(testWriterin);
        }
      
    }
}
