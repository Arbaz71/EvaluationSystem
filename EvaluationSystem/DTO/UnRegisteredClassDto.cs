﻿namespace EvaluationSystem.DTO
{
    public class UnRegisteredClassDto
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Credit { get;set; }
        public string InstructorName { get; set; }
        public Action ActionType { get; set; }  
    }
}
