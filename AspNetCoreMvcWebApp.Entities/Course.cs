namespace AspNetCoreMvcWebApp.Entities
{
    /// <summary>
    /// Represents the Course table structure in the SQL server database.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Course ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Course name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Course credits.
        /// </summary>
        public int? Credits { get; set; }

        /// <summary>
        /// Lookup property to the enrollments.
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}