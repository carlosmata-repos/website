using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private DateTime paduaDay = new DateTime(2024,06,08,0,0,0);
    private const String weddingDay = "Saturday June 8, 2024";
    public String countDown()
    {
        DateTime startDate = DateTime.Now;
        TimeSpan t = paduaDay - startDate;
        string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes", t.Days, t.Hours, t.Minutes);
        return countDown;
    }

    public String getImage()
    {
    return "~/images/AnteaCarlos.jpeg";
    }

    public String getWeddingDate() {
        return weddingDay;
    }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public void Configure(IApplicationBuilder app, Microsoft.Extensions.Hosting.IHostEnvironment env, ILoggerFactory loggerFactory)
{
    app.UseStaticFiles();
}

    public void OnGet()
    {

    }
}
