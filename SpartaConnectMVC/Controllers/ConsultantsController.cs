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
                string newInput = char.ToUpper(input[0]) + input.Substring(1);
                var result = jsonresult.Where(x => x.FirstName.StartsWith(newInput) || x.LastName.StartsWith(newInput) || newInput == null);
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
        

        // GET: Consultants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultant
                .FirstOrDefaultAsync(m => m.ConsultantId == id);
            if (consultant == null)
            {
                return NotFound();
            }

            return View(consultant);
        }


        private bool ConsultantExists(int id)
        {
            return _context.Consultant.Any(e => e.ConsultantId == id);
        }
    }
}
