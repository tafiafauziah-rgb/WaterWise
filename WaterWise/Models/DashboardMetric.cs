using System;
using System.Collections.Generic;
using System.Text;

namespace WaterWise.Models
{

    // 1. ABSTRACTION: Base class berupa kelas abstrak
    public abstract class DashboardMetric
    {
        // 2. ENCAPSULATION: Menyembunyikan field internal menggunakan properti otomatis
        public string MetricName { get; protected set; }

        public DashboardMetric(string name)
        {
            MetricName = name;
        }

        // Polimorfisme: Setiap anak wajib memberikan implementasi nilai numeriknya sendiri
        public abstract int GetValue();

        // 3. POLYMORPHISM & INHERITANCE: Format standar cetak nilai
        public virtual string GetFormattedDisplay()
        {
            return GetValue().ToString();
        }
    }

    // 4. INHERITANCE (Turunan dari DashboardMetric)
    public class UserMetric : DashboardMetric
    {
        private bool _isActiveOnly;

        public UserMetric(string name, bool isActiveOnly) : base(name)
        {
            _isActiveOnly = isActiveOnly;
        }

        // Implementasi Polimorfisme untuk mengambil data user
        public override int GetValue()
        {
            return _isActiveOnly ? 42 : 150; // Simulasi data Pengguna Aktif : Total Pengguna
        }
    }

    // Turunan kedua untuk Limit Harian
    public class WaterLimitMetric : DashboardMetric
    {
        public WaterLimitMetric(string name) : base(name) { }

        public override int GetValue()
        {
            return 2000; // Simulasi limit harian dalam Liter
        }

        // Override perilaku dasar untuk memformat output dengan satuan liter (Polymorphism)
        public override string GetFormattedDisplay()
        {
            return $"{GetValue()} L";
        }
    }
}
