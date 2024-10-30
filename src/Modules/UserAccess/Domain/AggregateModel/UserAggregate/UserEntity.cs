using System;

namespace PayFlow.Domain.Entities;

public class UserEntity : BaseEntity
{
    public UserEntity(
        string username, 
        string email, 
        string password
    )
    {
        Username = username;
        Email = email;
        Password = password;
    }

    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}
