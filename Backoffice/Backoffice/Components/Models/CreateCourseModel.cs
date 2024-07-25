namespace Backoffice.Components.Models;

public class CreateCourseModel
{
    public string? name { get; set; }
    public string? description { get; set; }
    public string? ingress { get; set; }
    public decimal price { get; set; }
    public int hoursToComplete { get; set; }
    public int likesPercentage { get; set; }
    public int likesAmount { get; set; }
    public string? image { get; set; }


    public string? authorName { get; set; }
    public string? authorDescription { get; set; }
    public string? authorImage { get; set; }


    public int authorYoutubeFollowersQty { get; set; }
    public int authorFacebookFollowersQty { get; set; }
}
