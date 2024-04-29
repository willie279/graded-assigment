using System;

// initialize variables - graded assignments 
int examAssigment = 5;
//matrices de puntuaciones
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];//estduaintes y notas agregadas, prueba de que se aceptan mas
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];//estduaintes y notas agregadas, prueba de que se aceptan mas
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];//estduaintes y notas agregadas, prueba de que se aceptan mas
int[] georgeScores = [91, 91, 91, 91, 91, 91, 91];//estduaintes y notas agregadas, prueba de que se aceptan mas

//matriz de nombres
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "George"];
int[] studentScores = [10];
string currentStudentLetter = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

//recorrido externo
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "George")
        studentScores = georgeScores;

    int sumAssigmentScorees = 0;
    int sumAssigmentScores = 0; // initialize/reset the sum of scored assignments
    decimal currentStudentGrade = 0; // initialize/reset the calculated average of exam + extra credit scores
    int gradeAssigments = 0; // initialize/reset a counter for the number of assignments
                             //recorrido interno
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradeAssigments++;
        if (gradeAssigments <= examAssigment)

            // add the exam score to the sum
            sumAssigmentScores += score;


        else

            sumAssigmentScorees += score / 10;

    }
    currentStudentGrade = (decimal)((sumAssigmentScores) + sumAssigmentScorees) / examAssigment;
    if (currentStudentGrade >= 97)
        currentStudentLetter = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetter = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetter = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetter = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetter = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetter = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetter = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetter = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetter = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetter = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetter = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetter = "D-";

    else
        currentStudentLetter = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetter}");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine(); // (keeps the Output windows open to view results)







