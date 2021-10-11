using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidatePassWord
{
    class ValidatePassword
    {

        public string Pattern = "^[a-z0-9A-Z]{8,}$";
        public bool PasswordCheck(string Pass)
        {
            return Regex.IsMatch(Pass, Pattern);
        }
    }
}
