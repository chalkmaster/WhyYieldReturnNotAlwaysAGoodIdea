using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyYieldReturnNotAlwaysAGoodIdea
{
    public class SampleValidator
    {
        public IEnumerable<String> BrokenRules(SampleEntity entityToValidate) {
            System.Diagnostics.Debug.WriteLine("passed through here!");

            if (String.IsNullOrWhiteSpace(entityToValidate.Name))
            {
                System.Diagnostics.Debug.WriteLine("a name error :(");
                yield return "name can't be null";
            }

            if (DateTime.Now.Year - entityToValidate.BirthDate.Year < 18)
            {
                System.Diagnostics.Debug.WriteLine("too yong <o>");
                yield return "must be adult";
            }

            if (!entityToValidate.Active)
            {
                System.Diagnostics.Debug.WriteLine("not activated yet >(");
                yield return "must be active";
            }
        }
    }
}
