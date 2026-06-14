using System;
using Npgsql;
using WaterWise.Db;
using WaterWise.Models.Admin;

namespace WaterWise.Controller.Admin
{
    public class DashboardAdminController : IDashboardService
    {
        private readonly string _connString;

        public DashboardAdminController()
        {
            db database = new db();
            _connString = db.getConn().ConnectionString;
        }

      
        public DashboardMetric GetDashboardMetrics()
        {
            
            var metric = new DashboardMetric();

            try
            {
                using var conn = new NpgsqlConnection(_connString);
                conn.Open();

                string qTotal = @"
                    SELECT COUNT(*) 
                    FROM public.users";
                using (var cmd = new NpgsqlCommand(qTotal, conn))
                {
                    var result = cmd.ExecuteScalar();
                    metric.TotalPengguna = Convert.ToInt32(result ?? 0);
                }

            
                string qAktif = @"
                    SELECT COUNT(*) 
                    FROM public.Akun a
                    INNER JOIN public.users u ON a.id_akun = u.id_user
                    WHERE a.status = 'aktif'";
                using (var cmd = new NpgsqlCommand(qAktif, conn))
                {
                    var result = cmd.ExecuteScalar();
                    metric.PenggunaAktif = Convert.ToInt32(result ?? 0);
                }

              
                string qLimit = @"
                    SELECT COALESCE(AVG(batas_pemakaian), 0)
                    FROM public.users";
                using (var cmd = new NpgsqlCommand(qLimit, conn))
                {
                    var result = cmd.ExecuteScalar();
                    metric.LimitHarian = Convert.ToDouble(result ?? 0.0);
                }
            }
            catch (Exception ex)
            {
                // Jika DB error, metric tetap 0 — form tidak crash
                Console.WriteLine("Error GetDashboardMetrics: " + ex.Message);
            }

            return metric;
        }
    }
}