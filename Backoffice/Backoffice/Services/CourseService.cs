using Backoffice.Components.Models;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;

namespace Backoffice.Services;


public class CourseService
{

    public async Task<string> GetImageUrlAsync(IBrowserFile File, string containerName, HttpClient http, IConfiguration config)
    {
        try
        {
            if (File == null)
                return null!;

            var content = new MultipartFormDataContent();

            var fileContent = new StreamContent(File!.OpenReadStream(File.Size));

            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(File.ContentType);

            content.Add(fileContent, "file", File.Name);
            content.Add(new StringContent(containerName), "containerName");

            var response = await http.PostAsync(config["Api_FileProvider_Create"], content);

            var unpacked = await response.Content.ReadAsStringAsync();

            var jsonUnpacked = JsonConvert.DeserializeObject<FileUploadResponseModel>(unpacked);

            var imageUrl = jsonUnpacked.FilePath;

            return imageUrl;
        }
        catch
        {
            return null!;
        }      
    }
}
