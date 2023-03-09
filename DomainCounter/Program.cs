using System;

namespace DomainCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Expected output
            /////////////////////
            //gmail - 3
            //yahoo - 2
            //abc - 2
            //hotmail - 1
            //END PROGRAM
            /////////////////////

            Console.WriteLine("START PROGRAM");
            var userInputEmails =
                "aa@gmail.com; " +
                "cc@yahoo.com; " +
                "bb@hotmail.com; " +
                "oo@gmail.com;" +
                "dd@gmail.com;" +
                " aa@gmail.com; " +
                "bb@hotmail.com;" +
                "cc@yahoo.com;" +
                " dd@abc.com; " +
                "bb@abc.com;" +
                " dd@abc.com;" +
                "  oo@gmail.com;" +
                "bbh@yahoo.com ";

            PrintEmailDomainOccurences(userInputEmails);
            Console.WriteLine("END PROGRAM");
        }


        /// <summary>
        ///PROBLEM:
        /// This method is supposed to extract domain for each email and to print the number of appereances for each domain as follows: 
        /// Order to display should be descending by number of occurences for each domain
        /// Duplicated emails should not have the domain counted twice         
        /// Please pay attention to remove unwanted empty spaces in each email
        /// Separator used for input is always ";"
        /// 
        /// 
        /// OUTPUT
        /// *****************************************************
        /// Domain: "domain_x" - "nr of occurences for 'domain_x'"
        /// Domain: "domain_y" - "nr of occurences for 'domain_y'"
        /// Domain: "domain_z" - "nr of occurences for 'domain_z'"
        /// *****************************************************
        ///
        /// OUTPUT EXAMPLE
        /// *****************************************************
        /// Domain: "gmail" - 10
        /// Domain: "yahoo" - 8
        /// Domain: "hotmail" - 3
        /// *****************************************************

        /// </summary>
        /// <param name="userInputEmails">input containing list of emails</param>
        private static void PrintEmailDomainOccurences(string userInputEmails)
        {
            throw new NotImplementedException();
        }
    }
}
