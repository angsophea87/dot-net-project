﻿// See https://aka.ms/new-console-template for more information

//Declare variable
string name = string.Empty;
int age = 0;
int retirementAge = 65;

Console.WriteLine("Please enter your name:");
name = Console.ReadLine();

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

int workingYearRemaining = retirementAge - age;

Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearRemaining}");
