using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pincode
{
    public class regexPattern
    {
        public static string pincodeUC1 = "^[1-9][0-9]{5}$";
        public static string pincodeUC2 = "^!([A-Z][.|!|@|#|$|%|^|&|*]?)[1-9][0-9]{5}$";
        public static string pincodeUC3 = "^[1-9][0-9]{5}!([A-Z][.|!|@|#|$|%|^|&|*]?)$";
        public static string pincodeUC4 = "^[1-9][0-9]{2}[  ][0-9]{3}$";
        public static string emailValidation = "^[a-zA-Z]{3,}([.|#|+|_|-]?[a-zA-Z0-9]+)?[@]{1}[a-zA-Z0-9]+([.]{1}[a-zA-Z]{2,4})?[.]{1}[a-zA-Z]{2,4}$";
        public String Name;

        public Match NameCheck(string Name, string pattern)
        {
            this.Name = Name;
            return Regex.Match(Name, pattern);
        }

        public bool InputCheck(string input, int n)
        {
            if (n == 1)
            {
                return Regex.IsMatch(input, pincodeUC1);
            }
            if (n == 2)
            {
                return Regex.IsMatch(input, pincodeUC2);
            }
            if (n == 5)
            {
                return Regex.IsMatch(input, emailValidation);
            }
            if (n == 4)
            {
                return Regex.IsMatch(input, pincodeUC4);
            }
            else
            {
                return Regex.IsMatch(input, pincodeUC3);
            }

        }



    

}
}
