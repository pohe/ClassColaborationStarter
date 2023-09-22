using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaborationStarter
{
    public class NavigationSystem
    {
        //Lav en klasse NavigationSystem 
        // Klassen skal have 4  auto properties for henholdsvis Producer, DisplayType, Description og Co2FromProduction
        //Tilføj konstruktør, ToString metode og en metode Start der
        //udskriver at Navigationssystemet er startet

        //auto properties
        public string Producer { get; set; }
        public string DisplayType { get; set; }
        public string Description { get; set; }
        public double Co2FromProduction { get; set; }

        //constructor
        public NavigationSystem(string producer, string displaytype, string description, double co2fromproduction)
        {
            Producer = producer;
            DisplayType = displaytype;
            Description = description;
            Co2FromProduction = co2fromproduction;
        }

        //methods
        public void Start()
        {
            Console.WriteLine($"Navigation system online. Producer {Producer}");
        }


        public override string ToString()
        {
            return $"Producer: {Producer}. Display type: {DisplayType}. Description: {Description}. CO2 production of navigation system: {Co2FromProduction}";
        }

    }
}
