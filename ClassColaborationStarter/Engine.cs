using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaborationStarter
{
    public class Engine
    {
        //Lav en klasse Engine 
        // Klassen skal have en fuld property for horse power (HP)
        // og auto property for henholdsvis Fuel og Co2FromProduction
        //Tilføj konstruktør, ToString metode og en metode Start der
        //udskriver at Engine er startet

        // instance fields
        private int _hp;


        // property

        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        private string _fuel;
        public string Fuel { 
            get { return _fuel; }
            set { string input = value;
                if (input.Length > 2)
                    _fuel = input;
            }
        }

        public double Co2FromProduction { get; set; }

        //constructor

        public Engine(int hp, string fuel, double co2FromProduction)
        {
            _hp = hp;
            Fuel = fuel;
            Co2FromProduction = co2FromProduction;
        }
        public Engine(int hp, string fuel)
        {
            _hp = hp;
            Fuel = fuel;

        }
        public override string ToString()
        {
            return $"Engine info: Horsepower: {_hp} Fuel type: {Fuel} Co2 from production: {Co2FromProduction}";
        }
        public void Start()
        {
            
            Console.WriteLine($"Engine is powered on HK {_hp}");
        }

    }
}

