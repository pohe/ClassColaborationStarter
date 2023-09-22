// See https://aka.ms/new-console-template for more information

using ClassColaborationStarter;

Car myCar = new Car("Volvo", 300.75);

myCar.Start();

Console.WriteLine(myCar);

Wheel w1 = new Wheel(2020, "summer", 34.5);
myCar.ChangeWheels(w1);

double totalCo2= myCar.CalCo2Emission();
Console.WriteLine(totalCo2);

Console.WriteLine($"Is co2 from car more than average {myCar.MoreThanAverageCo2Emission(1500.7)}");

string navDisplayType = myCar.TheNavigationSystem.DisplayType;
Console.WriteLine($"Bilen med modelnavn {myCar.ModelName} har navigatinsdisplay {navDisplayType}");



//string res = w1.ToString();
//Console.WriteLine(res);

//w1.Type = "winter";
//Console.WriteLine(w1.ToString());

//Engine Engine1 = new Engine(300, "Gasoline", 2000.5);

//Engine1.Start();

//Console.WriteLine(Engine1.ToString());

//Engine1.Fuel = "Electric";

//Console.WriteLine(Engine1.ToString());



//Udskriv modelname når bilen starter

//Udskriv antal heste kræfter når motoren starter

//Udskriv navnet på produceren når navigationssystemet starter


//Hvordan kan man få fat i navigationssystemets displaytype for objektet myCar
//string navDisplayType = xxxx;
//Console.WriteLine($"Bilen med modelnavn {xxx} har navigatinsdisplay {navDisplayType}");


//Udskriv hvilket årstal bilens hjul er fra for objektet myCar


//Er det muligt fra engine objektet at finde modelnavnet på bilen?




