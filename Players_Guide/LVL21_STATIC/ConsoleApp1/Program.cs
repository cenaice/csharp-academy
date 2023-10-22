// Level 21 Static

/* SPEEDRUN
 
 * Static things are owned by the type rather than a single instance (shared across all instances) 
 * Fields, methods, and constructors can all be static
 * If a class is marked static, it can only contatin static members (Console, Convert, Math).

*/

// By applying static keyword to a field, you create a static field or static variable.

using System.Runtime.InteropServices;

public class Score
{
    // We can access these variables without creating an instance of the Score() class because it is STATIC.
    // We can access it but cannot change it because of the private and readonly tags.
    private static readonly int PointThreshold = 1000;
    private static readonly int LevelThreshold = 4;
    public static int PointThresholdProperties { get; } = 1000;
    public static int LevelThresholdProperties { get; } = 4;
    // ... If a static field is public, it can be used outside the class through the class name. (Score.PointThreshold)

    // Static Constructors
    static Score()
    {
        PointThreshold = 1000;
        LevelThreshold = 4;
    }

}

// Static Classes

public static class Utilities
{
    public static int Helper1() => 4;
    public static double HelperProperty => 4.0;
    public static int AddNumbers(int a, int b) => a + b;
}

// Methods can also be static.  Most often used for utility or helper methods that provide some sort of service related to the class they are placed in.
// For example, the following method determines how many scores in an array belong to a specific player:

// CHALLENGE




