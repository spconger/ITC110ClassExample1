using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mileage m = new Mileage();
            double miles = 300;
            double gallons = 12;
            double pricePerGallon = 2.50;

            Mileage m = new Mileage(miles, gallons, pricePerGallon);
            
            

            Console.WriteLine("Your Miles per gallon: {0}", m.GetMilesPerGallon());
            Console.WriteLine("It cost you {0} per mile", m.PricePerMile());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
