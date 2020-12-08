﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebDB_CarDealership.Data;
using WebDB_CarDealership.Models;

namespace WebDB_CarDealership.Pages.AEs
{
    public class CreateModel : PageModel
    {
        private readonly WebDB_CarDealership.Data.WebDB_CarDealershipContext _context;

        public CreateModel(WebDB_CarDealership.Data.WebDB_CarDealershipContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AdditionalEquipment AdditionalEquipment { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AdditionalEquipment.Add(AdditionalEquipment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
