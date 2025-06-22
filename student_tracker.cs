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

/*Welcome to the Student Grades Tracker!
--------------------------------------

Available actions:
1. View all students
2. View grades for a student
3. Add a new student
4. Exit

Enter your choice (1-4): 1

List of students:
- Alice
- Bob
- Charlie

--------------------------------------

Enter your choice (1-4): 2
Enter student name: Bob

Grades for Bob:
- Math: C
- English: A
- Science: B

--------------------------------------

Enter your choice (1-4): 3
Enter new student name: Dana
Enter number of subjects: 2
Enter subject 1 name: History
Enter grade for History: A
Enter subject 2 name: Art
Enter grade for Art: B

Student 'Dana' added successfully.

--------------------------------------

Enter your choice (1-4): 1

List of students:
- Alice
- Bob
- Charlie
- Dana

--------------------------------------

Enter your choice (1-4): 2
Enter student name: Dana

Grades for Dana:
- History: A
- Art: B

--------------------------------------

Enter your choice (1-4): 4
Goodbye!*/
