using System;

namespace PayFlow.Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime Created_At { get; private set; }

    public BaseEntity ()
    {
        Id = new Guid();
        Created_At = new DateTime();
    }
}