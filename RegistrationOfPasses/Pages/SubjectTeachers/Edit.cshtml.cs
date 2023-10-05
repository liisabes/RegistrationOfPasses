using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.SubjectTeachers
{
    public class EditModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public EditModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SubjectTeacher SubjectTeacher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SubjectTeachers == null)
            {
                return NotFound();
            }

            var subjectteacher =  await _context.SubjectTeachers.FirstOrDefaultAsync(m => m.IdSubjectTeacher == id);
            if (subjectteacher == null)
            {
                return NotFound();
            }
            SubjectTeacher = subjectteacher;
           ViewData["CnG"] = new SelectList(_context.Groups, "CnG", "CnG");
           ViewData["CnT"] = new SelectList(_context.Teachers, "CnT", "CnT");
           ViewData["IdSubject"] = new SelectList(_context.Subjects, "IdSubject", "IdSubject");
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

            _context.Attach(SubjectTeacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectTeacherExists(SubjectTeacher.IdSubjectTeacher))
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

        private bool SubjectTeacherExists(int id)
        {
          return (_context.SubjectTeachers?.Any(e => e.IdSubjectTeacher == id)).GetValueOrDefault();
        }
    }
}
