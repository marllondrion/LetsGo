using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LetsGo.API.Models;

namespace LetsGo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        public IEnumerable<Event> _event = new Event[]{
     new Event(){
                Id=1,
                Title = "Guns N' Roses ",
                Localization = "Melbourne",
                Release = "1st release",
                Capacity = 43222,
                Date = DateTime.Now.AddDays(2),
                Online = false,
                UrlImage = "https://www.udiscovermusic.com/wp-content/uploads/2020/03/Guns-N-Roses-GettyImages-1201731181.jpg"
                },
                new Event(){
                Id=2,
                Title = "Guns N' Roses ",
                Localization = "Sydney",
                Release = "2st release",
                Capacity = 322,
                Date = DateTime.Now.AddDays(2),
                Online = false,
                UrlImage = "https://www.udiscovermusic.com/wp-content/uploads/2020/03/Guns-N-Roses-GettyImages-1201731181.jpg"
                }
};

        public EventController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

           [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _event.First(e => e.Id == id);
        }

           [HttpGet("{date}")]
        public IEnumerable<Event> GetbyDate(DateTime date)
        {
            return _event.Where(e => e.Date.Date == date.Date);
        }
        
    }
}
