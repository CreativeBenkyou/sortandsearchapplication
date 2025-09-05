// Amy Loughman
// J123978
// ICT40120: ICTPRG433 & ICTPRG440
// Assessment 1: Sort and Search Application - Lottery

Console.WriteLine(@"
    This is a program for making customisable Lottery games.
    You can customise the games by selecting the range of numbers and total amount of numbers.
    
    Example 1:
    You could play only 4 numbers - (1, 3, 5, 7)
    At a range of (1-10)

    Example 2:
    You could play only 10 numbers - (1, 5, 9, 13, 17, 21, 25, 29, 33, 37)
    At a range of (1-40)
    ");

// Default amountOfNumbers & rangeOfNumbers in case scope is broken
int amountOfNumbers = 4;
int rangeOfNumbers = 10;

// Take input for amountOfNumbers (line 11)
Console.WriteLine("Please input how many numbers you would like on your lottery ticket? ");
string amountOfNumbersString = Console.ReadLine();
if (int.TryParse(amountOfNumbersString, out int amountOfNumbersInt))
{
    amountOfNumbers = amountOfNumbersInt;
    // Debug: Is the number being recorded?
    // Console.WriteLine(amountOfNumbers);
}
else
{
    Console.WriteLine("Please enter a number. (This is how may numbers you would like on your lottery ticket - Example: 5) ");
}

// Take input for rangeOfNumbers (line 12)
Console.WriteLine("Please input how the range of numbers you would like? ");
string rangeOfNumbersString = Console.ReadLine();
if (int.TryParse(rangeOfNumbersString, out int rangeOfNumbersInt))
{
    rangeOfNumbers = rangeOfNumbersInt;
    // Debug: Is the range being recorded?
    // Console.WriteLine(rangeOfNumbers);
}
else
{
    Console.WriteLine("Please enter a number. (This is the range of numbers you would like on your lottery ticket - Example: 40) ");
}

Console.WriteLine($@"
    Hello and welcome to the Lottery Game!
    You will be playing {amountOfNumbers} numbers
    From a range of 1-{rangeOfNumbers}
    Have fun!
    ");
    

// Take input for arrayUserValues (user inputs numbers to compare to random numbers in arrayRandom)



// Make sure length of arrayUserValues is the same as amountOfNumbers
// Make sure range of numbers of arrayUserValues is the same as rangeOfNumbers

// Conversion from input userValues to arrayUserValues
// Conversion from string to int: amountOfNumbers, rangeOfNumbers, userValues
// Import random
// Create array for arrayRandomNumbers
// Use rangeOfNumbers and amountOfNumbers to determine how many numbers and range of numbers
//     To enter into the arrayRandomNumbers
// Compare arrayRandomNumbers to arrayUserValues
//      Bubble sort and Liner sort
