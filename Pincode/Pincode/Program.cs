using System;

namespace Pincode
{
    class Program
    {
        static void Main(string[] args)
        {
            regexPattern obj1 = new regexPattern();
            Console.WriteLine(" 1. Pincode UC1 \n 2. Pincode UC2 \n 3. Pincode UC3 \n 4. Pincode UC4 \n 5. email Validation \n");
            Console.WriteLine("Enter your choice");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(obj1.InputCheck("400088", 1));
                    break;
                case 2:
                    Console.WriteLine(obj1.InputCheck("A400088", 2));
                    break;
                case 3:
                    Console.WriteLine(obj1.InputCheck("400088B", 3));
                    break;
                case 4:
                    Console.WriteLine(obj1.InputCheck("400 088", 4));
                    break;
                case 5:
                    Console.WriteLine(obj1.InputCheck("abc.100@gmail.co.in", 5));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
