using AspNetCoreMvcWebApp.Business.Interfaces;
using AspNetCoreMvcWebApp.Models;

namespace AspNetCoreMvcWebApp.Business
{
    /// <summary>
    /// Business logic for the student.
    /// </summary>
    public class StudentBusiness: IStudentBusiness
    {
        /// <summary>
        /// Return some student information.
        /// </summary>
        /// <param name="studentId">Student ID used to search his/her information.</param>
        /// <returns>Student details.</returns>
        public StudentsDetail GetStudentDetail(int studentId)
        {
            var fakeDetail = new StudentsDetail();
            fakeDetail.Name = "Fake And Static name";
            fakeDetail.Courses = new List<string> { "FakeCourse1", "FakeCourse 2" };
            return fakeDetail;
        }

    }
}
