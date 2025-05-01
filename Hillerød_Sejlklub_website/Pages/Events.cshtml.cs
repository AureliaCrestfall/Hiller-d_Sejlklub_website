using Hillerød_Sejlklub_website.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hillerød_Sejlklub_website.Pages
{
    public class EventsModel : PageModel
    {


        public Event eventure { get; set; }

        public void OnGet()
        {
        }
    }
}
