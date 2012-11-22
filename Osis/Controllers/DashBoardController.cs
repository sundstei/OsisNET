using System.Web.Mvc;
using Osis.Models.ViewModels;
using Osis.Services;

namespace Osis.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly ILogonInfoService _logonInfoService;

        public DashBoardController(ILogonInfoService logonInfoService)
        {
            _logonInfoService = logonInfoService;
        }

        /// <summary>
        /// Dashboard for showing all the settings for a photographer.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = new DashboardDisplayViewModel();
            GetLogonInformation(model);

            return View(model);
        }

        private void GetLogonInformation(DashboardDisplayViewModel model)
        {
            var userName = this.User.Identity.Name;
            var logonSummary = _logonInfoService.GetLogonSummary(userName);



            AutoMapper.Mapper.Map(logonSummary, model); // Map LogonSummary to the ViewModel
        }
    }
}
