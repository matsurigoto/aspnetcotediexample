using DIExample.Interfaces;
using DIExample.Models;
using DIExample.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        private ITestQueries _testQueries;
        private FinanceWebAPIConfig _financeWebAPIConfig;
        private WebSiteInfo _webSiteInfo;

        public HomeController(ITestQueries testQueries, IOptions<FinanceWebAPIConfig> financeWebAPIConfig, IOptions<WebSiteInfo> webSiteInfo)
        {
            _testQueries = testQueries;
            _financeWebAPIConfig = financeWebAPIConfig.Value;
            _webSiteInfo = webSiteInfo.Value;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();

            vm.financeWebAPIConfig = _financeWebAPIConfig;
            vm.webSiteInfo = _webSiteInfo;

            vm.employeeName = _testQueries.GetName("0060");
            vm.employeeList = _testQueries.GetNames("RD01");
           
            return View(vm);
        }
    }
}
