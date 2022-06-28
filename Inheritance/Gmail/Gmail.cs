using System;
using System.Collections.Generic;
using System.Text;

namespace Gmail
{
    class Gmail
    {

        public static string EmailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public static string PasswordRegex = @"^[a-zA-z0-9]{8,}";


        public bool Email()
        {
           return Regex.ISMat("sadigfn@code..edu.az", EmailRegex);
         }

        public bool Password()
        {
           return Regex 
        }
    
}
