using System;

namespace BootcampDotNET.Lesson3.HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please enter your email: ");
        var CustomerEmail = Console.ReadLine();
        var checker = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789@.";
        for (int i = 0; i < CustomerEmail.Length; i++)
        {
        if (CustomerEmail.Contains(checker))
            i = i + 0;
        else Console.WriteLine(CustomerEmail[i]);
        }
        }
    }
}