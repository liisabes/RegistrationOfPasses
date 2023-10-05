using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.SubjectTeachers
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
        ViewData["CnG"] = new SelectList(_context.Groups, "CnG", "CnG");
        ViewData["CnT"] = new SelectList(_context.Teachers, "CnT", "CnT");
        ViewData["IdSubject"] = new SelectList(_context.Subjects, "IdSubject", "IdSubject");
            return Page();
        }

        [BindProperty]
        public SubjectTeacher SubjectTeacher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.SubjectTeachers == null || SubjectTeacher == null)
            {
                return Page();
            }

            _context.SubjectTeachers.Add(SubjectTeacher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
