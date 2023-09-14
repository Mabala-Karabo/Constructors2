using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    internal class Car
    {
        public string model;
        public string colour;
        public int year;
        public string engineType;

        // constructors
        public Car(string aModel, string aColour, int aYear, string aEngineType)
        {
            model = aModel;
            colour = aColour;
            year = aYear;
            engineType = aEngineType;
        }
    }
}
