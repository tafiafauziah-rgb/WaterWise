namespace WaterWise.Models.Admin
{

    public class DashboardMetric
    {
        private int _totalPengguna;
        private int _penggunaAktif;
        private double _limitHarian;

        public int TotalPengguna
        {
            get => _totalPengguna;
            set => _totalPengguna = value >= 0 ? value : 0;
        }

        public int PenggunaAktif
        {
            get => _penggunaAktif;
            set => _penggunaAktif = value >= 0 ? value : 0;
        }

        public double LimitHarian
        {
            get => _limitHarian;
            set => _limitHarian = value >= 0 ? value : 0;
        }

        // ✅ ENCAPSULATION: method untuk format tampilan
        public string FormatLimitHarian()
        {
            return _limitHarian >= 1000
                ? $"{_limitHarian / 1000:F1} m³"
                : $"{_limitHarian:F0} liter";
        }
    }
}