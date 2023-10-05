using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.Causes
{
    public class EditModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public EditModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cause Cause { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Causes == null)
            {
                return NotFound();
            }

            var cause =  await _context.Causes.FirstOrDefaultAsync(m => m.IdCause == id);
            if (cause == null)
            {
                return NotFound();
            }
            Cause = cause;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cause).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CauseExists(Cause.IdCause))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CauseExists(int id)
        {
          return (_context.Causes?.Any(e => e.IdCause == id)).GetValueOrDefault();
        }
    }
}
