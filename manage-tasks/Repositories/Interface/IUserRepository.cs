namespace GestorTareas.Repositories;
using GestorTareas.Models;

public interface IUserRepository
{
    // Insertar un usuario (void es suficiente por ahora)
    void Add(User user);

    // Obtener por ID (Devuelve un solo usuario o null '?', no una lista)
    // Cambiamos int a string porque tu modelo User usa string para el ID
    User? GetById(string id);

    // Necesario para el Login: buscar por nombre de usuario
    User? GetByUsername(string username);

    // Actualizar un usuario existente (para la opción "Actualizar Usuario")
    void Update(User user);

    // Eliminar un usuario por su ID (para la opción "Eliminar Usuario")
    void Delete(string id);
}