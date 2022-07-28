/// <summary>
/// This program determines whether an input from a user is a prime number or not.
/// </summary>

//Collect user input.

try
{
    do
    {
        Console.WriteLine("Enter a number to find out if it's prime or not: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // instantiate the divisor variable which will tell the number of divisors the number has
        // and set it to zero.

        int divisor = 0;

        // create a for loop to loop through all the possible integers.
        for (int i = 1; i <= number; i++)
        {
            //determine if the number has only two divisors, i.e 1 and the number itself.
            if (number % i == 0)
            {
                divisor++;
            }
        }
        if (divisor == 2)
        {
            Console.WriteLine($"The number {number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"The number {number} is not a prime number.");
        }
        Console.WriteLine("Do you want to make another check? (Y / N)");

    } while (Console.ReadLine().ToUpper() == "Y");

    Console.WriteLine("Thanks, BYE!");
}
catch (Exception ex)
{
    Console.WriteLine("Enter a valid number (an integer).");
}