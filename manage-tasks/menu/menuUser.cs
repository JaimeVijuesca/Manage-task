public class menuUser
{
    public void Run()
    {
        Console.WriteLine("1.Create a User");
        Console.WriteLine("2.Update a User");
        Console.WriteLine("3.Delete a User");
        Console.WriteLine("4 Go to the principal Menu");

        if (!int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Is not a number, Please use a number");
        }

        switch (result)
        {
            case 1:
                Console.WriteLine("Create a User");
                break;
            case 2:
                Console.WriteLine("Update a User");
                break;
            case 3:
                Console.WriteLine("Delete a User");
                break;
            case 4:
                Console.WriteLine("Go to the principal menu");
                break;

            default:
                Console.WriteLine("Default message");
                break;
        }

    }
}