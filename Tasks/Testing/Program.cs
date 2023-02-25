

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

 

namespace ConsoleApplication8

{

    class Program

    {

        static void Main(string[] args)

        {

            string str1;

            string str2 = "xyz&123";
            str1 = Console.ReadLine()!;
 

            string[] array = { str1, str2 };

            StringBuilder sb = new StringBuilder();

            foreach (string str in array)

            {

                if (System.Text.RegularExpressions.Regex.IsMatch(str, @"^[a-zA-Z0-9]^[!£$%^&*()-_=+]{1,20}$"))
                    sb.AppendLine("Example \"" + str + "\" is an alphanumeric string.");
                    
                else

                    sb.AppendLine("Example \"" + str + "\" is NOT an alphanumeric string.");

            }

            Console.WriteLine(sb);

        }

    }

}
