using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Tech_Mela_Final.Model;
using Tech_Mela_Final.Services;

namespace Tech_Mela_Final.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // Decalring an obj of model and service
        // from file we are getting array of the record that's why we user IEnumerable
        public IEnumerable<Events> Event { get; private set; }
        public jsonEventDetailsService jsonEventDetails;

        // Adding in the Constructor too 
        public IndexModel(ILogger<IndexModel> logger, jsonEventDetailsService service)
        {
            _logger = logger;
            this.jsonEventDetails = service;
        }

        // similar to the get and post req this tells us which fn to perform we we do get req for this page
        public void OnGet()
        {
            Event = jsonEventDetails.getEventDetails();
        }
    }
}
