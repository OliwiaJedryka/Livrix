using System.Runtime.CompilerServices;

namespace API.Entities; // This class represents the application user and will be used for authentication and authorization purposes.

public class AppUser // Inherit from IdentityUser to include properties like Id, UserName, etc.
{
    public string Id { get; set; } = Guid.NewGuid().ToString(); // Generate a new unique identifier for each user.

    public required string UserName { get; set; } 

    public string? Name { get; set; }

    public required string Email { get; set; }
}
