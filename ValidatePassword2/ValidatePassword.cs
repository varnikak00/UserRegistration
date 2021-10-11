using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidatePassword2
{
    class ValidatePassword
    {
        public string Pattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@$#!%^&*()])[a-z0-9A-Z@$#!%^&*()]{8,}$";
        public bool PasswordCheck(string Pass)
        {
            return Regex.IsMatch(Pass, Pattern);
        }

    }
}
