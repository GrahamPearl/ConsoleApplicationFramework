using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationFramework
{
    class Program
    {
        static void CodeExampleFromTextbook2_1()
        {
            double width, height, woodLength, glassArea; string widthString, heightString;

            Console.WriteLine("Enter the dimensions (in feet) for the width and height");
            Console.Write("Width: ");

            widthString = Console.ReadLine(); width = double.Parse(widthString);

            Console.Write("Height: ");
            heightString = Console.ReadLine(); height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet"); Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }

        static void Main(string[] args)
        {
            string fullname;
            string location;
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(today.Year, 12, 25);

            fullname = "Graham Pearl";
            location = "Durban, South Africa";

            Console.WriteLine("BYU-IDAHO CIT 365 Student - Details");
            Console.WriteLine($"Name : {fullname}");
            Console.WriteLine($"Where: {location}");
            Console.WriteLine($"Date : {today.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Days till Christmas : {christmas.Subtract(today).TotalDays.ToString()}");

            Console.WriteLine("");
            CodeExampleFromTextbook2_1();

            Console.WriteLine("");
            Console.WriteLine("Program Completed - press ENTER to Close");
            Console.ReadLine();
        }
    }
}
