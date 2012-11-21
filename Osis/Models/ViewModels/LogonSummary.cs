using System;
using System.Net;

namespace Osis.Models.ViewModels
{
    public class LogonSummary
    {
        public string LastUserLoggedOn { get; set; }
        public string LastLoggedOnFromIP { get; set; }
        public DateTime LastLoggedOn { get; set; }
    }
}