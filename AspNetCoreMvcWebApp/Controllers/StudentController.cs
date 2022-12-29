using AspNetCoreMvcWebApp.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcWebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentBusiness _studentBusiness;

        /// <summary>
        /// Inject the dependencies.
        /// </summary>
        /// <param name="logger">Logger dependency.</param>
        /// <param name="studentBusiness">Business logic dependency.</param>
        public StudentController(ILogger<HomeController> logger, IStudentBusiness studentBusiness)
        {
            _logger = logger;
            _studentBusiness = studentBusiness;
        }

        /// <summary>
        /// Print the student detail for an specific student.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var detail = _studentBusiness.GetStudentDetail(0);
            return View(detail);
        }
    }
}
