namespace GestorTareas.Models;

public class Task
{
    // Attributes
    private int id;
    private string title;
    private string description;
    private DateTime dateCreated;
    private DateTime? dateFinished;

    // Getters and Setters
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public DateTime DateCreated
    {
        get { return dateCreated; }
        set { dateCreated = value; }
    }

    public DateTime? DateFinished
    {
        get { return dateFinished; }
        set { dateFinished = value; }
    }

    // Constructor
    public Task(int id, string title, string description, DateTime dateCreated, DateTime? dateFinished = null)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.dateCreated = dateCreated;
        this.dateFinished = dateFinished;
    }


}