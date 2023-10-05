using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.StudentSkips
{
    public class EditModel : Id_PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public EditModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentSkip StudentSkip { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentSkip = await _context.StudentSkips
                .Include(c => c.IdSubjectTeacherNavigation)
                .Include(c => c.IdEmpFornNavigation)
                .Include(c => c.IdCauseNavigation)
                .Include(c => c.CnSNavigation)
                .FirstOrDefaultAsync(m => m.IdStudentSkip == id);

            if (StudentSkip == null)
            {
                return NotFound();
            }

            PopulateIdSubjectTeachersDropDownList(_context);
            PopulateIdEmpFornsDropDownList(_context);
            PopulateIdCauseDropDownList(_context);
            PopulateCnSDropDownList(_context);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idSubjectTeacherToUpdate = await _context.StudentSkips.FindAsync(id);

            if (idSubjectTeacherToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<StudentSkip>(
                 idSubjectTeacherToUpdate,
                 "idSubjectTeacher",
                   c => c.IdStudentSkip, c => c.IdSubjectTeacher, c => c.IdEmpForn, c => c.IdCause, c => c.CnS))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            PopulateIdSubjectTeachersDropDownList(_context, idSubjectTeacherToUpdate.IdSubjectTeacherNavigation);
            PopulateIdEmpFornsDropDownList(_context, idSubjectTeacherToUpdate.IdEmpFornNavigation);
            PopulateIdCauseDropDownList(_context, idSubjectTeacherToUpdate.IdCauseNavigation);
            PopulateCnSDropDownList(_context, idSubjectTeacherToUpdate.CnSNavigation);

            return Page();
        }
    }
}
