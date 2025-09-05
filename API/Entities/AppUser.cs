
namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    // public required String Id { get; set; }
    public required string DisplayName { get; set; }
    // public string? DisplayName { get; set; } ? means nullable
    public required string Email { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }

}
