using Hillerød_Sejlklub_website.Model;
using Hillerød_Sejlklub_website.Service;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hillerød_Sejlklub_website.Pages
{
    public class EventsModel : PageModel
    {

        private EventService _eventure;
        [BindProperty]
        public Event eventure { get; set; }
        public List<Event> events { get; set; }
        public EventsModel(EventService eventure2)
        {
            _eventure = eventure2;
            eventure = new Event();
        }

       

        public IActionResult OnPost()
        {
            _eventure.Add(eventure);
            return RedirectToPage("/Events");
        }

        public void OnGet()
        {
            events = _eventure.GetAll();
        }
    }
}
