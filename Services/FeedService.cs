using System.Text.Json;


public class FeedService
{
    public FeedService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    public IWebHostEnvironment WebHostEnvironment { get; }

    private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "feeds.json");

    public IEnumerable<Feed> GetFeeds()
    {
        using var jsonFileReader = File.OpenText(JsonFileName);
        return JsonSerializer.Deserialize<Feed[]>(jsonFileReader.ReadToEnd());
    }
}