using System;

namespace LetsGo.API.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Title {get; set;}

        public string Localization {get; set;}

         public string Release {get; set;} 
        
        public int Capacity {get; set;}

        public DateTime Date { get; set; }

        public string UrlImage { get; set; }
    
        public Boolean Online { get; set; }
        
    }
}
