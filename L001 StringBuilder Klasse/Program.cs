using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L001_StringBuilder_Klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings sind unveränderlich und jede Stringmanipulation sorgt dafür, dass ein neues 
            // String Objekt erschaffen wird. Bei vielen Operationen kostet dies viel Zeit: 
            var watch = new Stopwatch();
            string text = "";
            watch.Start();

            for (int i = 0; i < 50000; i++)
            {
                text += "x"; 
            }

            watch.Stop();
            Console.WriteLine($"Zeit: {watch.ElapsedMilliseconds} ms");
        }
    }
}
