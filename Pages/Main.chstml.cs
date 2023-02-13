using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class MainModel : PageModel
{
    private readonly ILogger<MainModel> _logger;
    private DateTime paduaDay = new DateTime(2024,06,08,0,0,0);
    private const String weddingDay = "Saturday June 8, 2024";
    private String mainLanguage = "";
    public String countDown()
    {
        DateTime startDate = DateTime.Now;
        TimeSpan t = paduaDay - startDate;
        string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes", t.Days, t.Hours, t.Minutes);
        return countDown;
    }

    public String getWeddingDate() {
        return weddingDay;
    }

    public MainModel(ILogger<MainModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet(String language)
    {
        if (language == null)
        {
            language ="English";
        }
        this.mainLanguage = language;
        return Page();
    }
    public String getLanguage(){
        return this.mainLanguage;
    }
}
