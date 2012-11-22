using Osis.Models.ViewModels;

namespace Osis.Services
{
    public interface ILogonInfoService
    {
        LogonSummary GetLogonSummary(string userName);
    }
}