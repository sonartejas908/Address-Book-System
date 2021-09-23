using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    public class AddNewPerson
    {
        public static List<Person> People = new List<Person>();

       

        public static void AddPerson()
        {
            Person person = new Person();
            Console.Write("Enter First Name :");
            person.Fname = Console.ReadLine();
            Console.Write("Enter Last Name :");
            person.Lname = Console.ReadLine();
            Console.Write("Enter Address :");
            person.Address = Console.ReadLine();
            Console.Write("Enter City :");
            person.City = Console.ReadLine();
            Console.Write("Enter State :");
            person.State = Console.ReadLine();
            Console.Write("Enter ZipCode :");
            person.ZipCode = Console.ReadLine();
            Console.Write("Enter Phone Number :");
            person.PhonNumber = Console.ReadLine();
            Console.Write("Enter Email :");
            person.Email = Console.ReadLine();

        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name :"+person.Fname);
            Console.WriteLine("Last Name :"+person.Lname);
            Console.WriteLine("Address :"+person.Address);
            Console.WriteLine("City :"+person.City);
            Console.WriteLine("State :"+person.State);
            Console.WriteLine("Zip Code :"+person.ZipCode);
            Console.WriteLine("Phone Number :"+person.PhonNumber);
            Console.WriteLine("Email :"+person.Email);
        }

        public static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Address Book is empty. Press any key to continue ");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are current people in your address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\n Press any key to continue.");
            Console.ReadKey();

        }

        public static void RemovePerson()
        {
            Console.WriteLine("Enter the First name of person you wants to remove");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.Fname.ToLower() == firstName.ToLower());
        
            if (person == null)
            {
                Console.WriteLine("Person could not be found. press any key to continue");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Are you sure you want to remove this person? (Y/N) ");
                PrintPerson(person);

                if(Console.ReadKey().Key == ConsoleKey.Y)
                {
                    People.Remove(person);
                    Console.WriteLine("Person removed. Press any key to continue");
                    Console.ReadKey();
                }
            }
        
        }


    }
}

