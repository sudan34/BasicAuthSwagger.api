namespace BasicAuthSwagger.api.Services
{
    public interface IUserService
    {
        bool ValidateUser(string username, string password);
    }
}
