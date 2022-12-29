using AspNetCoreMvcWebApp.DataAccess.Interfaces;
using AspNetCoreMvcWebApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMvcWebApp.DataAccess
{
    /// <summary>
    /// Directo connection with DB to get the information.
    /// </summary>
    public class StudentData: IStudentData
    {
        private SchoolContext _context;

        /// <summary>
        /// Inject the db context.
        /// </summary>
        /// <param name="context">Initialized database context.</param>
        public StudentData(SchoolContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Return an specific student by an ID.
        /// </summary>
        /// <param name="id">Student ID.</param>
        /// <returns>Found student.</returns>
        public Student GetStudent(int id)
        {
            return _context
                     .Students
                     .Include("Enrollments.Course")
                     .AsQueryable()
                     .First(student => student.Id == id);
        }
    }
}
