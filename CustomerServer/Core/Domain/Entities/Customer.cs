namespace CustomerServer.Core.Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
}