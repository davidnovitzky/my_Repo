Console.Write("Enter your name: ");
string studentName = Console.ReadLine();

Console.Write("Choose a subject (Math, History): ");
string chosenSubject = Console.ReadLine();

Subject subject;

if      (chosenSubject.ToLower() == "math")    subject = Subject.Math;
else if (chosenSubject.ToLower() == "history") subject = Subject.History;
else                                           subject = Subject.Math;

Console.Write("Enter a grade (A-F): ");
string gradeInput = Console.ReadLine();

Grade grade = Grade.F;
if      (gradeInput == "A") grade = Grade.A;
else if (gradeInput == "B") grade = Grade.B;
else if (gradeInput == "C") grade = Grade.C;
else if (gradeInput == "D") grade = Grade.D;
else if (gradeInput == "F") grade = Grade.F;

(string name, Grade grade, Subject subject) student = (studentName, grade, subject);

Console.WriteLine($"Name: {student.name}");
Console.WriteLine($"Subject: {student.subject}");
Console.WriteLine($"Grade: {student.grade}");

enum Subject { Math, History }
enum Grade { A, B, C, D, F }
