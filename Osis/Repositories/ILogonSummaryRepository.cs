using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Osis.Models.ViewModels;

namespace Osis.Repositories
{
    public interface ILogonSummaryRepository
    {
        LogonSummary GetByUserName(string username);
    }

    public class LogonSummaryRepository : BaseRepository, ILogonSummaryRepository
    {
        public LogonSummary GetByUserName(string username)
        {
            
            return new LogonSummary();
        }
    }
}