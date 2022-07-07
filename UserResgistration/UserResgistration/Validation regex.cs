using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserResgistration
{
    internal class Validation_regex
    {
        public void Checkfirstname(string firstname)
        {
            string Firstnamepattern = "^[A-Z][a-z]{3,10}$";
            if (Regex.IsMatch(firstname, Firstnamepattern))
                Console.WriteLine("First Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
    }
}
