using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Enum
{
    public enum CourseType
    {
        [Display(Name ="Mandatory")]
        Mandatory,
        [Display(Name ="Elective")]
        Elective
    }
}
