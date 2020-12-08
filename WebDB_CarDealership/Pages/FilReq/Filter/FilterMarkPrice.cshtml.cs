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
    public class FilterMarkPriceModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;
        public FilterMarkPriceModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }
        public IList<Customers> Customers { get; set; }

        public async Task<IActionResult> OnGetAsync(bool? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Customers = await _context.Customers.Where(m => m.MarkPrice == id).ToListAsync();
            return Page();
        }
    }
}
