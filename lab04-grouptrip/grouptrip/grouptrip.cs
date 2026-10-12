/*
* Name: Jonathan Mingle
* Course: CSCI 1250, Section 002
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/



// The variables for the actual trip miles and gas

Console.Write("How many miles was the trip? ");
Double milesForTheTrip = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon do you get? ");
Double MilesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What was the gas price? ");
Double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = milesForTheTrip / (double)MilesPerGallon;
double fuelcost = gallonsNeeded * gasPrice;



// The variables for the pizza party 



System.Console.Write("how many pizzas will you get? ");
double numofpizza = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How much is 1 pizza? ");
double pricepizza = Convert.ToDouble(Console.ReadLine());

int slicesper = 8;

double TotalSlices = numofpizza * slicesper;
double pizzacost = numofpizza * pricepizza;



Double taxrate = 0.18;


// the operations for fuel cost and such

double triptotal = fuelcost + pizzacost;

static double FuelCost(double milesForTheTrip, double milesPerGallon, double gasPrice)
{
    double gallons = milesForTheTrip / milesPerGallon;
    return gallons * gasPrice;
}

double Fuel = FuelCost( milesForTheTrip, MilesPerGallon, gasPrice);

static double TakeHomePay(double hoursworked, double payrate, double taxrate)
{
    double grosspay = hoursworked* payrate;
    double taxwithheld = grosspay * taxrate;
    double takehome = grosspay - taxwithheld;
    return takehome;
}

static double HoursToCover(double triptotal, double takehomeperhr)
{
    return triptotal / takehomeperhr; 
    
}

System.Console.WriteLine($"Round trip miles: {milesForTheTrip}");
System.Console.WriteLine($"Miles per gallon: {MilesPerGallon}");
System.Console.WriteLine($"Price per gallon: {gasPrice}");
System.Console.WriteLine($"How many pizzas: {numofpizza}");
System.Console.WriteLine($"Price per pizza: {pricepizza}");

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 1: The Trip ===");

System.Console.WriteLine($"Fuel cost: {Fuel.ToString("C")}");
System.Console.WriteLine($"Pizza cost: {pizzacost.ToString("C")}");
System.Console.WriteLine($"Trip total: {triptotal.ToString("C")}");

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

int PeopleGoing = names.Length;

static double slicesEach(double slicesper, double numofpizza, int PeopleGoing)
{
    double TotalSlices = numofpizza * slicesper;
    double slicesperperson = TotalSlices / PeopleGoing;
    return slicesperperson;
}

double slicesperperson = slicesEach(slicesper, numofpizza, PeopleGoing);

static double costperperson(double triptotal, int PeopleGoing)
{
    return triptotal / PeopleGoing;
}
double costpermember = costperperson(triptotal, PeopleGoing);

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine($"People going: {PeopleGoing}");
System.Console.WriteLine($"Slices each: {slicesperperson}");
System.Console.WriteLine($"Cost per person: {costpermember.ToString("C")}");

System.Console.WriteLine("");

System.Console.WriteLine("=== Part 3: Who works how long ===");
double totalHours = 0;
double totaltakehome = 0;
double longesthours = 0;
for (int i = 0; i < names.Length; i++)
{
    double takeHomePay = TakeHomePay(hoursWorked[i],hourlyRates[i],taxrate);
    totalHours += hoursWorked[i];
    totaltakehome += takeHomePay;
    double takehometax = hourlyRates[i] * taxrate;
    double grosstakehome = hourlyRates[i] - takehometax;
    double hoursForTrip = HoursToCover(costpermember, grosstakehome);
    if (hoursForTrip > longesthours)
    {
        longesthours = hoursForTrip;
    }
    System.Console.WriteLine($"{names[i]}: takes home {takeHomePay.ToString("C")}, for {hoursWorked[i]} hours, {(hourlyRates[i]*0.82).ToString("C")} per hour, must work {hoursForTrip.ToString("F2")} hours ");
}

System.Console.WriteLine("");

System.Console.WriteLine($"Total hours worked: {totalHours}");
System.Console.WriteLine($"Total take home pay: {totaltakehome.ToString("C")}");
System.Console.WriteLine($"Longest anyone must work: {longesthours.ToString("F2")}");





