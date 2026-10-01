/*
* Name: Jonathan Mingle
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

Random rng = new Random();

// Part 1 //

// getting full name 

System.Console.Write("What is your full name? ");
string? fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

fullName = fullName.ToUpper();

// getting initials 

string initial1 = firstName.Substring(0,1);
string initial2 = lastName.Substring(0,1);
initial1 = initial1.ToUpper();
initial2 = initial2.ToUpper();

//writing out all the strings to console

System.Console.WriteLine("Name on badge: " + fullName);
System.Console.WriteLine($"Username: {firstName.Substring(0,1)}{lastName}");
System.Console.WriteLine($"Initials: {initial1}.{initial2}.");
System.Console.WriteLine("Letters in last name: " + lastName.Length);

// part 2 // 
// randoms for id and locker number 

int studentid = rng.Next(100000, 999999);
int lockernum = rng.Next(1, 500);

System.Console.WriteLine($"Student ID: {studentid}");
System.Console.WriteLine($"Locker: {lockernum}");

// part 3 // 

// getting dorms position and classroom position 

System.Console.Write("Dorms x position: ");
double dormx = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Dorms y position: ");
double dormy = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Classroom x position: ");
double classx = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Classroom y position: ");
double classy = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Your walking speed (ft/s): ");
double walkspeed = Convert.ToDouble(Console.ReadLine());

// all the math for getting the distance and the actual walk time

double classdist = Math.Sqrt(Math.Pow(classx - dormx,2) + Math.Pow(classy - dormy, 2));

double timetowalk = classdist/walkspeed;

double minuteswalk = timetowalk/60;
double secondswalk = timetowalk%60;

System.Console.WriteLine($"Distance: {classdist.ToString("F1")}");
System.Console.WriteLine($"Walk time: {Math.Floor(minuteswalk)} minutes {Math.Floor(secondswalk)} seconds");

// part 4 //

double checkdigit = studentid%9;

System.Console.WriteLine("==================================");
System.Console.WriteLine("ETSU STUDENT BADGE".PadLeft(26));
System.Console.WriteLine("==================================");

System.Console.WriteLine($"NAME {fullName.PadLeft(17)}");
System.Console.WriteLine($"USERNAME {firstName.Substring(0,1).PadLeft(2)}{lastName}");
System.Console.WriteLine("ID " + studentid.ToString().PadLeft(13) + "-" + checkdigit);
System.Console.WriteLine("LOCKER" + lockernum.ToString().PadLeft(7));
System.Console.WriteLine("WALK " + (Math.Floor(minuteswalk).ToString().PadLeft(6)) + " min " + (Math.Floor(secondswalk)) + " sec");
System.Console.WriteLine("==================================");

// i would have done all the writelines as $ but i couldnt figure out to make the ints pad left in it