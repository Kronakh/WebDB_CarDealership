using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebDB_CarDealership.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;
        public IndexModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {

            _context = context;
        }

        public IList<SelectListItem> SelPosition { get; set; }
        public IList<SelectListItem> SelManuf { get; set; }
        public IList<SelectListItem> SelBT { get; set; }
        public IList<SelectListItem> SelMarkCompletion { get; set; }
        public IList<SelectListItem> SelMarkPay { get; set; }
        public void OnGet()
        {

            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();

        }
    }
}
