using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_CarDealership.Models;

namespace WebDB_CarDealership.Pages.FilReq.Request
{
    public class CatalogAutoModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;

        public CatalogAutoModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }

        public IList<Auto> Auto { get; set; }

        public async Task OnGetAsync()
        {
            Auto = await _context.Auto.Include(s => s.Staff)
                .Include(s => s.Manuf)
                .Include(s => s.BT)
                .ToListAsync();
        }
    }
}
