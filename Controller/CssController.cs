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
        // here we can use string but we need to return the result and than rendered it 
        // so it's a better approach to return it as a Content
        public ContentResult Get()
        {
            return Content(cssService.getCss());
        }

    }
}
/*
 adding in the start up file
 */
