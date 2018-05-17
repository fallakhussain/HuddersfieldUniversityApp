namespace HuddersfieldUniversity.Models
{
    public class Enrollment
    {
        public enum GradeEnum
        {
            A, B, C, D, F
        }

        public int EnrollmentID { get; set; }
        // Foreign key
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //The question mark after the Grade type declaration indicates that the Grade property is nullable.
        public GradeEnum? Grade { get; set; }

        //Entity Framework interprets a property as a foreign key property if it's named <navigation property name><primary key property name>
        //(for example, StudentID for the Student navigation property since the Student entity's primary key is ID).
        public Course Course { get; set; }
        public Student Student { get; set; }



    }
}