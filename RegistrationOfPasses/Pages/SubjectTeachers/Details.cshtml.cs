using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.SubjectTeachers
{
    public class DetailsModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public DetailsModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

      public SubjectTeacher SubjectTeacher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SubjectTeachers == null)
            {
                return NotFound();
            }

            var subjectteacher = await _context.SubjectTeachers.FirstOrDefaultAsync(m => m.IdSubjectTeacher == id);
            if (subjectteacher == null)
            {
                return NotFound();
            }
            else 
            {
                SubjectTeacher = subjectteacher;
            }
            return Page();
        }
    }
}
