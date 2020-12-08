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
    public class FilterBodyTypeModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;
        public FilterBodyTypeModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }
        public BodyType BodyType { get; set; }
        public IList<Auto> Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BodyType = await _context.BodyType.FirstOrDefaultAsync(m => m.ID == id);

            if (BodyType == null)
            {
                return NotFound();
            }
            Auto = await _context.Auto.Include(s => s.BT).Where(m => m.BTID == BodyType.ID).ToListAsync();
            return Page();
        }
    }
}
