using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpartaConnect_API.Models;
using SpartaConnectMVC.Models;
using Newtonsoft.Json;

namespace SpartaConnectMVC.Controllers
{
    public class ConsultantsController : Controller
    {
        private readonly SpartaDBContext _context;

        public ConsultantsController(SpartaDBContext context)
        {
            _context = context;
        }
        static Uri url = new Uri("http://localhost:56767/api/Consultants");

        // GET: Consultants
        /* public async Task<IActionResult> Index()
         {          
             return View(await _context.Consultant.ToListAsync());
         }*/
        public async Task<IActionResult> Index(string input)
        {
            using (var client = new HttpClient())
            {
                var jsonstring = await client.GetStringAsync(url);
                var jsonresult = JsonConvert.DeserializeObject<List<Consultant>>(jsonstring);
                if (input == null)
                {
                    return View(jsonresult);
                }
                var result = jsonresult.Where(x => x.FirstName.Contains(input) || x.LastName.Contains(input) || input == null);
                return View(result);
            }
        }
        public async Task<IActionResult> GetFilterResults(string stream)
        {
            using (var client = new HttpClient())
            {
                var jsonstring = await client.GetStringAsync(url);
                var jsonresult = JsonConvert.DeserializeObject<List<Consultant>>(jsonstring);
                var result = jsonresult.Where(x => x.Stream.Contains(stream));
                if (result == null || stream == null)
                {
                    return NotFound();
                }
                return View("index", result);
            }
        }
        //public async Task<IActionResult> GetFilterResults(string stream)
        //{
        //    var developers = _context.Consultant.Where(x => x.Stream.Contains(stream));
        //    return View("index", await developers.ToListAsync());
        //}
        //public async Task<IActionResult> GetFilterSDET()
        //{
        //    var developers = _context.Consultant.Where(x => x.Stream.Contains("SDET"));
        //    return View("index", await developers.ToListAsync());
        //}
        //public async Task<IActionResult> GetFilterBA()
        //{
        //    var developers = _context.Consultant.Where(x => x.Stream.Contains("BA"));
        //    return View("index", await developers.ToListAsync());
        //}
        //public async Task<IActionResult> GetFilterDevOps()
        //{
        //    var developers = _context.Consultant.Where(x => x.Stream.Contains("DevOps"));
        //    return View("index", await developers.ToListAsync());
        //}


        // GET: Consultants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultant
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.ConsultantId == id);
            if (consultant == null)
            {
                return NotFound();
            }

            return View(consultant);
        }

        // GET: Consultants/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId");
            return View();
        }

        // POST: Consultants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConsultantId,LastName,FirstName,CourseId,Photo,Bio,University,CvLink,VideoLink")] Consultant consultant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consultant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", consultant.CourseId);
            return View(consultant);
        }

        // GET: Consultants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultant.FindAsync(id);
            if (consultant == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", consultant.CourseId);
            return View(consultant);
        }

        // POST: Consultants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConsultantId,LastName,FirstName,CourseId,Photo,Bio,University,CvLink,VideoLink")] Consultant consultant)
        {
            if (id != consultant.ConsultantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultantExists(consultant.ConsultantId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", consultant.CourseId);
            return View(consultant);
        }

        // GET: Consultants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultant
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.ConsultantId == id);
            if (consultant == null)
            {
                return NotFound();
            }

            return View(consultant);
        }

        // POST: Consultants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consultant = await _context.Consultant.FindAsync(id);
            _context.Consultant.Remove(consultant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultantExists(int id)
        {
            return _context.Consultant.Any(e => e.ConsultantId == id);
        }
    }
}
