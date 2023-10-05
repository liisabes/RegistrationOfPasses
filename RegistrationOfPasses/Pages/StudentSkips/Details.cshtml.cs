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
    public class DetailsModel : PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public DetailsModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

      public StudentSkip StudentSkip { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StudentSkips == null)
            {
                return NotFound();
            }

            var studentskip = await _context.StudentSkips
                    .Include(s => s.CnSNavigation) // загрузка данных из таблицы CnSNavigation
                    .Include(s => s.IdCauseNavigation) // загрузка данных из таблицы IdCauseNavigation
                    .Include(s => s.IdSubjectTeacherNavigation) // загрузка данных из таблицы IdSubjectTeacherNavigation
                    .Include(s => s.IdEmpFornNavigation) // загрузка данных из таблицы IdEmpFornNavigation
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
    }
}
