using PayFlow.Shared.SeedWork;

namespace PayFlow.User.Domain.AggregateModel;

public sealed class UserEntiy : IAggregateRoot
{
    public UserEntiy() {}

    public UserEntiy(
        string name, 
        string email, 
        string password
    )
    {
        Name = name;
        Email = email;
        Password = password;
    }

    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    internal void UpdateUser(
        string name,
        string email,
        string password
    ) {
        Name = name;
        Email = email;
        Password = password;
    }
}
