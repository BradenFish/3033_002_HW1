double totalGrade = 0.0;
string message = "";
int numOfExams = 3;
for (int i = 0; i < 3; i++)
{
    message = String.Format("Please input exam {0} ", i + 1);
    Console.Write(message);
    string examGrade = Console.ReadLine();
    double examGradeDbl = Convert.ToDouble(examGrade);
    totalGrade = totalGrade + examGradeDbl;
    // totalGrade += examGradeDbl; 
}
double aveGrade = totalGrade / numOfExams;
double aveGradePercent = aveGrade / 100.0;
message = String.Format("The final grade percent is {0:p2}", aveGradePercent);
Console.WriteLine(message);
