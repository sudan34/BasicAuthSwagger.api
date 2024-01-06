namespace BasicAuthSwagger.api.Services
{
    public class UserService : IUserService
    {
        public bool ValidateUser(string username, string password)
        {
            return username == "admin" && password == "admin123";
        }
    }
}
