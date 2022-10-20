// See https://aka.ms/new-console-template for more information
Console.WriteLine("Grade Calculator");
Console.WriteLine("==========");

Console.Write("Did you take the first written exam (yes/no)?: ");
string firstask = Console.ReadLine();

int possiblePoints = 40;
int firsttest = 0;
int secondtest = 0;

if (firstask == "Yes" || firstask == "yes")
{
    Console.Write("How many points did you had on the first exam (0-20)?: ");
    firsttest = Convert.ToInt32(Console.ReadLine());
}
else { possiblePoints -= 20; }

Console.Write("Did you take the second written exam (yes/no)?: ");
string secondask = Console.ReadLine();

if (secondask == "Yes" || secondask == "yes")
{
    Console.Write("How many points did you had on the second exam (0-20)?: ");
    secondtest = Convert.ToInt32(Console.ReadLine());
}
else { possiblePoints -= 20; }

double sum = 100d* (firsttest + secondtest) / possiblePoints;

int grade = 0;
if (sum >= 89) { grade = 1; }
else if (sum >= 76 && sum < 89) { grade = 2; }
else if ( sum >= 63 && sum < 76) { grade = 3; }
else if ( sum >= 50 && sum < 63) { grade = 4; }
else if ( sum <= 50) { grade = 5; }

Console.WriteLine($" Your grade is {grade}");