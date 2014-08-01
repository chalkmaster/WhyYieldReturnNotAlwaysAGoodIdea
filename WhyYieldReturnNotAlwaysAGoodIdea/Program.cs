using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyYieldReturnNotAlwaysAGoodIdea
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Diagnostics.Trace.Listeners.Add(new System.Diagnostics.ConsoleTraceListener());

            var entity = new SampleEntity { BirthDate = DateTime.Now};
            var validator = new SampleValidator();
            IEnumerable<string> brokenRules;

            if (!entity.Validate(validator, out brokenRules)) {
                foreach (var errorMessage in brokenRules)
                    Console.WriteLine(errorMessage);
            }

            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
