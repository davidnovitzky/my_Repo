// Classes will work better here

Console.Write("Enter your name: ");
string studentName = Console.ReadLine();

Subject subject = Subject.Math;
Grade grade = Grade.F;

int subjects = 0;

while (subjects < 2)
{
    Console.Write("Choose a subject (Math, History): ");
    string chosenSubject = Console.ReadLine();

    if (chosenSubject.ToLower() == "math") subject = Subject.Math;
    else if (chosenSubject.ToLower() == "history") subject = Subject.History;
    else subject = Subject.Math;

    Console.Write("Enter a grade (A-F): ");
    string gradeInput = Console.ReadLine();

    if      (gradeInput == "A") grade = Grade.A;
    else if (gradeInput == "B") grade = Grade.B;
    else if (gradeInput == "C") grade = Grade.C;
    else if (gradeInput == "D") grade = Grade.D;
    else if (gradeInput == "F") grade = Grade.F;

    subjects++;
}

(string name, Grade grade, Subject subject) student = (studentName, grade, subject);

Console.WriteLine($"Name: {student.name}");
Console.WriteLine($"Subject: {student.subject}");
Console.WriteLine($"Grade: {student.grade}");

enum Subject { Math, History }
enum Grade { A, B, C, D, F }
