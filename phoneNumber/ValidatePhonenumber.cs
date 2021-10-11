using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace phoneNumber
{
    class ValidatePhonenumber
    {

        public string Pattern = "^[9]{1}[1]{1}[0-9]{10}$";
        public bool PhonenumberCheck(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, Pattern);
        }
    }
}
