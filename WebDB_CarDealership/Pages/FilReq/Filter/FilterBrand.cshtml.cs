using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_CarDealership.Models;

namespace WebDB_CarDealership.Pages.FilReq.Filter
{
    public class FilterBrandModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;
        public FilterBrandModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }
        public Manufacturers Manufacturers { get; set; }
        public IList<Auto> Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufacturers = await _context.Manufacturers.FirstOrDefaultAsync(m => m.ID == id);

            if (Manufacturers == null)
            {
                return NotFound();
            }
            Auto = await _context.Auto.Include(s => s.Manuf).Where(m => m.ManufID == Manufacturers.ID).ToListAsync();
            return Page();
        }
    }
}
