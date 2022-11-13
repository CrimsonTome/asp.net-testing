using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp.net_testing.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public FeedService fsrv;
    public IEnumerable<Feed> Feeds {get; private set; }

    public IndexModel(ILogger<IndexModel> logger,
        FeedService feedService)
    {
        _logger = logger;
        fsrv = feedService;
    }

    public void OnGet()
    {
        Feeds = fsrv.GetFeeds();
    }
}
