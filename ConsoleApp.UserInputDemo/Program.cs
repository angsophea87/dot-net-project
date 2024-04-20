// See https://aka.ms/new-console-template for more information

//Declare variable
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

Console.WriteLine("Please enter your firstname:");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your lastname:");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

int workingYearRemaining = retirementAge - age;

Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearRemaining}");
