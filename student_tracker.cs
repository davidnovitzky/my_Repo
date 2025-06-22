// Create a simple program that stores students' names along with their grades in various subjects using tuples.

Console.WriteLine("Welcome to the Student Grades Tracker!");
Console.WriteLine("--------------------------------------\n");

Console.WriteLine("Available actions:");
Console.WriteLine($"1. View all students\n2. View grades for a student\n3. Add a new student\n4. Exit\n");

string[] students = new string[] { "David", "Aida", "Ariana" };

(string name, Grade grade, Subject subject) studentGrade = (students[0], Grade.B, Subject.Math );

Console.WriteLine($"Grades for {studentGrade.name}:");
Console.WriteLine($"-{studentGrade.subject}: {studentGrade.grade}");

enum Subject { Math, Science, Art, History }
enum Grade { A, B, C, D, E, F }
