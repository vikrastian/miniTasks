// --------------- TASK 2 (Added to get name as required)
using System.ComponentModel;
using System.Data;

Console.WriteLine("Please enter your name.");
string name = Console.ReadLine() ?? "";             // NAme = empty string if no input from user.

while (string.IsNullOrEmpty(name))                  // While loop sikrer input fra bruker.
{
    Console.WriteLine("Please enter your name.");
    name = Console.ReadLine() ?? "";
}

Console.WriteLine($"Hello, {name}.");


// -------------- TASK 2
Console.WriteLine("Please enter your age.");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 18)
    {
    Console.WriteLine("You must be 18 years old to use this service.");
    }

else
    {
    Console.WriteLine("Do you agree with the terms of service? yes / no.");
    }

string answer = Console.ReadLine() ?? ""; // Avoid null value


switch(answer.ToLower()) // Avoiding big/small letters issue
{
    case "yes": 
        Console.WriteLine($"Thank you. \n Name: {name} \n Age: {age} \n Accepted TOS: yes. ");
        break;

    case "no":
        Console.WriteLine("You must agree to the terms of service to continue.");
        break;

    default:
        Console.WriteLine("Input not valid. Program has been ended.");
        break;

}

