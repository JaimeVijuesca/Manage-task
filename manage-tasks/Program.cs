using GestorTareas.Menu;

bool isRunning = true;

do
{
    Console.Clear();
    Console.WriteLine("Welcome to the program to manage your tasks");
    Console.WriteLine("1. Manage Tasks");
    Console.WriteLine("2. Manage Users");
    Console.WriteLine("3. Help");
    Console.WriteLine("4. Exit");

    // TryParse check is not and int

    if (!int.TryParse(Console.ReadLine(), out int option))    {
        Console.WriteLine("Invalid input. Please enter a number.");
        Console.ReadKey();
        continue;
    }

    switch (option)
    {
        case 1:
            new menuTask().Run();
            break;

        case 2:
            Console.WriteLine("Manage Users");
            break;

        case 3:
            Console.WriteLine("Help");
            break;

        case 4:
            isRunning = false;
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();

} while (isRunning);
