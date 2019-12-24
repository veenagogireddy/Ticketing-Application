using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _665Project_ASP.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace _665Project_ASP.Controllers
{
    public class EventsController : Controller
    {
        private readonly Team113DBContext _context;

        public EventsController(Team113DBContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            int userPK = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value);

            var team113DBContext = _context.Events.Include(e => e.EventOrganizer)
                .Where(a => a.EventOrganizerId == userPK);
               
            return View(await team113DBContext.ToListAsync());
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var events = await _context.Events
                .Include(e => e.EventOrganizer)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (events == null)
            {
                TempData["success"] = "No Events to be displayed";
                //return RedirectToAction(nameof(Index));
            }

            return View(events);
        }

        public async Task<IActionResult> EventDetails(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var events = await _context.Events
                .Include(e => e.EventOrganizer)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (events == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(events);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            int userPK = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value);
            ViewData["EventOrganizerId"] = new SelectList(_context.Users.Include(a => a.Events).Where(e => e.UserId == userPK), "UserId", "EmailId") ;
            return View();
        }

        public async Task<IActionResult> ApproveDenyEvents()
        {

            var team113DBContext = _context.Events.Include(e => e.EventOrganizer)
               .Where(a => a.EventStatus == "W");
            return View(await team113DBContext.ToListAsync());
        }


        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventId,EventName,EventVenue,EventDuration,EventDate,EventStatus,EventOrganizerId,EventType,EventCity,EventZip,EventDescription,EventStartTime")] Events events)
        {
            if (ModelState.IsValid)
            {
                if (events.EventDate >= DateTime.Now.Date)
                {

                    _context.Add(events);
                    await _context.SaveChangesAsync();
                    TempData["success"] = "New Event Created";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["message"] = "Cannot create event with past date";
                   
                }
            }
            ViewData["EventOrganizerId"] = new SelectList(_context.Users, "UserId", "EmailId", events.EventOrganizerId);
            return View(events);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var events = await _context.Events.FindAsync(id);
            if (events == null)
            {
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventOrganizerId"] = new SelectList(_context.Users, "UserId", "EmailId", events.EventOrganizerId);
            return View(events);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventId,EventName,EventVenue,EventDuration,EventDate,EventStatus,EventOrganizerId,EventType,EventCity,EventZip,EventDescription,EventStartTime")] Events events)
        {
            if (id != events.EventId)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(events);
                    await _context.SaveChangesAsync();
                    TempData["success"] = "Event details have been updated";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventsExists(events.EventId))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        TempData["message"] = "Event details were not updated";
                        return RedirectToAction(nameof(Index));
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventOrganizerId"] = new SelectList(_context.Users, "UserId", "EmailId", events.EventOrganizerId);
            return View(events);
        }

        public async Task<IActionResult> ApproveEvent(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var events = await _context.Events
                .Include(e => e.EventOrganizer)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (events == null)
            {
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventOrganizerId"] = new SelectList(_context.Users, "UserId", "EmailId", events.EventOrganizerId);
            return View(events);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveEvent(int id, [Bind("EventId,EventName,EventVenue,EventDuration,EventDate,EventStatus,EventOrganizerId,EventType,EventCity,EventZip,EventDescription,EventStartTime")] Events events)
        {
          
            if (id != events.EventId)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(events);
                    await _context.SaveChangesAsync();
                    TempData["success"] = "Event is approved";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventsExists(events.EventId))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        TempData["message"] = "Event is not approved";
                        return RedirectToAction(nameof(Index));
                    }
                }


                return RedirectToAction("ApproveDenyEvents", "Events");
            }
            ViewData["EventOrganizerId"] = new SelectList(_context.Users, "UserId", "EmailId", events.EventOrganizerId);
            return View(events);
        }

        public async Task<IActionResult> DenyEvent(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var events = await _context.Events
                .Include(e => e.EventOrganizer)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (events == null)
            {
                return NotFound();
            }
            ViewData["EventOrganizerId"] = new SelectList(_context.Users, "UserId", "EmailId", events.EventOrganizerId);
            return View(events);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DenyEvent(int id, [Bind("EventId,EventName,EventVenue,EventDuration,EventDate,EventStatus,EventOrganizerId,EventType,EventCity,EventZip,EventDescription,EventStartTime")] Events events)
        {

            if (id != events.EventId)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(events);
                    await _context.SaveChangesAsync();
                    TempData["success"] = "Event is denied";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventsExists(events.EventId))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        TempData["message"] = "Error in denying the event";
                        return RedirectToAction(nameof(Index));
                    }
                }


                return RedirectToAction("ApproveDenyEvents", "Events");
            }
            ViewData["EventOrganizerId"] = new SelectList(_context.Users, "UserId", "EmailId", events.EventOrganizerId);
            return View(events);
        }


        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var events = await _context.Events
                .Include(e => e.EventOrganizer)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (events == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(events);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var events = await _context.Events
                .Include(a => a.PurchasedEvents)
                .Where(a => a.EventId == id)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (!(events.PurchasedEvents.Count == 0))
            {
                TempData["message"] = "Event cannot be deleted as there are users registered for the event";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                _context.Events.Remove(events);
                await _context.SaveChangesAsync();
                TempData["success"] = "Event has been deleted successfully";
            }
            return RedirectToAction(nameof(Index));
        }

        private bool EventsExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}
