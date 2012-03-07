using System.Collections.Generic;
using domain;

namespace controllers.home.viewmodels
{
    public class EmployeePageViewModel
    {
        public EmployeePageViewModel()
        {
            this.SummaryEmployeeViewModels = new List<SummaryEmployeeViewModel>();
        }

        public IList<SummaryEmployeeViewModel> SummaryEmployeeViewModels { get; set; }
    }

    public class SummaryEmployeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string JobTitle { get; set; }
    }
}