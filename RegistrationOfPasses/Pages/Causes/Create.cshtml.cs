using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.Causes
{
    public class CreateModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public CreateModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cause Cause { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Causes == null || Cause == null)
            {
                return Page();
            }

            _context.Causes.Add(Cause);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
