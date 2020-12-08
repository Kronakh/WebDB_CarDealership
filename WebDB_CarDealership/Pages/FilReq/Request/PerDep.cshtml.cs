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
    public class PerDepModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;

        public PerDepModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.Include(s => s.Position).ToListAsync();
        }

    }
}
