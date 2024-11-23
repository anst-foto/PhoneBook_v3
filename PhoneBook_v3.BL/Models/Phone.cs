using MongoDB.Bson.Serialization.Attributes;

namespace PhoneBook_v3.BL.Models;

public class Phone
{
    public required string Number { get; set; }
    public required string Type { get; set; }
    
    [BsonIgnoreIfNull]
    public string? Comment { get; set; }
}