using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using _665Project_ASP.Models;

namespace _665Project_ASP.Controllers
{
    public class EventController : Controller
    {
        private readonly Team113DBContext _context;
        public EventController(Team113DBContext context)
        {
            _context = context;
        }

        public IActionResult Search(string searchCity, DateTime? searchEventDate)
        {
           
            ViewData["CityFilter"] = searchCity;
            ViewData["DateFilter"] = searchEventDate;
           
            var events = from p in _context.Events where p.EventStatus=="A" where p.EventDate >= DateTime.Today select p;
            if (!String.IsNullOrEmpty(searchCity))
            {
              
                events = events.Where(p => p.EventCity.Contains(searchCity));
                if(events.Count() == 0)
                {
                    ViewData["message"] = $"No events to be displayed for {searchCity} city";
                }
            }
            if (searchEventDate != null)
            {
                events = events.Where(p => p.EventDate.Equals(searchEventDate));
                if (events.Count() == 0)
                {
                  
                    ViewData["message"] = $"No events to be displayed for event date: {searchEventDate.Value.ToShortDateString()}";
                }
            }
            return View(events.OrderBy(p => p.EventDate).ToList());
          
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Search));
            }

            var events = await _context.Events
               
                .FirstOrDefaultAsync(m => m.EventId == id);

            if (events == null)
            {
                TempData["success"] = "No events to be displayed";
                return RedirectToAction(nameof(Search));
            }

            return View(events);
          
        }


    }
}