using Newtonsoft.Json;

namespace Backoffice.Components.Models.GraphQL;

public class Data
{
    [JsonProperty("GetCourses")]
    public List<CourseModel>? GetCourses { get; set; }

    public CourseModel? GetCourseById {  get; set; }
}
