namespace EvaluationSystem.Models
{
    public class Admin:User
    {
        public int AdminId { set; get; }
        public string AdminName { set; get; }
        public List<Student> Students { set; get; }
        public List<Instructor> Instructors { set; get; }
        public List<DepartmentManager> DepartmentManagers { set; get; }
    }
}
