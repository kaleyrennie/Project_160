using System;

namespace Project160
{
    public class Program
    {

        static void Main(string[] args)
        {
            Parameters objectParameters = new Parameters(); //instantiate

            Console.WriteLine("Please enter fist number.");
            int x = Convert.ToInt32(Console.ReadLine());
            int newVar1; //creating variable

            Console.WriteLine("Please enter second number(not needed.)");
            string y = Console.ReadLine();

            if (y == "")
            {
                newVar1 = objectParameters.AddNumber(x);
            }
            else
            {
                int intY = Convert.ToInt32(y);
                newVar1 = objectParameters.AddNumber(x, intY);
            }

            Console.WriteLine(newVar1);



        }
    }
}
