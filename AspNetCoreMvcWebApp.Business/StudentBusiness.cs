using AspNetCoreMvcWebApp.Business.Interfaces;
using AspNetCoreMvcWebApp.DataAccess.Interfaces;
using AspNetCoreMvcWebApp.Models;

namespace AspNetCoreMvcWebApp.Business
{
    /// <summary>
    /// Business logic for the student.
    /// </summary>
    public class StudentBusiness: IStudentBusiness
    {
        private IStudentData _data;

        /// <summary>
        /// Inject the DataAccess object.
        /// </summary>
        /// <param name="data"></param>
        public StudentBusiness(IStudentData data)
        {
            _data = data;
        }

        /// <summary>
        /// Return some student information.
        /// </summary>
        /// <param name="studentId">Student ID used to search his/her information.</param>
        /// <returns>Student details.</returns>
        public StudentsDetail GetStudentDetail(int studentId)
        {
            var student = _data.GetStudent(studentId);
            var studentDetail = new StudentsDetail();
            studentDetail.Name = student.Name;
            studentDetail.Courses = student.Enrollments.Select(enrollment => enrollment.Course.Name);
            return studentDetail;
        }

    }
}
