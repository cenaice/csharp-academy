// LEVEL 22 NULL REFERENCES


/* SPEEDRUN
 
 * Reference types may contain a reference to nothing: null, representing a lack of an object 
 * Carefully consider whether null makes sense as an option for a variable and program accordingly.
 * Check for null with x == null, the null conditional operators x?.DoStuff() and x?[3], and use ??
 * to allow null values to fall back to some other default: x ?? "empty"
 */

using static System.Formats.Asn1.AsnWriter;

string name = null;
Console.WriteLine(name.Length);


// Checking For Null: Compare reference against the null literal (null check)

string? Lname = Console.ReadLine();
if (Lname != null)
{
    Console.WriteLine("The name is not null");
}

private string? GetTopPlayerName()
{
    if (_scoreManager == null) return null;
    Score[]? scores = _scoreManager.GetScores();
    if (scores == null) return null;
    Score? topScore = scores[0];
    if (topScore == null) return null;
    return topScore.Name;
}