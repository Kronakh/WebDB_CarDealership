﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_CarDealership.Data;
using WebDB_CarDealership.Models;

namespace WebDB_CarDealership.Pages.AEs
{
    public class DeleteModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;

        public DeleteModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AdditionalEquipment AdditionalEquipment { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AdditionalEquipment = await _context.AdditionalEquipment.FirstOrDefaultAsync(m => m.ID == id);

            if (AdditionalEquipment == null)
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

            AdditionalEquipment = await _context.AdditionalEquipment.FindAsync(id);

            if (AdditionalEquipment != null)
            {
                _context.AdditionalEquipment.Remove(AdditionalEquipment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
