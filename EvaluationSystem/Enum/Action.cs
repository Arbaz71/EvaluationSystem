using System.ComponentModel.DataAnnotations;

namespace EvaluationSystem.Enum
{
    public enum Action
    {
        [Display(Name = "Join This Class")]
        JoinThisClass,
        [Display(Name = "Wait For Manager to Add Instructor ")]
        WaitForInstructor
    }
}
