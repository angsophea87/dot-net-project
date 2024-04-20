// See https://aka.ms/new-console-template for more information

string name = "John";

Console.WriteLine("Hello, World! My name is " + name); //concatenate
Console.WriteLine($"Hello, World! My name is {name}"); //string interpolation
Console.WriteLine("Hello, World! My name is {0}", name);//Formatted string

int age = 54;
int retirementYearLeft = 11;
int retirementAge = age + retirementYearLeft;

Console.WriteLine("My age  is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);

