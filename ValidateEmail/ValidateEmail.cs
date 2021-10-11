using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateEmail
{
    class ValidateEmail
    {
        public string Pattern = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool ValidateEmailCheck(string email)
        {
            return Regex.IsMatch(email, Pattern);
        }
    }
}
