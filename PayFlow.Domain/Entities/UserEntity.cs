using System;

namespace PayFlow.Domain.Entities;

public class UserEntity : BaseEntity
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}