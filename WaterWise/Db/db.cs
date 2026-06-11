using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace WaterWise.Db
{
    public class db
    { 
        public static NpgsqlConnection getConn()
        {

            string connString = "Host=localhost;Username=postgres;Password=Tafiahikmah03;Database=WaterWise";
            return new NpgsqlConnection(connString);
        }
    }
}
