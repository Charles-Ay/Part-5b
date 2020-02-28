using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5b
{
    class Program
    {
        static void Main(string[] args)
        {

            int ageN;
            string age;
            int categoryNum;
            string category;
            string userNumber;
            Random gen = new Random();
            int rand;
            int userNumberI;

            Console.WriteLine("Enter your age");
            age = Console.ReadLine();
            ageN = Convert.ToInt32(age);

            if (ageN < 0)
            {
                Console.WriteLine("Your're not born yet");
            }
            else if (ageN <= 5)
            {
                Console.WriteLine("Toddler");
            }
            else if (ageN <= 10)
            {
                Console.WriteLine("Child");
            }
            else if (ageN <= 12)
            {
                Console.WriteLine("Preteen");
            }
            else if (ageN > 12 && ageN <= 18)
            {
                Console.WriteLine("Teen");
            }
            else
            {
                Console.WriteLine("Adult");
            }

            Console.WriteLine("Enter Hurricane Category");
            category = Console.ReadLine();
            categoryNum = Convert.ToInt32(category);

            switch (categoryNum)
            {
                case 1:
                    Console.WriteLine("74  - 95 mph or 64 - 85 kt or 119 - 153 km/h");
                    break;
                case 2:
                    Console.WriteLine("96  - 110 mph or 83 - 95 kt or 154 - 177 km/h");
                    break;
                case 3:
                    Console.WriteLine("111  - 130 mph or 96 - 113 kt or 178 - 209 km/h");
                    break;
                case 4:
                    Console.WriteLine("131  - 155 mph or 114 - 135 kt or 210 - 249 km/h");
                    break;
                case 5:
                    Console.WriteLine("Greater than 155 mph or 135 kt or 249 km/hr");
                    break;
            }

            Console.WriteLine("Enter a a number larger than the random number");
            userNumber = Console.ReadLine();
            userNumberI = Convert.ToInt32(userNumber);

            rand = gen.Next(1, 7);
            if (rand % userNumberI == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }





        }
    }
}
