using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Static.Helper
{
    internal static Helper
    {
        public string EditText(string text)
        {
            string result = text.Replace("?"," ");
            return result;
        }
    }
}
