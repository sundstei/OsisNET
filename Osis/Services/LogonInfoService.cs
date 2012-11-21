using System.Net;
using Osis.Models.ViewModels;

namespace Osis.Services
{
    public class LogonInfoService : ILogonInfoService
    {
        #region ILogonInfoService Members

        public LogonSummary GetLogonSummary()
        {
            var logonSummary = new LogonSummary();
            logonSummary.LastLoggedOnFromIP = "192.168.1.1";
            return logonSummary;
        }

        #endregion
    }
}