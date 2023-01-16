using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tech_Mela_Final.Model;
using Tech_Mela_Final.Services;

namespace Tech_Mela_Final.Pages
{
    public class EventsPageModel : PageModel
    {
       public jsonEventDetailsService service { get; }
       public IEnumerable<Events> EventDetails;
        public EventsPageModel(jsonEventDetailsService service)
        {
            this.service = service;
        }

        public void OnGet()
        {
            EventDetails = service.getEventDetails();
        }
    }
}
