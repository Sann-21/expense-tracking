using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Expense_Tracking
{
    class register
    {
        //checking the username
        public bool IsAlphaNumeric(String strTocheck)
        {
            Regex objAlphaNumeric = new Regex("[^a-zA-Z0-9]");
            return !objAlphaNumeric.IsMatch(strTocheck);
        }

        //checking the password
        public bool IsPasswordValid(String strTocheck)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            bool valid = true;
            if (!hasLowerChar.IsMatch(strTocheck))
            {
                valid = false;
            }
            else if (!hasUpperChar.IsMatch(strTocheck))
            {
                valid = false;
            }
            else if (!hasMiniMaxChars.IsMatch(strTocheck))
            {
                valid = false;
            }

            return valid;

        }
    }
}
