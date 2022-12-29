using AspNetCoreMvcWebApp.Entities;

namespace AspNetCoreMvcWebApp.DataAccess.Interfaces
{
    /// <summary>
    /// Defines the student dataaccess service contract.
    /// </summary>
    public interface IStudentData
    {
        /// <summary>
        /// Contract specification for: Return an specific student by an ID.
        /// </summary>
        /// <param name="id">Student ID.</param>
        /// <returns>Found student.</returns>
        public Student GetStudent(int id);
    }
}
