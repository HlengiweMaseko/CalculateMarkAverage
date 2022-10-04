using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMarkAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console Color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Allow students to enter their names and surnames
            Console.Write("Name: ");
            string sName = Console.ReadLine();

            Console.Write("Surname: ");
            string sSurname = Console.ReadLine();
            Console.WriteLine("\n");

            //Allow students to enter their marks
            Console.Write("Enter Mark1: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Mark2: ");
            int mark2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Mark3: ");
            int mark3 = Convert.ToInt32(Console.ReadLine());

            //Find mark Average
            int Average = (mark1 + mark2 + mark3) / 3;

            //Print to the Console
            Console.WriteLine("Dear " + sName + " " + sSurname + " " + "Your Average mark is: " + Average.ToString());

            //Decision Takes
            if (Average >= 50)
            {
                Console.WriteLine("Congratulations!You passed.");
            }
            else
            {
                Console.WriteLine("Sorry!You have failed.");
            }
            //Exit the Program
            Console.WriteLine("\nPress Any Key To Exit The Program...");
            Console.ReadKey();
        }
    }
}
