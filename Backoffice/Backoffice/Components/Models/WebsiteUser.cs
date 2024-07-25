namespace Backoffice.Components.Models;

public class WebsiteUser
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string? Biography { get; set; }
    public bool NewsletterSubscriber { get; set; }
    public string? ProfileImage { get; set; }
    public WebsiteUserAddressModel Address { get; set; }
}
