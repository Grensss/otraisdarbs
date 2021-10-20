using System;

namespace Otrais_drabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("What's your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hello, " + username + ".");

            //2
            Console.WriteLine("What's your age?");
            string agetext = Console.ReadLine();
            int age = int.Parse(agetext);
            int yearago = age + 1;
            if (age < 18)
            {
                Console.WriteLine("Next year you will be " + yearago + ", years old and you are underage");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Next year you will be " + yearago + ", years old and you are an adult");
            }

            //3
            Console.WriteLine("Enter two numbers to find out the larger value.");
            string firstmax = Console.ReadLine();
            string secondmax = Console.ReadLine();
            int firstx = int.Parse(firstmax);
            int secondx = int.Parse(secondmax);
            int maxres = Math.Max(firstx, secondx);
            Console.WriteLine(maxres);

            //4
            Console.WriteLine("Enter two numbers to find out the lesser value.");
            string firstmin = Console.ReadLine();
            string secondmin = Console.ReadLine();
            int firstn = int.Parse(firstmin);
            int secondn = int.Parse(secondmin);
            int minres = Math.Min(firstn, secondn);
            Console.WriteLine(minres);

            //5
            Console.WriteLine("Enter two numbers to find remainder of the division.");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int aa = int.Parse(a);
            int bb = int.Parse(b);
            int id = aa % bb;
            Console.WriteLine(id);

            //6
            Console.WriteLine("Is its true that your number is even?");
            string numb = Console.ReadLine();
            int oe = int.Parse(numb);
            int od = oe % 2;
            bool eo = 0 == od;
            Console.WriteLine(eo);

            //7
            Console.WriteLine("What is your rectangle area, type two sides sizes");
            string asides = Console.ReadLine();
            string bsides = Console.ReadLine();
            float aside = float.Parse(asides);
            float bside = float.Parse(bsides);
            double recarea = aside * bside;
            double round = Math.Round(recarea, 2);
            Console.WriteLine("Your rectangle area is " + round);

            //8
            Console.WriteLine("What is your triangle area, type two sides sizes");
            string atrisides = Console.ReadLine();
            string btrisides = Console.ReadLine();
            int atriside = int.Parse(atrisides);
            int btriside = int.Parse(btrisides);
            int triarea = (atriside * btriside) / 2;
            Console.WriteLine("Your triangle area is " + triarea);

            //9
            Console.WriteLine("What's your name?");
            string user = Console.ReadLine();
            Console.WriteLine("What's your age?");
            string agee = Console.ReadLine();
            int ages = int.Parse(agee);
            Console.WriteLine("Hello, " + user + " , your age is " + ages);


        }
    }
}
