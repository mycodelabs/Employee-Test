using System.Web.Mvc;
using controllers.home.contracts;
using controllers.home.mappers.contracts;

namespace presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeTasks employeeTasks;
        private readonly IEmployeePageViewModelMapper employeePageViewModelMapper;

        public HomeController(IEmployeeTasks employeeTasks, IEmployeePageViewModelMapper employeePageViewModelMapper)
        {
            this.employeeTasks = employeeTasks;
            this.employeePageViewModelMapper = employeePageViewModelMapper;
        }
        public ActionResult Index()
        {
            var employees = this.employeeTasks.GetAll(); 
            return View(employeePageViewModelMapper.MapFrom(employees));
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
