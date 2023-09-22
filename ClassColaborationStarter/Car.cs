using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaborationStarter
{
    public class Car
    {
        //Lav en klasse Car 
        // Klassen skal have 2  auto properties for henholdsvis ModelName og Co2FromProduction
        //Tilføj konstruktør, ToString metode og en metode Start starter både engine og navigationssystemet
        //Lav en metode ChangeWheel, som kan indsætte et nyt Wheel objekt i Car objektet
        // Klassen skal have referencer til henholdsvis Engine, Navigationssystem, Wheel
        // Lav en metode CalCo2Emission der bergner den totale Co2 produktion fra henholdsvis bilen (karosseriet)
        // engine og navigationssystemet
        // Bilens tostring metode skal både udskrive oplysninger Car  objektet, men også om de objekter der er referencer til.

        private Engine _theEngine;
        private NavigationSystem _theNavigationSystem;
        private Wheel _wheel;
        private string _modelName;

        public Engine TheEngine
        {
            get { return _theEngine; }
        }

        public NavigationSystem TheNavigationSystem
        {
            get { return _theNavigationSystem; }
        }

        public Wheel TheWheel
        {
            get { return _wheel; }
        }

        public string ModelName
        {
            get { return _modelName; }
        }

        public double Co2FromProduction
        {
            get; private set;
        }

        public Car( string modelName, double co2FromProduction)
        {
            this._modelName = modelName;
            _theEngine = new Engine(300, "Gasoline", 2000.5);
            _theNavigationSystem = new NavigationSystem("Garmin", "MulticastDelegate-touch,WVGA", "Lifetime update", 204.5);
            _wheel = new Wheel(2024, "Michelin", 230.5);
            Co2FromProduction = co2FromProduction;
        }


        public void Start()
        {
            Console.WriteLine(this._modelName);
            //Console.WriteLine($"Producer af nav.system {_theNavigationSystem.Producer} ");
            _theEngine.Start();
            _theNavigationSystem.Start();
        }

        public void ChangeWheels(Wheel aWheel)
        {
            //lav færdig så der kan lægges et nyt hjul ind
            _wheel = aWheel;
        }

        public double CalCo2Emission()
        {
            double total = this.Co2FromProduction + _wheel.Co2FromProduction + _theNavigationSystem.Co2FromProduction + _theEngine.Co2FromProduction;
            return total; // beregn total co2 fra produktion af alle dele
        }

        public bool MoreThanAverageCo2Emission(double average)
        {
            //Lav en metode der returnere true hvis bilen udleder mere end gennemsnittet
            // i udledt co2
            //Vis hvorledes metoden kan kaldes fra program.cs
            bool res= this.CalCo2Emission() > average;
            return res; 
        }

        public override string ToString()
        {
            return $"Name {_modelName} Co2production {this.Co2FromProduction}  total co2 {CalCo2Emission()}  \n\tengine {_theEngine.ToString()} \n\tnavsystem {_theNavigationSystem.ToString()} \n\twheel {_wheel.ToString()} "; // skriver alle oplysninger ud om bilen og dens dele
        }
    }
}
