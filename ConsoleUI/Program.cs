using System;
using System.Collections.Generic;
using GuestBookLibrary.Models;



// capture info about each guest (assumtion is at least one guest and unknown maximum)
//info to capture: First name, Last name, message to host
//once done, loop through each guest and print their info



namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();         
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                
                guest.FirstName = GetInfoFromConsole("What is your first name: ");                
                guest.LastName = GetInfoFromConsole("what is your last name: ");       
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");   
                moreGuestsComing = GetInfoFromConsole("are more gusts comming?? (yes/no): ");

                guests.Add(guest);

                Console.Clear();


            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {

            string output = "";
            Console.Write(message);
            output = Console.ReadLine();

            return output;

        }
    }
}
