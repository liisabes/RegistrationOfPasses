using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.StudentSkips
{
    public class DeleteModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public DeleteModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        [BindProperty]
      public StudentSkip StudentSkip { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StudentSkips == null)
            {
                return NotFound();
            }

            var studentskip = await _context.StudentSkips
                                .Include(s => s.CnSNavigation)
                                .Include(s => s.IdCauseNavigation)
                                .Include(s => s.IdSubjectTeacherNavigation)
                                .Include(s => s.IdEmpFornNavigation)
                                .AsNoTracking()
                                .FirstOrDefaultAsync(m => m.IdStudentSkip == id);
            if (studentskip == null)
            {
                return NotFound();
            }
            else 
            {
                StudentSkip = studentskip;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.StudentSkips == null)
            {
                return NotFound();
            }
            var studentskip = await _context.StudentSkips.FindAsync(id);

            if (studentskip != null)
            {
                StudentSkip = studentskip;
                _context.StudentSkips.Remove(StudentSkip);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
