using System;
using System.Collections.Generic;



//Ask for users name
//add the name to list of names
//Ask for users party count
//Add the party count to total
//print out all names
//print out total party number



namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> parties = new List<string>();
            int totalGuests = 0;
            
            string moreGuestsComing = "";
            do
            {
                
                string partyName = GetInfoFromConsole("What is your party/group name: ");

                parties.Add(partyName);

                totalGuests += GetPartySize();

                moreGuestsComing = GetInfoFromConsole("Do you want to add another guest(yes/no): ");

            } while (moreGuestsComing.ToLower() == "yes");

            Console.WriteLine();
            Console.WriteLine("Guest Parties at Event:");
            foreach (string name in parties)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine($"Total Guests: { totalGuests }");

            Console.ReadLine();
        }

        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;
            do
            {
                string partySizeText = GetInfoFromConsole("How big is your party size: ");

                isValidNumber = int.TryParse(partySizeText, out output);

            } while (isValidNumber == false);

            return output;
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();

            return output;
        }

    }
}
