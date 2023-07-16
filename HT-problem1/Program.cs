using System.Globalization;

using System;

namespace BootcampDotNET.Lesson2.HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
        }

        public static void First()
        {
            // 1 - misol

            //ismni kiritishni sorash
            Console.Write("Enter your FirstName: ");
            //ismni kiritish
            var ism = Console.ReadLine();
            //familiyani kiritishni sorash
            Console.Write("Enter your LastName: ");
            //familiyani kiritish
            var familiya = Console.ReadLine();
            //yoshni kiritishni sorash
            Console.Write("Enter your Age: ");
            //yoshni kiritish
            var age = Console.ReadLine();

            //natijani ekranga chop etish
            Console.WriteLine("FirstName: {0},  LastName: {1},  Age: {2}", ism, familiya, age);//bu yerda men string.format tipidan foydalandim..)


        }
        public static void Second()
        {
            // 2 - misol

            //datetimedan bugungi sanani chaqirib olish
            DateTime bugun = DateTime.Today.Date;
            //bugungi sanani ekranga chiqarish
            Console.WriteLine(bugun.ToString("d"));

            //string
            string yil_sana = "1970-yil 1-yanvaar";
            Console.WriteLine(yil_sana);

            //yoshni int va string tipida ekranga chiqarish
            var intyosh = 75;
            var stryosh = "yosh";
            Console.WriteLine(string.Format("{0} {1}", intyosh, stryosh));

            //dollarni float va string tipida ekranga chiqarish
            float dollar = 35.5f;
            string dollar2 = "$";
            Console.WriteLine(string.Format("{0} {1}", dollar, dollar2));

            //string
            string maxdev = "Max Developer";
            Console.WriteLine(maxdev);

        }
        public static void Third()
        {
            //primitive
            string stringValue = "Botirjon";
            Console.WriteLine(stringValue);

            //complex

            DateTime fullEra = DateTime.Now;
            Console.WriteLine(fullEra);

            //value

            int number5 = 342;
            bool agar = true;

            Console.WriteLine(number5);
            Console.WriteLine(agar);

            //reference

            DateTime fullEras = DateTime.Now;
            Console.WriteLine(fullEras);




        }
        
    }

}