using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistrationOfPasses.Models;

namespace RegistrationOfPasses.Pages.StudentSkips
{
    public class Id_PageModel : PageModel
    {
        public SelectList IdSubjectTeacher_CnGSL { get; set; }

        public void PopulateIdSubjectTeachersDropDownList(ROfPContext _context,
            object selectedIdSubjectTeacher = null)
        {
            var idSubjectTeachersQuery = from i in _context.SubjectTeachers
                                         orderby i.CnG // Sort by CnG
                                         select i;

            IdSubjectTeacher_CnGSL = new SelectList(idSubjectTeachersQuery.AsNoTracking(),
                nameof(SubjectTeacher.IdSubjectTeacher),
                nameof(SubjectTeacher.CnG),
                selectedIdSubjectTeacher);
        }

        public SelectList IdEmpForn_NameSL { get; set; }

        public void PopulateIdEmpFornsDropDownList(ROfPContext _context,
            object selectedIdEmpForn = null)
        {
            var idEmpFornsQuery = from i in _context.EmpForms
                                  orderby i.Name
                                  select i;

            IdEmpForn_NameSL = new SelectList(idEmpFornsQuery.AsNoTracking(),
                nameof(EmpForm.IdEmpForn),
                nameof(EmpForm.Name),
                selectedIdEmpForn);
        }

        public SelectList IdCauseSL { get; set; }

        public void PopulateIdCauseDropDownList(ROfPContext _context,
            object selectedCause = null)
        {
            var causesQuery = from c in _context.Causes
                              orderby c.Name // Sort by name.
                              select c;

            IdCauseSL = new SelectList(causesQuery.AsNoTracking(),
                nameof(Cause.IdCause),
                nameof(Cause.Name),
                selectedCause);
        }

        public SelectList CnSSL { get; set; }

        public void PopulateCnSDropDownList(ROfPContext _context,
            object selectedCnS = null)
        {
            var cnSQuery = from i in _context.Students
                              orderby i.SurName
                              select i;

            CnSSL = new SelectList(cnSQuery.AsNoTracking(),
                nameof(Student.CnS),
                nameof(Student.SurName),
                selectedCnS);
        }


    }
}
