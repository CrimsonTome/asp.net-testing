using System.Text.Json;
using System.Text.Json.Serialization;

public class Feed
{
    [JsonPropertyName("author_name")]
    public string? author { get; set; }

    [JsonPropertyName("feed_uri")]
    public string? feed { get; set; }
    
    [JsonPropertyName("github_username")]
    public string? gh_name { get; set; }

    public override string ToString()
    {
        JsonSerializer.Serialize<Feed>(this);
        return base.ToString();
    }
}