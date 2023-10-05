using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.Causes
{
    public class DeleteModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public DeleteModel(RegistrationOfPasses.Models.ROfPContext context)
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

            var cause = await _context.Causes.FirstOrDefaultAsync(m => m.IdCause == id);

            if (cause == null)
            {
                return NotFound();
            }
            else 
            {
                Cause = cause;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Causes == null)
            {
                return NotFound();
            }
            var cause = await _context.Causes.FindAsync(id);

            if (cause != null)
            {
                Cause = cause;
                _context.Causes.Remove(Cause);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
