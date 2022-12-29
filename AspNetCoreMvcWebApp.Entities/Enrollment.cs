using AspNetCoreMvcWebApp.Entities.Constants;

namespace AspNetCoreMvcWebApp.Entities
{
    /// <summary>
    /// Represents the relation between the <see cref="Student"/> entity and the <see cref="Course"/> entity.
    /// </summary>
    public class Enrollment
    {
        /// <summary>
        /// Enrollment ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Relation with student.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Relation with the course.
        /// </summary>
        public int CourseId { get; set; }

        public Grade? Grade{ get; set; }

        /// <summary>
        /// Look up entity to the student entity.
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Look up entity to the course entity.
        /// </summary>
        public Course Course { get; set; }

    }
}