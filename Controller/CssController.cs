using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tech_Mela_Final.Services;

namespace Tech_Mela_Final.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class CssController : ControllerBase
    {
        // create obj of the service
       public CssService cssService { get; }
     public  CssController(CssService cssService)
        {
            this.cssService = cssService;
        }
        [HttpGet]
        public string Get()
        {
            return cssService.getCss();
        }

    }
}

/*
 adding in the start up file
 
 */
