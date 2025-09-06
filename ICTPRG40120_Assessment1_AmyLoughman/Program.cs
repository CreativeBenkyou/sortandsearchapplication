// Amy Loughman
// J123978
// ICT40120: ICTPRG433 & ICTPRG440
// Assessment 1: Sort and Search Application - Lottery

using static System.Runtime.InteropServices.JavaScript.JSType;

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
int userValues = 0;

// Take input for amountOfNumbers (line 11)
bool amountOfNumbersBool = true;

while (amountOfNumbersBool == true)
{
    Console.WriteLine(@"
Please input how many numbers you would like on your lottery ticket?
");
    string amountOfNumbersString = Console.ReadLine();
    if (int.TryParse(amountOfNumbersString, out int amountOfNumbersInt))
    {
        amountOfNumbers = amountOfNumbersInt;
        if (amountOfNumbers == 0)
        {
            Console.WriteLine(@"
Please enter a number, it can't be 0 ");
        }
        else if (amountOfNumbers > 100)
        {
            Console.WriteLine(@"
Please enter a number between 1 and 100 ");
        }
        else
        {
            amountOfNumbersBool = false;
        }
            // Debug: Is the number being recorded?
            // Console.WriteLine(amountOfNumbers);
    }
    else
    {
        Console.WriteLine(@"
Please enter a number. (This is how may numbers you would like on your lottery ticket - Example: 5) ");
    }
}

// Take input for rangeOfNumbers (line 12)
bool rangeOfNumbersBool = true;

while (rangeOfNumbersBool == true)
{
    Console.WriteLine(@"
Please input the range of numbers you would like on your lottery ticket:
");
    string rangeOfNumbersString = Console.ReadLine();
    if (int.TryParse(rangeOfNumbersString, out int rangeOfNumbersInt))
    {
        rangeOfNumbers = rangeOfNumbersInt;
        if (rangeOfNumbers == 0)
        {
            Console.WriteLine(@"
Please enter a number, it can't be 0 ");
        }
        else if (rangeOfNumbers > 100)
        {
            Console.WriteLine(@"
Please enter a number between 1 and 100 ");
        }
        else
        {
            rangeOfNumbersBool = false;
        }
        // Debug: Is the number being recorded?
        // Console.WriteLine(rangeOfNumbers);
    }
    else
    {
        Console.WriteLine(@"
Please enter a number. (This is the range of numbers you would like on your lottery ticket - Example: 5) ");
    }
}

Console.WriteLine($@"
    Hello and welcome to the Lottery Game!
    You will be playing {amountOfNumbers} numbers
    From a range of 1-{rangeOfNumbers}
    Have fun!
    ");

// Write a function for taking the inputs amountOfNumbers and rangeOfNumbers
// Checking whether it is not 0, whether it is under 100, if it is not a char/string (giving each case a custom feedback and not generic "Use only numbers")
// (Otherwise the game will never end if you can choose more than 100 numbers, in the range of more than 100 numbers)

// Take input for userValuesArray (user inputs numbers to compare to random numbers in randomArray)
int[] userValuesArray = new int[amountOfNumbers];
for (int number = 0; number < userValuesArray.Length; number++)
{
    // Debug: is each number getting iterated over in userValuesArray?
    Console.WriteLine($"Debug: Number {userValuesArray[number]}");


    bool userValuesArrayBool = true;

    while (userValuesArrayBool == true)
    {
        Console.WriteLine($@"
Please input your numbers you would like on your lottery ticket! Please choose {amountOfNumbers} numbers, in the range of 1-{rangeOfNumbers}:
");
        string userValuesArrayString = Console.ReadLine();
        if (int.TryParse(userValuesArrayString, out int userValuesArrayInt))
        {
            userValuesArray[number] = userValuesArrayInt;
            if (userValuesArrayInt == 0)
            {
                Console.WriteLine(@"
Please enter a number, it can't be 0 ");
            }
            else if (userValuesArrayInt > rangeOfNumbers)
            {
                Console.WriteLine($@"
Please enter a number between 1 and {rangeOfNumbers} ");
            }
            else
            {
                userValuesArrayBool = false;
            }
            // Debug: Is the number being recorded?
            // Console.WriteLine(rangeOfNumbers);
        }
        else
        {
            Console.WriteLine(@"
Please enter a number. (This is the range of numbers you would like on your lottery ticket - Example: 5) ");
        }
    }
}

// Make sure length of arrayUserValues is the same as amountOfNumbers
// Make sure range of numbers of arrayUserValues is the same as rangeOfNumbers
// Conversion from input userValues to arrayUserValues
// Conversion from string to int: amountOfNumbers, rangeOfNumbers, userValues
// Import random
// Create array for arrayRandomNumbers
// Use rangeOfNumbers and amountOfNumbers to determine how many numbers and range of numbers
//     To enter into the arrayRandomNumbers
// Compare arrayRandomNumbers to arrayUserValues
//      Bubble search and Linear search