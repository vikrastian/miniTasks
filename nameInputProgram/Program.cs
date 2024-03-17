// ---------- Name input program

Console.WriteLine("Please enter your name.");
string name = Console.ReadLine() ?? "";             // NAme = empty string if no input from user.

while (string.IsNullOrEmpty(name))                  // While loop sikrer input fra bruker.
{
    Console.WriteLine("Please enter your name.");
    name = Console.ReadLine() ?? "";
}

Console.WriteLine($"Hello, {name}.");


/*
NOTE:
Using var since warning when using string.

Warning on first test:
C:\Github\miniTasks\nameInputProgram\Program.cs(4,15): warning CS8600: Converting null literal or possible null value
 to non-nullable type. [C:\Github\miniTasks\nameInputProgram\nameInputProgram.csproj]

Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}.");

*/