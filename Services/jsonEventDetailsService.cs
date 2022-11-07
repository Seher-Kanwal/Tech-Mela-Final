using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Tech_Mela_Final.Models;

namespace Tech_Mela_Final.Services
{
    public class jsonEventDetailsService
    {
        /* we create this bcs we want to locate the root folder to get json file and this is possible only 
         * if we are able to get the enviroment of the host */
        IWebHostEnvironment webHostEnvironment { get; }

        // Constructor for getting the webhost enviroment
        public jsonEventDetailsService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        // Fn for getting path dynamically 
        public string getpath()
        {
            return Path.Combine(webHostEnvironment.WebRootPath, "Data", "event.json");
        }

        public IEnumerable<Events> getEventDetails()
        {
            // Here we are opening a file through Using bcz it handles exceptions too
            using (var file = File.OpenText(getpath()))
            {
                return JsonSerializer.Deserialize<Events[]>(file.ReadToEnd());
            }
        }
        public string Get(int id, string heading, string image, string desription, string speaker) {
            return " ";
        }

    }
}


/*
 1 - Create webhost var
 2 - getpath fn
 3 - fn for getting record (in file we have an array of file so we're deseriliaze in context of Events[] )
 4 - Add this in your start up file
 */
