using System;

namespace BootcampDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();

        }
        public static void Calculator()
        {

            Console.WriteLine("Enter a number:");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-\"* - multiply\"\n-\"/ - divide\"\n-\"+ - add\"\n-\"- - subtract\"\n-\"e - exit\"\nChoose only one character");
            string choose = Convert.ToString(Console.ReadLine());

            while (true)
            {
                if (choose != "e")
                {
                    Console.WriteLine("Enter second number:");
                    var number2 = Convert.ToInt32(Console.ReadLine());
                    var sum = 0;

                    switch (choose)
                    {
                        case "*":
                            sum = number1 * number2;
                            break;
                        case "/":
                            sum = number1 / number2;
                            break;
                        case "+":
                            sum = number1 + number2;
                            break;
                        case "-":
                            sum = number1 - number2;
                            break;
                        default: Console.WriteLine("Invalid process!");
                            break;
                    }
                    Console.WriteLine("Check:\nThe number you entered:{0}\nThe command you chose:{1}\nThe second number you entered:{2}\nResult:{3}", number1,choose,number2,sum);
                }
                Console.WriteLine("Thank you for using calculator!");
                break;
            }
        }

    }
}