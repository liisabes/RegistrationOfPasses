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
    public class IndexModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public IndexModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        public IList<SubjectTeacher> SubjectTeacher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.SubjectTeachers != null)
            {
                SubjectTeacher = await _context.SubjectTeachers
                .Include(s => s.CnGNavigation)
                .Include(s => s.CnTNavigation)
                .Include(s => s.IdSubjectNavigation).ToListAsync();
            }
        }
    }
}
