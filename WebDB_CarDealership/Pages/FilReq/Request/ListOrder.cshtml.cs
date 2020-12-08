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
    public class ListOrderModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;

        public ListOrderModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _context.Customers.Include(s => s.Auto).Include(s => s.Staff).ToListAsync();
        }
    }
}
