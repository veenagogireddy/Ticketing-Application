using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _665Project_ASP.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Demo7.Controllers
{
    public class RestrictController : Controller
    {
        private readonly Team113DBContext _context;

        public RestrictController(Team113DBContext context)
        {
            _context = context;
        }


        public IActionResult MyDetails()
        {
            // retrieve the user's PK from the Claims collection
            // since the PK is stored as a string, it has to be parsed to an integer

            int userPK = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value);

            // retrieve the user's orders

            var userDetail = _context.Users
               
                .Where(u => u.UserId == userPK);

            return View(userDetail.ToList());
        }

        [Authorize]
        public async Task<IActionResult> MyEvents()
        {
            // retrieve the user's PK from the Claims collection
            // since the PK is stored as a string, it has to be parsed to an integer

            int userPK = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value);

            // retrieve the user's orders


            var eventDetail = _context.Users
              .Include(od => od.PurchasedEvents)
              .Include(od => od.Events)
              .Where(u => u.UserId == userPK);
             
            return View(await eventDetail.ToListAsync());
        }

        public IActionResult UpdateUser(int? UserId)
        {
            if (UserId == null)
            {
                return RedirectToAction(nameof(MyDetails));
            }

            var user = _context.Users.FirstOrDefault(p => p.UserId == UserId);

            if (user == null)
            {
                return RedirectToAction(nameof(MyDetails));
            }

            return View(user);
        }



    }
}