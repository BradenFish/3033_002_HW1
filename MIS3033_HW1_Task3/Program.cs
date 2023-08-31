
double totalScore = 0.0;
int counter = 0;
string answerStr;
string message;
do
{
    message = "Please enter a score: ";
    Console.Write(message);
    string scoreStr = Console.ReadLine();
    double scoreDbl = Convert.ToDouble(scoreStr);
    counter++;
    totalScore = totalScore + scoreDbl;
    //counter = counter + 1
    //counter += 1

    message = "Do you have another score to enter?";
    Console.Write(message);
    answerStr = Console.ReadLine();

} while (answerStr.ToLower() == "yes");

double avgScore = totalScore / counter;
message = string.Format("The number of scores entered: {0}\n", counter);
Console.Write(message);
message = string.Format("The average score is {0:F2}\n", avgScore);
Console.Write(message);


