using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Tech_Mela_Final.Services
{
    public class CssService
    {
        IWebHostEnvironment webHostEnvironment { get; }
        public CssService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public string getpath()
        {
            return Path.Combine(webHostEnvironment.WebRootPath, "css", "site.css");
        }
        public string getCss()
        {
            using(var file = File.OpenText(getpath()))
            {
                return file.ReadToEnd();
            }
        }
    }
}
