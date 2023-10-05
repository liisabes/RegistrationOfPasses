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
    public class IndexModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public IndexModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        public IList<StudentSkip> StudentSkips { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.StudentSkips != null)
            {
                StudentSkips = await _context.StudentSkips
                .Include(s => s.CnSNavigation)
                .Include(s => s.IdCauseNavigation)
                .Include(s => s.IdEmpFornNavigation)
                .Include(s => s.IdSubjectTeacherNavigation).ToListAsync();
            }
        }
    }
}
