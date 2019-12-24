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
    public class PurchasedEventsController : Controller
    {
        private readonly Team113DBContext _context;

        public PurchasedEventsController(Team113DBContext context)
        {
            _context = context;
        }

        // GET: PurchasedEvents
        public async Task<IActionResult> Index()
        {
            int userPK = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value);
            var team113DBContext = _context.PurchasedEvents.Include(p => p.Event).Include(p => p.User)
                                    .Where(u => u.UserId == userPK);
            return View(await team113DBContext.ToListAsync());
        }

      

        // GET: PurchasedEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var purchasedEvents = await _context.PurchasedEvents
                .Include(p => p.Event)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (purchasedEvents == null)
            {
                TempData["message"] = "You have no purchased any events";
                return RedirectToAction(nameof(Index));
            }

            return View(purchasedEvents);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPurchasedEvents([Bind("EventId,UserId")] PurchasedEvents purchasedEvents)
        {
            var aUser = await _context.PurchasedEvents.FirstOrDefaultAsync(u => u.EventId == purchasedEvents.EventId && u.UserId == purchasedEvents.UserId);

            // if valid

            if (aUser is null)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(purchasedEvents);
                    await _context.SaveChangesAsync();
                    TempData["success"] = "Purchase successfull";
                    return RedirectToAction("Search", "Restrict", new { area = "Users" });
                }
            }
            else
            {
                TempData["message"] = "You have already Purchased this event";
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventCity", purchasedEvents.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailId", purchasedEvents.UserId);
            return View(purchasedEvents);
        }


        // GET: PurchasedEvents/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventCity");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailId");
            return View();
        }

        // POST: PurchasedEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventId,UserId")] PurchasedEvents purchasedEvents)
        {
            int userPK = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value);
            var aUser = await _context.PurchasedEvents.FirstOrDefaultAsync(u => u.EventId == purchasedEvents.EventId && u.UserId == userPK);
            purchasedEvents.UserId = userPK;
            // if valid

            if (aUser is null)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Add(purchasedEvents);
                        await _context.SaveChangesAsync();
                        TempData["success"] = "Purchase successfull";

                    }
                    catch
                    {
                        TempData["message"] = "Purchase failed";
                        return RedirectToAction(nameof(Index));
                    }
                    TempData["success"] = "Purchase successfull";
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                TempData["message"] = "You have already Purchased this event";
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventCity", purchasedEvents.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailId", purchasedEvents.UserId);
            return View(purchasedEvents);
        }

        // GET: PurchasedEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var purchasedEvents = await _context.PurchasedEvents.FindAsync(id);
            if (purchasedEvents == null)
            {
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventCity", purchasedEvents.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailId", purchasedEvents.UserId);
            return View(purchasedEvents);
        }

        // POST: PurchasedEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventId,UserId")] PurchasedEvents purchasedEvents)
        {
           
            if (id != purchasedEvents.EventId)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchasedEvents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchasedEventsExists(purchasedEvents.EventId))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventCity", purchasedEvents.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailId", purchasedEvents.UserId);
            return View(purchasedEvents);
        }

        // GET: PurchasedEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var purchasedEvents = await _context.PurchasedEvents
                .Include(p => p.Event)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (purchasedEvents == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(purchasedEvents);
        }

        // POST: PurchasedEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchasedEvents = await _context.PurchasedEvents.FindAsync(id);
            _context.PurchasedEvents.Remove(purchasedEvents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchasedEventsExists(int id)
        {
            return _context.PurchasedEvents.Any(e => e.EventId == id);
        }
    }
}
