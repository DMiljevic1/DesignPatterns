namespace DesignPattern.FacadePattern.Systems;

public class UserManager
{
    public void AuthenticateUser() => Console.WriteLine("Authenticating user...");
    public void LoadUserProfile() => Console.WriteLine("Loading user profile...");
}
