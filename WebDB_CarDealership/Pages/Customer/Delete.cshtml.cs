﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_CarDealership.Data;
using WebDB_CarDealership.Models;

namespace WebDB_CarDealership.Pages.Customer
{
    public class DeleteModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;

        public DeleteModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customers Customers { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customers = await _context.Customers
                .Include(c => c.Auto)
                .Include(c => c.Staff).FirstOrDefaultAsync(m => m.ID == id);

            if (Customers == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customers = await _context.Customers.FindAsync(id);

            if (Customers != null)
            {
                _context.Customers.Remove(Customers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
