﻿using System;

namespace UserResgistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1. Validate first name \n2. Validate last name \n3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    //case 1:
                    //    Console.WriteLine("*First letter should be capital.");
                    //    Console.WriteLine("*length should be Minimum three characters.");
                    //    Console.WriteLine("Enter First name :");
                    //    string fname = Console.ReadLine();

                    //    Validation_regex Checkpattern = new Validation_regex();
                    //    Checkpattern.Checkfirstname(fname);
                    //    break;
                    case 2:
                        Console.WriteLine("*Last letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter Last name :");
                        string lname = Console.ReadLine();
                        Validation_regex lnamepattern = new Validation_regex();
                        lnamepattern.Checklastname(lname);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
        }
    }
}
