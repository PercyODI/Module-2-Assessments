using System;

namespace Module_2_Assessments
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputnum;
            Console.Write("Enter an Integer of at least 3 digits long: ");
            bool validint = int.TryParse(Console.ReadLine(), out inputnum);
            while (validint == false)
            { 
                Console.WriteLine("Please enter valid Integer: ");
                validint = int.TryParse(Console.ReadLine(), out inputnum);                           
            }
            int num1 = (inputnum / 100);
            decimal num2 = num1;
            num2 = decimal.Round(num1);
            if (num2 == 7)
                Console.WriteLine("There is a 7 third from the right");
            else
                Console.WriteLine("There is NOT a 7 third from the right");






        }
    }
}
