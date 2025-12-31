namespace GestorTareas.Repositories;



public interface ITaskRepository
{

    // Obtener todas las tareas (para "Ver Tareas")
    List<Task> GetAll();

    // Obtener una tarea por su ID (para "Ver Detalles de la Tarea")
    Task? GetById(int id);

    // Insertar, actualizar y eliminar tareas
    void Add(Task task);
    void Update(Task task);
    void Delete(int id);

}