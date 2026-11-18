using System.Drawing;

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

System.Console.Write("PLAYER".PadRight(11));
System.Console.WriteLine("POINTS");
for(int i = 0; i < players.Length; i++)
{
    System.Console.Write(players[i].PadRight(11));
    System.Console.WriteLine(points[i]);
}
System.Console.WriteLine($"Leader: {players[LeaderIndex(points)]} with {points[LeaderIndex(points)]}");
System.Console.WriteLine($"Season total: {TotalPoints(points)}");