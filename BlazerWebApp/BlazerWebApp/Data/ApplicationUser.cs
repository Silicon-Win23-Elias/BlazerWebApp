using Microsoft.AspNetCore.Identity;

namespace BlazerWebApp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string ContactEmail { get; set; } = null!;
    public string? ProfileImageUrl { get; set; } = "https://siliconstorageacc.blob.core.windows.net/profile/62d3a08c-ffe5-4e31-a771-d112dd4ea5c3_38661739-8e41-4bb0-b59f-1e0d68ef8ebc_send-you-a-random-png.png";
    public string? Bio { get; set; }
    public bool IsSubscribed { get; set; } = false;
    public bool CodeVerified { get; set; } = false;
    public bool IsAdmin { get; set; } = false;
    public bool DarkmodeActive { get; set; } = false;
    public string? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}
