using System;

namespace Osis.Models.ViewModels
{

    /// <summary>
    /// Display class for information to the dashboard.
    /// </summary>
    public class DashboardDisplayViewModel
    {
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string LocalTime { get; set; }
        public DateTime PreviousLoginTime { get; set; }
        public string LastUserLoggedOn { get; set; }
        public string LastLoggedOnFromIP { get; set; }
        public DateTime LastLoggedOn { get; set; }
        public double CurrentBalance { get; set; }
        public double CurrentBalanceDue { get; set; }
        public int UpcomingJobs { get; set; }
    }
}