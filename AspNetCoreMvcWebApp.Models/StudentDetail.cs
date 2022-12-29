namespace AspNetCoreMvcWebApp.Models
{
    /// <summary>
    /// VieModel containing some student detail.
    /// </summary>
    public class StudentsDetail
    {
        /// <summary>
        /// Student name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// All the courses where the student is involved
        /// </summary>
        public IEnumerable<string> Courses { get; set; }
    }
}
