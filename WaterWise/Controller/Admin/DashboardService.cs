using WaterWise.Models.Admin;


namespace WaterWise.Controller.Admin
{
 
    public interface IDashboardService
    {
        DashboardMetric GetDashboardMetrics();
    }
}