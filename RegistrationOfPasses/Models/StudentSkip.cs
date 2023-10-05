using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistrationOfPasses.Models
{
    public partial class StudentSkip
    {
        public int IdStudentSkip { get; set; }
        public int CnS { get; set; }
        public int IdCause { get; set; }


        [Display(Name = "Дата")]
        public DateTime? Date { get; set; }


        [Display(Name = "Количество часов")]
        public int CountHour { get; set; }


        public int? IdEmpForn { get; set; }
        public int? IdSubjectTeacher { get; set; }


        [Display(Name = "ФИО учащегося")]
        public virtual Student CnSNavigation { get; set; } = null!;


        [Display(Name = "Причина пропуска")]
        public virtual Cause IdCauseNavigation { get; set; } = null!;


        [Display(Name = "Вид пропущенного занятия")]
        public virtual EmpForm? IdEmpFornNavigation { get; set; }


        [Display(Name = "Группа")]
        public virtual SubjectTeacher? IdSubjectTeacherNavigation { get; set; }


        public virtual ListPaidWorkingOff? ListPaidWorkingOff { get; set; }
    }
}
