
namespace GestorTareas.Menu;

public class menuTask
{

    public void Run()
    {

        Console.WriteLine("1.See Tasks"); //Imprime by console
        Console.WriteLine("2.Create Task");
        Console.WriteLine("3.Delete Task");

        if (!int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Invalid input. Please input a number");
        }
        switch (result)
        {
            case 1:
                Console.WriteLine("Here see the tasks");
                break;
            case 2:
                Console.WriteLine("Here create the task");
                break;
            case 3:
                Console.WriteLine("Here delete the task");
                break;
            default:
                Console.WriteLine("Default");
                break;
        }

    }

}