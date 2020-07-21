using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyectoint.Data;
using Proyectoint.Models;

namespace Proyectoint.Pages.Candidato
{
    public class CreateModel : PageModel
    {
        private readonly Proyectoint.Data.CandiContext _context;

        public CreateModel(Proyectoint.Data.CandiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Candi Candi { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candi.Add(Candi);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
