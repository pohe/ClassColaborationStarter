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

        public Car() 
        {
            //_theEngine = new Engine(300, "Gasoline", 2000.5);
            //_theNavigationSystem = new NavigationSystem("Garmin", "MulticastDelegate-touch,WVGA", "Lifetime update", 204.5);
            //_wheel = new Wheel(2024, "Michelin", 230.5);
        }

    }
}
