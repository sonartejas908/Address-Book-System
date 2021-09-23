using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage.Welcome();
            WelcomeMessage.DisplayMsg();

            int response = Convert.ToInt32(Console.ReadLine());

            switch (response)
            {
                case 1:
                    AddNewPerson.AddPerson();
                    Console.WriteLine("Contact saved successfully....");
                    Console.WriteLine("Do you want to add more? Y/N \n");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                        goto case 1;

                    break;
                case 2:
                    AddNewPerson.RemovePerson();
                    break;
                case 3:
                    AddNewPerson.ListPeople();
                    break;
            }
            


        }
    }
}
            
           
     
