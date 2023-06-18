using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    internal class MyValidator
    {
        public static bool validate(string type, string val)
        {
            // Email regex.
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            // PhoneNum regex.
            if (type.Equals("mobile"))
            {
                regex = new Regex(@"^(\d{3})-(\d{3})-(\d{4})$");
            }


            Match match = regex.Match(val);

            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }
}
