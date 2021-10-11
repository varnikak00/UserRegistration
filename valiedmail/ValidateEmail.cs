using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace valiedmail
{
    class ValidateEmail
    {
        public string Pattern = "^[a-z0-9.]{3,25}(@)[a-z.]{2,25}$";
        public bool ValidateEmailCheck(string email)
        {
            return Regex.IsMatch(email, Pattern);
        }

    }
}
