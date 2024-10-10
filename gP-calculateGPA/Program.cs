// I have changed the info from the original lesson to "own it" a little more

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string studentName = "Daufenmire McTaggert";
        string course1Name = "Herbalism 101";
        string course2Name = "Survival 101";
        string course3Name = "Monstors of the Wild 101";
        string course4Name = "Nature Science I";
        string course5Name = "The Psychology of Battle 101";
        string letterGradeA = "A";
        string letterGradeB = "B";  
        

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHours = 0;
        totalCreditHours += course1Credit;
        totalCreditHours += course2Credit;
        totalCreditHours += course3Credit;
        totalCreditHours += course4Credit;
        totalCreditHours += course5Credit;

        // I could have written the above as totalCreditHours = course1Credit + course2Credit + and so on which to me makes more sense but the guide recommends the above

        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;

        int leadingDigit = (int)gradePointAverage;
        int firstDigit = (int)(gradePointAverage * 10) % 10;
        int secondDigit = (int)(gradePointAverage * 100) % 10;

        Console.WriteLine($"Student: {studentName}\n");

        Console.WriteLine("Course \t\t\t\t Letter Grade \t Value \t Credit Hours");

        Console.WriteLine($"{course1Name} \t\t\t {letterGradeB} \t\t {course1Grade} \t\t {course1Credit}");
        Console.WriteLine($"{course2Name} \t\t\t {letterGradeB} \t\t {course2Grade} \t\t {course2Credit}");
        Console.WriteLine($"{course3Name} \t {letterGradeA} \t\t {course3Grade} \t\t {course3Credit}");
        Console.WriteLine($"{course4Name} \t\t {letterGradeA} \t\t {course4Grade} \t\t {course4Credit}");
        Console.WriteLine($"{course5Name} \t {letterGradeB} \t\t {course5Grade} \t\t {course5Credit}\n");

        Console.WriteLine($"Final Grade Point Average:\t {leadingDigit}.{firstDigit}{secondDigit}");

        string GPA = gradePointAverage.ToString("F2");

        Console.WriteLine($"Another way to do it:\t\t {GPA}");

        Console.ReadLine();

    }
}