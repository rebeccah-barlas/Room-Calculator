Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

Console.WriteLine("Please enter the length of the classroom in feet");
string userInput1 = Console.ReadLine();
decimal roomLength = 0;
bool validNumber1 = decimal.TryParse (userInput1, out roomLength);

Console.WriteLine("Please enter the width of the classroom in feet");
string userInput2 = Console.ReadLine();
decimal roomWidth = 0;
bool validNumber2 = decimal.TryParse (userInput2, out roomWidth);

decimal roomArea = (roomLength * roomWidth);
decimal roomPerimeter = ((roomLength + roomWidth) * 2);

Console.WriteLine($"The area of your room is: {roomArea}");
Console.WriteLine($"The perimeter of your room is: {roomPerimeter}");
if (roomArea <= 250)
{
    Console.WriteLine("This is a small sized room");
}
if (roomArea > 250 && roomArea < 650)
{
    Console.WriteLine("This is a medium sized room");
}
else
{
    Console.WriteLine("This is a large sized room");
}

Console.WriteLine("Thank you for using the Room Detail Generator!");

// Explain in 3 detailed steps how to get input from the user, do calculations to the input to create a new variable, then display it back to the user:
// 1. Accept input from the user as a string via console read line. Try to parse the input into a decimal to ensure a valid number is received.
// 2. Create a new variable that calculates both the room perimeter and room area using the data that was input by the user.
// 3. Provide the result to the user by having the result of the new variable (equation for room area and room perimeter) displayed to the user via console write line.
