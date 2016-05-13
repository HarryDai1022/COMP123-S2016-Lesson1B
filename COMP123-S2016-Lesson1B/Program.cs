using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Harry Dai
 * Date: 2016/05/13
 * Student ID: 300839401
 * 
 * Descriptions: THis program demonstrates GitHub and version control best pratices.
 * 
 * Version: 0.2 - Added GetUserName method
 */

namespace COMP123_S2016_Lesson1B
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
         * This method gets the user name from the console
         * 
         * @method GetUserName
         * @returns (string) UserName
         */
        public static string GetUserName()
        {
            //Initialize variables
            string UserName = "";
            
            Console.Write("Enter user name: ");
            UserName = Console.ReadLine();

            Console.WriteLine("/n*************************");
            Console.WriteLine("You entered: " + UserName);

            return UserName;
        }
    }
}
