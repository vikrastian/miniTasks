/*
Description of the program:
Prompts user to input the answer for the 4 first writeline prompts.
stores the input from the users in the variables, itemName, quantity, weight and price.
On last writeline it prints a summary back to the user to display text and variables.

I have added ? to the strings to allow null values. The customers are more than welcome to visit our stor without buying and/or talking to us.
*/

Console.WriteLine("Enter the name of the grocery item:");
string? itemName = Console.ReadLine(); 
Console.WriteLine("Enter the quantity:");
string? quantity = Console.ReadLine(); 
Console.WriteLine("Enter the weight in kilograms:");
string? weight = Console.ReadLine(); 
Console.WriteLine("Enter the price per unit:");
string? price = Console.ReadLine(); 
Console.WriteLine($"Item: {itemName}, Quantity: {quantity}, Weight: {weight} kg, Price: ${price}");
