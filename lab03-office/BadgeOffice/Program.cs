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