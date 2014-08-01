using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyYieldReturnNotAlwaysAGoodIdea
{
    public class SampleEntity
    {
        public String Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Boolean Active { get; set; }

        public bool Validate(SampleValidator validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            //return !brokenRules.Any();
            return brokenRules.Count() == 0;
        }

    }
}
