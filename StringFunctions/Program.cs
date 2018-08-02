using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main()
        {
            string name = "Dean \n";
            string quote = "\n This is what I said; \"When it looks that good, take it home!\"" + " \n \t tabbed on a new line\n";
            string fileName = @"C:\User\Documents";

            bool trueOrFalse = name.Contains("n");
            trueOrFalse = name.StartsWith("m");

            int length = name.Length;

            quote = quote.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Dean.\n ");
            sb.Append("My job is to program computers.\n");
            sb.Append("Computers talk to me.\n");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
