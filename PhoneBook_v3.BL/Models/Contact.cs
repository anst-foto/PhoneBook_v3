using MongoDB.Bson.Serialization.Attributes;

namespace PhoneBook_v3.BL.Models;

public class Contact
{
    [BsonId]
    public int Id { get; set; }
    
    public required string Name { get; set; }
    
    [BsonIgnoreIfNull]
    public string? LastName { get; set; }
    [BsonIgnoreIfNull]
    public string? Patronymic { get; set; }
    
    public List<Phone> Phones { get; set; } = [];
}