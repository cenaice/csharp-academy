// See https://aka.ms/new-console-template for more information

// 4 Students, each with 5 exam scores
// Score is a value from 0-100
// Overall Exam Score is Average of 5
// Extra Cred is worth 10% of exam score and goes to students total exam score 
// Need to assign letter based grading based on score:

string[] courses = {"Math", "English", "Physics", "History", "Gym"};
int[] vicScores = { 100, 100, 100, 100, 100 };
int[] jackScores = { 90, 80, 70, 60, 50 };
int[] andyScores = { 80, 93, 85, 77, 62 };
int[] eliScores = { 87, 65, 89, 76, 65 };

Console.Write("Would you like to add another student? (y/n): ");
// Create new student input
if (Console.ReadLine() == "y")
{
    int[] new_student_scores = new int[5];
    Console.Write("Enter the Math score of the student: ");
    if (int.TryParse(Console.ReadLine(), out new_student_scores[0]))
    {
        Console.Write("Enter the English score of the student: ");
        if (int.TryParse(Console.ReadLine(), out new_student_scores[1]))
        {
            Console.Write("Enter the Physics score of the student: ");
            if (int.TryParse(Console.ReadLine(), out new_student_scores[2]))
            {
                Console.Write("Enter the History score of the student: ");
                if (int.TryParse(Console.ReadLine(), out new_student_scores[3]))
                {
                    Console.Write("Enter the Gym score of the student: ");
                    int.TryParse(Console.ReadLine(), out new_student_scores[4]);
                }
            }
        }
    }
}

decimal classAverage = 0;
for (int i = 0; i < 5; i++)
{
    classAverage = (vicScores[i] + jackScores[i] + andyScores[i] + eliScores[i]) / 5m;
    Console.WriteLine($"The {courses[i]} class average was {classAverage}");
};


