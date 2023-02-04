using System.Security.Cryptography.X509Certificates;
using System;
namespace TaskManager.Models;

public class Task {
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime DateCreated { get; }
    public List<string> Tags { get; }

    public Task (Guid id, string name, string description, DateTime date_created, List<string> tags) {
        Id = id;
        Name = name;
        Description = description;
        DateCreated = date_created;
        Tags = tags;
    }
}