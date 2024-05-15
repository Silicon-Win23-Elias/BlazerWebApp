using Microsoft.AspNetCore.Identity;

namespace BlazerWebApp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string ContactEmail { get; set; } = null!;
    public string? ProfileImageUrl { get; set; }
    public string? Bio { get; set; }
    public bool IsSubscribed { get; set; } = false;
    public bool CodeVerified { get; set; } = false;
    public bool IsAdmin { get; set; } = false;
    public bool DarkmodeActive { get; set; } = false;
    public string? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}
