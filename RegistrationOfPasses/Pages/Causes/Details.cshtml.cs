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
    public class DetailsModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public DetailsModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

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
    }
}
