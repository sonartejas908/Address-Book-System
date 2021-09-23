using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class WelcomeMessage
    {
        public static void Welcome()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Welcome To Address Book");
            Console.WriteLine("=====================================");
        }

        public static void DisplayMsg()
        {
            Console.WriteLine("Please Select Below \n Press 1 to Add Contact ");
            Console.WriteLine("Press 2 to Remove Contact");
            Console.WriteLine("Press 3 to view Contact");
        }
    }
}
