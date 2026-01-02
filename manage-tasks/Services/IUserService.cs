using System.Runtime.CompilerServices;

public interface IUserService
{
    // The service to create the user
    void createUser(string username, string password , string repeatingPassword);

    // The service to update the name user
    void updateUserName(string username, string password , string repeatingPassword , string newName);

    // The service to update the password user
    void updateUserPassword(string username , string password , string repeatingPassword , string newPassword);

    // The service to delete the user
    void deleteUser(string username, string password , string repeatingPassword);

    // The service to know if the user exit or not
    bool userExists(string username);

}


