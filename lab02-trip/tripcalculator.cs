/*
* Name: Jonathan Mingle
* Course: CSCI 1250, Section 002
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/


System.Console.WriteLine("=== Road Trip ===");

// The variables for the actual trip miles and gas

Console.Write("How many miles was the trip? ");
Double milesForTheTrip = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon do you get? ");
Double MilesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What was the gas price? ");
Double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = milesForTheTrip / (double)MilesPerGallon;
double fuelcost = gallonsNeeded * gasPrice;


System.Console.WriteLine("=== Pizza Party ===");

// The variables for the pizza party 

System.Console.Write("How many people are going? ");
double PeopleGoing = Convert.ToDouble(Console.ReadLine());

System.Console.Write("how many pizzas will you get? ");
double numofpizza = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How much is 1 pizza? ");
double pricepizza = Convert.ToDouble(Console.ReadLine());

int slicesper = 8;

double TotalSlices = numofpizza * slicesper;
double slicesperperson = TotalSlices / PeopleGoing;
double pizzacost = numofpizza * pricepizza;

System.Console.WriteLine("=== Paycheck ===");

// getting the variables for your paycheck 

System.Console.Write("How many hours did you work this week? ");
double hoursworked = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is your pay per hour? ");
double payrate = Convert.ToDouble(Console.ReadLine());

Double taxrate = 0.18;

double grosspay = hoursworked * payrate;
double taxwithheld = grosspay * taxrate;
double takehome = grosspay - taxwithheld;

// the operations for part 4

double triptotal = fuelcost + pizzacost;
double costperperson = triptotal / PeopleGoing;
double takehomeperhr = takehome / hoursworked;
double hoursyoumustwork = costperperson / takehomeperhr;

// The final part with everything showing in the right order even with goo spacing. 
System.Console.WriteLine("");

System.Console.WriteLine("=== Part 1: Road Trip ===");

System.Console.WriteLine("Roud trip Miles: " + milesForTheTrip);
System.Console.WriteLine("Miles Per Gallon: " + MilesPerGallon);
System.Console.WriteLine("Price per gallon: " + gasPrice);

System.Console.WriteLine("");

System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelcost.ToString("C"));

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 2: Pizza Party ===");

System.Console.WriteLine("How many people are going: " + PeopleGoing);
System.Console.WriteLine("How many pizzas: " + numofpizza);
System.Console.WriteLine("Price per pizza: " + pricepizza.ToString("C"));

System.Console.WriteLine("");

System.Console.WriteLine("Total slices: " + TotalSlices);
System.Console.WriteLine("Slices per person: " + slicesperperson.ToString("F1"));
System.Console.WriteLine("Pizza Cost: " + pizzacost.ToString("C"));

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 3: PayCheck ===");

System.Console.WriteLine("Hours worked this week:" + hoursworked);
System.Console.WriteLine("Hourly rate: " + payrate);

System.Console.WriteLine("");

System.Console.WriteLine("Gross pay: " + grosspay.ToString("C"));
System.Console.WriteLine("Tax Withheld: " + taxwithheld.ToString("C"));
System.Console.WriteLine("Take home Pay: " + takehome.ToString("C"));

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 4: The Whole Trip ===");
System.Console.WriteLine("Trip total: " + triptotal.ToString("C"));
System.Console.WriteLine("Cost per person: " + costperperson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + takehomeperhr.ToString("C"));
System.Console.WriteLine("Hours you must work to cover your share: " + hoursyoumustwork.ToString("F2"));