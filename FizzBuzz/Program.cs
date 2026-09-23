using FizzBuzzClassLibrary;

var fizzBuzzService = new FizzBuzzService();

while (true)
{
    try
    {
        Console.WriteLine();

        Console.Write("Enter three integers X Y N separated by spaces where 1 <= X < Y <= N <= 100: ");

        fizzBuzzService.ReadInput(100);

        Console.WriteLine();

        fizzBuzzService.WriteFizzBuzz();

        Console.WriteLine();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        continue;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        break;
    }

    if (!Continue())
    {
        break;
    }
}

static bool Continue()
{
    while (true)
    {
        Console.Write("Do you want to continue? (Y/N): ");

        string? input = Console.ReadLine();

        if (input != null && input.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        else if (input != null && input.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }
    }
}
