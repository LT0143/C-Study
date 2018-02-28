using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
   public class PrintTool
    {
        public static void PrintIEnumerable<t>(IEnumerable<t> items)
        {
            foreach (t item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
 
