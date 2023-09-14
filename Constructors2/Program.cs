using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Ford Mustang", "Blue", 2022, "5.0L Ti-VCT V8 Engine");
            Car Toyota = new Car("Hilux", "Red", 2022, "\"2.8L DIESEL TURBO 4 engine\"");
            Car BMW = new Car("X5", "White", 2022, "3.0L BMW M TwinPower Turbo inline engine");
            Car MercedezBenz = new Car("AMG", "Black", 2022, "\" 4.0-liter biturbo powerplant.\"");

            //console dispaplay
            Console.WriteLine("Our first car is " + Ford.year + " " + Ford.colour + " Ford." + Ford.model + " with engine type " + Ford.engineType);
            Console.WriteLine("our second car is " + Toyota.year + " " + Toyota.colour + " Toyoya." + Toyota.model + " with engine type " + Toyota.engineType);
            Console.WriteLine("Our 3rd car is " + BMW.year + " " + BMW.colour + " BMW " + BMW.model + " with engine type " + BMW.engineType);
            Console.WriteLine("Last car is " + MercedezBenz.year + " " + MercedezBenz.colour + " MercedezBenz " + MercedezBenz.model + " with engine type " + MercedezBenz.engineType);

            Console.ReadLine();
        }
    }
}
