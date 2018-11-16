using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Program
    {
        public static int Addition(int num1, int num2)
        {  
            int total;
            total = num1 + num2;
            return total;
        }
        public static int Subtract(int num1, int num2)
        {
            int total;
            total = num1 - num2;
            return total;
        }

        public static void Main()
        {
            Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
            Console.Write("------------------------------------------------\n");
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you want to add or subtract? ");
            string operation = Console.ReadLine();

            if (Console.ReadLine() == "+" || operation == "add")
            {
                Console.WriteLine("\nThe sum of two numbers is : {0}\n", Addition(n1, n2));

            }
            if (operation == "-" || operation == "minus")
            {
                Console.WriteLine("\nThe sum of two numbers is : {0} \n", Subtract(n1, n2));
            }

            Console.Read();
        }
    }
}
