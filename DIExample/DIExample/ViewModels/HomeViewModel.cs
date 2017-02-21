using DIExample.Models;
using System.Collections.Generic;

namespace DIExample.ViewModels
{
    public class HomeViewModel
    {
        public string employeeName { get; set; }

        public List<string> employeeList { get; set; }

        public FinanceWebAPIConfig financeWebAPIConfig { get; set; }

        public WebSiteInfo webSiteInfo { get; set; }
    }
}
