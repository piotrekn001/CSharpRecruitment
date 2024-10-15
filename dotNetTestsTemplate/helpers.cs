using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetTestsTemplate
{
    public class Helpers
    {
        public static string InsertParameterToXpath(string xpath, string parameter)
        {
            string xpathWithParameter = xpath.Replace("{parameter}", parameter);
            return xpathWithParameter;
        }
    }
}
