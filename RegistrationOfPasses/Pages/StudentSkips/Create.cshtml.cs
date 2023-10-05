using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.StudentSkips
{
    public class CreateModel : Id_PageModel
    {
        private readonly RegistrationOfPasses.Models.ROfPContext _context;

        public CreateModel(RegistrationOfPasses.Models.ROfPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateIdCauseDropDownList(_context);
            PopulateIdEmpFornsDropDownList(_context);
            PopulateIdSubjectTeachersDropDownList(_context);
            PopulateCnSDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public StudentSkip StudentSkip { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudentSkip = new StudentSkip();

            if (await TryUpdateModelAsync<StudentSkip>(
                emptyStudentSkip,
                "StudentSkip",
                s => s.IdCause, s => s.IdEmpForn, s => s.IdSubjectTeacher, s => s.CnS, s => s.Date, s => s.CountHour))
            {
                _context.StudentSkips.Add(emptyStudentSkip);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            PopulateIdCauseDropDownList(_context, StudentSkip.IdCause); // если модель не валидна, то повторно заполняем выпадающие списки с сохранением выбранных значений
            PopulateIdEmpFornsDropDownList(_context, StudentSkip.IdEmpForn);
            PopulateIdSubjectTeachersDropDownList(_context, StudentSkip.IdSubjectTeacher);
            PopulateCnSDropDownList(_context, StudentSkip.CnS);
            
            return Page();
        }
    }
}
