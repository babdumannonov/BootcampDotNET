using System;
using System.Linq;

namespace BootcampDotNET.Lesson3.HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passwordda sonlar qatnashsinmi? Ha bo'lsa 1 ni yoq bolsa 0 ni bosing: ");
            var password = Console.ReadLine();
            Console.WriteLine("Passwordda harflar qatnashsinmi? Ha bo'lsa 1 ni yoq bolsa 0 ni bosing: ");
            var harflar = Console.ReadLine();
            Console.WriteLine("Passwordda simvollar qatnashsinmi? Ha bo'lsa 1 ni yoq bolsa 0 ni bosing: ");
            var simvollar = Console.ReadLine();
            Console.WriteLine("Passwordni uzunligini kiriting: ");
            var passwordLength = int.Parse((Console.ReadLine()));

            var Number = false;
            var String = false;
            var Simvollar1 = false;

            if (password != "0")
                Number = true;
            if (harflar != "0")
                String = true;
            if (simvollar != "0")
                Simvollar1 = true;

            var random = new Random();
            var PasswordResult = string.Empty;
            const string Harflar = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            const string Digitlar = "0123456789";
            const string simvollar2 = "!@#$%^&*()-_=+<,>.";

            while (true)
            {
                if (passwordLength == 0)
                    break;
                if (Number)
                    PasswordResult = PasswordResult + Digitlar[random.Next(Digitlar.Length)];
                if (PasswordResult.Length == passwordLength)
                    break;
                if (String)
                    PasswordResult += Harflar[random.Next(Harflar.Length)];
                if (PasswordResult.Length == passwordLength)
                    break;
                if (Simvollar1)
                    PasswordResult += simvollar2[random.Next(simvollar2.Length)];
                if (PasswordResult.Length == passwordLength)
                    break;
            }
            Console.WriteLine(PasswordResult);
        }
    }
}