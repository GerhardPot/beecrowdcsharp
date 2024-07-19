/*
Read four numbers (N1, N2, N3, N4), which one with 1 digit after the decimal point, corresponding to 4 scores obtained by a student.
Calculate the average with weights 2, 3, 4 e 1 respectively, for these 4 scores and print the message "Media: " (Average), followed by the calculated result.

If the average was 7.0 or more, print the message "Aluno aprovado." (Approved Student).
If the average was less than 5.0, print the message: "Aluno reprovado." (Reproved Student).
If the average was between 5.0 and 6.9, including these, the program must print the message "Aluno em exame." (In exam student).

In case of exam, read one more score.
Print the message "Nota do exame: " (Exam score) followed by the typed score.
Recalculate the average (sum the exam score with the previous calculated average and divide by 2) and print the message “Aluno aprovado.” (Approved student)
in case of average 5.0 or more) or "Aluno reprovado." (Reproved student) in case of average 4.9 or less. For these 2 cases (approved or reproved after the exam)
print the message "Media final: " (Final average) followed by the final average for this student in the last line.

Input
The input contains four floating point numbers that represent the students' grades.

Output
Print all the answers with one digit after the decimal point.
*/

string scores = Console.ReadLine();

double score1, score2, score3, score4;

int space = scores.IndexOf(' ');
score1 = double.Parse(scores.Substring(0, space));
scores = scores.Substring(space + 1);
space = scores.IndexOf(' ');
score2 = double.Parse(scores.Substring(0, space));
scores = scores.Substring(space + 1);
space = scores.IndexOf(' ');
score3 = double.Parse(scores.Substring(0, space));
score4 = double.Parse(scores.Substring(space + 1));

double average = ((2d * score1) + (3d * score2) + (4d * score3) + (1d * score4)) / 10f;
average = Math.Floor(average * 10) / 10;
Console.WriteLine($"Media: {average.ToString("F1")}");

if (average >= 7d)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (average < 5d)
{
    Console.WriteLine("Aluno reprovado.");
}
else
{
    Console.WriteLine("Aluno em exame.");
    double exam = double.Parse(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {exam.ToString("F1")}");
    if (average >= 5d)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else if (average < 5d)
    {
        Console.WriteLine("Aluno reprovado.");
    }
    average = (average + exam) / 2d;
    Console.WriteLine($"Media final: {average.ToString("F1")}");
};