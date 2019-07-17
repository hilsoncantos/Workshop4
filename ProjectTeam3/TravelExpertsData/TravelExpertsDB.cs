using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection() // this method will be called in the other *DB classes (when connection needs to be made)
        {
            string connectionString = @"Data Source=localhost\SAIT; Initial Catalog = TravelExperts; Integrated Security = True";  // @ allows you to put the entire path 

            return new SqlConnection(connectionString);
        }
    }
}
