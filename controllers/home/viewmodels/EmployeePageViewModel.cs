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
}