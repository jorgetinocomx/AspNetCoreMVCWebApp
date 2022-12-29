namespace AspNetCoreMvcWebApp.Entities
{
    /// <summary>
    /// Represents the Student table structure in the SQL server database.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Student name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Student email (optional field).
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Student enrollment date.
        /// </summary>
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// Student enrollment.
        /// </summary>
        public ICollection<Enrollment> Enrollments { get;}
    }
}
