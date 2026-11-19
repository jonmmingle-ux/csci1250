using System.Drawing;
// part 1

string projectFolder = Path.GetFullPath(
Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);


static int LeaderIndex(string[] points)
{
    int leaderPoints = 0;
    int leaderPos = 0;

    for (int i = 0; i < points.Length; i++)
    {
        int intpoints = Convert.ToInt32(points[i]);

        if (intpoints > leaderPoints)
        {
            leaderPoints = leaderPoints + intpoints;
            leaderPos = i;
        }

    }

    return leaderPos;

}

static int TotalPoints(string[] points)
{
    int Total = 0;
        for (int i = 0; i < points.Length; i++)
        {
        int intpoints = Convert.ToInt32(points[i]);
        Total = intpoints + Total;
        }
    return Total;
}

// text for beggining and stuff for part 3

static string HistoryEntry(int night, string winner, int points)
{
    return $"Night {night}: {winner} won with {points} points";
}

string[] history = File.ReadAllLines(HISTORY_FILE);
int tonightNumber = history.Length + 1;

System.Console.WriteLine("=== GAME NIGHT LEADERBOARD ===");
if (history.Length == 0)
{
    System.Console.WriteLine("No nights played yet.");
}
else
{
    System.Console.WriteLine($"Nights played: {history.Length}");
    foreach (string line in history)
    {
        System.Console.WriteLine($"  {line}");
    }
}

System.Console.WriteLine($"Tonight is Night {tonightNumber}.");
System.Console.WriteLine();

System.Console.Write("PLAYER".PadRight(11));
System.Console.WriteLine("POINTS");
for(int i = 0; i < players.Length; i++)
{
    System.Console.Write(players[i].PadRight(11));
    System.Console.WriteLine(points[i]);
}
System.Console.WriteLine($"Leader: {players[LeaderIndex(points)]} with {points[LeaderIndex(points)]}");
System.Console.WriteLine($"Season total: {TotalPoints(points)}");


//part 2 

int bestTonight = -1;
string tonightWinner = "";

for (int i = 0; i < players.Length; i++)
{
    System.Console.Write($"Points tonight for {players[i]}: ");
    int tonight = Convert.ToInt32(Console.ReadLine());

    while (tonight < 0 || tonight > MAX_POINTS)
    {
        System.Console.WriteLine($"Points must be from 0 to {MAX_POINTS}.");
        System.Console.Write($"Points tonight for {players[i]}: ");
        tonight = Convert.ToInt32(Console.ReadLine());
    }

    int season = Convert.ToInt32(points[i]) + tonight;
    points[i] = season.ToString();

    if (tonight > bestTonight)
    {
        bestTonight = tonight;
        tonightWinner = players[i];
    }
}

System.Console.WriteLine($"Tonight's winner: {tonightWinner} with {bestTonight}");
System.Console.WriteLine("");
File.WriteAllLines(POINTS_FILE, points);

//part 3

System.Console.WriteLine("Saved points.txt.");
string[] entry = { HistoryEntry(tonightNumber, tonightWinner, bestTonight) };
File.AppendAllLines(HISTORY_FILE, entry);
System.Console.WriteLine($"Added to history.txt: {entry[0]}");