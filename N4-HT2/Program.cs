using System;

namespace UsernameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ism va sharifingizni kiriting: ");
            string input = Console.ReadLine();

            string username = GenerateUsername(input);
            Console.WriteLine("Username: " + username);

            Console.ReadLine();
        }

        static string GenerateUsername(string input)
        {
            // Username ni kichik harflarga o'tkazamiz
            string username = input.ToLower();

            // Whitespace va boshqa belgilarni olib tashlaymiz
            username = username.Replace(" ", "").Replace(".", "").Replace("-", "");

            //takrorlanmaydigan son qo'shamiz
            int counter = 1;
            string originalUsername = username;

            while (IsUsernameTaken(username))
            {
                // Usernamega son qo'shamiz
                username = originalUsername + counter;
                counter++;
            }

            return username;
        }

        static bool IsUsernameTaken(string username)
        {
            string[] takenUsernames = { "user1", "user2", "user3" };

            foreach (string takenUsername in takenUsernames)
            {
                if (takenUsername == username)
                {
                    return true;
                }
            }

            return false;
        }
    }
}