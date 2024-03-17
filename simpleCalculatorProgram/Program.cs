using System.Collections;

Console.WriteLine("Please enter first number?");
decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter calculation symbol (+  -  *  / )");
string symbol = Console.ReadLine() ?? ""; // Avoiding null value / strictly not needed due to switch, but error while making, will delted it (?? "") if possible after with no errors on build/run.
Console.WriteLine("Please enter second number?");
decimal secondNumber = Convert.ToDecimal(Console.ReadLine());


decimal result = 0;

switch(symbol)
{
    case "+":
    result = firstNumber + secondNumber; 
    break;
    
    case "-":
    result = firstNumber - secondNumber;
    break;

    case "*":
    result = firstNumber * secondNumber;
    break;

    case "/":
    // Avoid 0
    if (secondNumber == 0)
    {
        Console.WriteLine("Can not divide on zero.\nRestart program and try again.");
        Environment.Exit(0); // Shutting down application.
    }
    else
    {
        result = firstNumber / secondNumber;
    }
    break;

    default:
        Console.WriteLine("Not valid operator detected.\nRestart program to try again.");
        Environment.Exit(0); // Shutting down application.
    break;
}

Console.WriteLine($"The result of {firstNumber} {symbol} {secondNumber} = {result}");




