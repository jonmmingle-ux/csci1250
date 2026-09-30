Random rng = new Random();

// Part 1 //
System.Console.Write("What is your full name? ");
string? fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

fullName = fullName.ToUpper();

string initial1 = firstName.Substring(0,1);
string initial2 = lastName.Substring(0,1);
initial1 = initial1.ToUpper();
initial2 = initial2.ToUpper();


System.Console.WriteLine("Name on badge: " + fullName);
System.Console.WriteLine($"Username: {firstName.Substring(0,1)}{lastName}");
System.Console.WriteLine($"Initials: {initial1}.{initial2}.");
System.Console.WriteLine("Letters in last name: " + lastName.Length);

// part 2 // 

int studentid = rng.Next(100000, 999999);
int lockernum = rng.Next(1, 500);

System.Console.WriteLine($"Student ID: {studentid}");
System.Console.WriteLine($"Locker: {lockernum}");

// part 3 // 

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

double classdist = Math.Sqrt(Math.Pow(classx - dormx,2)) + Math.Sqrt(Math.Pow(classy - dormy, 2));

double timetowalk = classdist/walkspeed;

double minuteswalk = timetowalk/60;
double secondswalk = timetowalk%60;

System.Console.WriteLine($"Distance: {classdist.ToString("F1")}");
System.Console.WriteLine($"Walk time: {Math.Ceiling(minuteswalk)} minutes {Math.Ceiling(secondswalk)} seconds");