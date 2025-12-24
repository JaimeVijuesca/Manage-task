namespace GestorTareas.Models;
class User
{
    private string userId;
    private string userName;
    private string passwordHash;

    private DateTime createdAt;
    public string UserID
    {
        get { return userId; }
        set { userId = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string PasswordHash
    {
        get { return passwordHash; }
        set { passwordHash = value; }
    }
    public DateTime CreatedAt
    {
        get { return createdAt; }
        set { createdAt = value; }
    }

    public User(string userId, string userName, string passwordHash, DateTime createdAt)
    {
        this.userId = userId;
        this.userName = userName;
        this.passwordHash = passwordHash;
        this.createdAt = createdAt;
    }

}