

namespace GestorTareas.Repositories;



public class TaskRepository : ITaskRepository
{
    // Implement the methods defined in ITaskRepository interface
    public void Add(Models.Task task)
    {
        throw new NotImplementedException();
    }

    public void Add(Task task)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

   
    public void Update(Task task)
    {
        throw new NotImplementedException();
    }

  
    List<Task> ITaskRepository.GetAll()
    {
        throw new NotImplementedException();
    }

    Task? ITaskRepository.GetById(int id)
    {
        throw new NotImplementedException();
    }
}