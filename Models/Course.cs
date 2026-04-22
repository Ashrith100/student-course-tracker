namespace StudentCourseTracker.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = "";
        public string Professor { get; set; } = "";
        public int Credits { get; set; }
        public string Semester { get; set; } = "";
        public string Status { get; set; } = "";
    }
}