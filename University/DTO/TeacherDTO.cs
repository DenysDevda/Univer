using System;


namespace University.DTO
{
    public class TeacherDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeachersType { get; set; }
        public string CourseName { get; set; }
        public int? CourseNumber { get; set; }
        public string SubjectName { get; set; }
        public int? BribePrice { get; set; }
    }
}
