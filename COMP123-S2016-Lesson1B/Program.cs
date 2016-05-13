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
 * Version: 0.4 - Extracted outputString to console from the GetUserName method
 */

namespace COMP123_S2016_Lesson1B
{
    /**
     * This is the driver class for our program
     * 
     * @class Program
     */
    class Program
    {
        /**
         * Main method for calss program
         * 
         * @param (string[] args)
         * @constructor Main
         */
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

            OutPutStringToConsole("Enter username: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n*************************");
            Console.WriteLine("You entered: " + UserName + "\n");

            return UserName;
        }
        /*
         * This method writes a string to the console. Parameters allow the user to add a newline character
         * 
         * @method OutPutStringToConsole
         * @param (string) outputString
         * @param (bool) hasNewLine
         * @return (string) outputString
         */
        private static string OutPutStringToConsole(string outputString, bool hasNewLine)
        {
            if(hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.Write(outputString);
            }

            Console.Write(outputString);

            return outputString;
        }
    }
}
