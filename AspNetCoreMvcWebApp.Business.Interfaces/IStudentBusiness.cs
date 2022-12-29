using AspNetCoreMvcWebApp.Models;

namespace AspNetCoreMvcWebApp.Business.Interfaces
{
    /// <summary>
    /// Defines the student business service contract.
    /// </summary>
    public interface IStudentBusiness
    {
        /// <summary>
        /// Contract to:  return the student detail given an specific student id.
        /// </summary>
        /// <param name="studentId">Used to get his/her information detail.</param>
        /// <returns>Found student detail.</returns>
        public StudentsDetail GetStudentDetail(int studentId);
    }
}
