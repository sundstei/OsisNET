using System.Net;
using Osis.Models.ViewModels;
using Osis.Repositories;

namespace Osis.Services
{
    public class LogonInfoService : ILogonInfoService
    {


        #region ILogonInfoService Members

        public LogonSummary GetLogonSummary(string userName)
        {

            var logonSummary = new LogonSummary {LastLoggedOnFromIP = "192.168.1.1"};
            return logonSummary;
        }

        #endregion
    }
}