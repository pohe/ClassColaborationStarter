using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaborationStarter
{
    public class Wheel
    {
        //Lav en klasse Wheel 
        // Klassen skal have 3  auto properties for henholdsvis Year, Type og Co2FromProduction
        //Tilføj konstruktør, ToString metode

        //auto properties
        public int Year { get; set; }
        public string Type { get; set; }
        public double Co2FromProduction { get; set; }

        //constructor 
        public Wheel(int year, string type, double co2)
        {
            Year = year;
            Type = type;
            Co2FromProduction = co2;

        }


        //ToString
        public override string ToString()
        {
            return $"Wheels year:{Year}, Wheel type: {Type}, Co2 from production of wheel: {Co2FromProduction}";
        }


    }
}
