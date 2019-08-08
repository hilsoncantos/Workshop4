using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class PackageDB
    {

        public static List<Package> GetPackages()
        {
            List<Package> packages = new List<Package>();   // empty list
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, " +
                    "PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                    "FROM Packages";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        Package pkg;
                        while (reader.Read())
                        {
                            pkg = new Package();
                            pkg.PackageId = (int)reader["PackageId"];
                            pkg.PkgName = reader["PkgName"].ToString();

                            // for any column that can be null need to determine if it is DBNull
                            // and set accordingly
                            int colSD = reader.GetOrdinal("PkgStartDate"); // column number of PkgStartDate
                            if (reader.IsDBNull(colSD)) // if reader contains DBNull in this column
                                pkg.PkgStartDate = null; // make it null in the object
                            else // it is not null
                                pkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);

                            int colED = reader.GetOrdinal("PkgEndDate"); // column number of PkgEndDate
                            if (reader.IsDBNull(colED)) // if reader contains DBNull in this column
                                pkg.PkgEndDate = null; // make it null in the object
                            else // it is not null
                                pkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);

                            pkg.PkgDesc = reader["PkgDesc"].ToString();
                            pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                            int colAC = reader.GetOrdinal("PkgAgencyCommission"); // column number of PkgAgencyCommission
                            if (reader.IsDBNull(colAC)) // if reader contains DBNull in this column
                                pkg.PkgAgencyCommission = null; // make it null in the object
                            else // it is not null
                                pkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];

                            packages.Add(pkg);
                        }
                    }
                }
            }
            return packages;
        }

        public static Package GetPackageById(int packageId)
        {
            Package selectedPkg = new Package();
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, " +
                    "PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                    "FROM Packages " +
                    "WHERE PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read())  // if package with given ID exists
                    {
                        selectedPkg = new Package();
                        selectedPkg.PackageId = (int)reader["PackageId"];
                        selectedPkg.PkgName = reader["PkgName"].ToString();

                        // for any column that can be null need to determine if it is DBNull
                        // and set accordingly
                        int colSD = reader.GetOrdinal("PkgStartDate"); // column number of PkgStartDate
                        if (reader.IsDBNull(colSD)) // if reader contains DBNull in this column
                            selectedPkg.PkgStartDate = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);

                        int colED = reader.GetOrdinal("PkgEndDate"); // column number of PkgEndDate
                        if (reader.IsDBNull(colED)) // if reader contains DBNull in this column
                            selectedPkg.PkgEndDate = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);

                        selectedPkg.PkgDesc = reader["PkgDesc"].ToString();
                        selectedPkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                        int colAC = reader.GetOrdinal("PkgAgencyCommission"); // column number of PkgAgencyCommission
                        if (reader.IsDBNull(colAC)) // if reader contains DBNull in this column
                            selectedPkg.PkgAgencyCommission = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                    }
                }
            }
            return selectedPkg;
        }

        // update order: current - before update, updated - new data
        public static bool UpdatePackage(Package current, Package updated)
        {
            bool success = false; // no success yet

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string updateStatement = "UPDATE Packages SET " +
                                            "PkgName = @NewPkgName, " +
                                            "PkgStartDate = @NewPkgStartDate, " +
                                            "PkgEndDate = @NewPkgEndDate, " +
                                            "PkgDesc = @NewPkgDesc, " +
                                            "PkgBasePrice = @NewPkgBasePrice, " +
                                            "PkgAgencyCommission = @NewPkgAgencyCommission " +
                                            "WHERE PackageId = @OldPackageId " +
                                            "  AND PkgName = @OldPkgName " +
                                            "  AND PkgStartDate = @OldPkgStartDate " +
                                            "  AND PkgEndDate = @OldPkgEndDate " +
                                            "  AND PkgDesc = @OldPkgDesc " +
                                            "  AND PkgBasePrice = @OldPkgBasePrice " +
                                            "  AND PkgAgencyCommission = @OldPkgAgencyCommission";

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    // provide values for parameters
                    cmd.Parameters.AddWithValue("@NewPkgName", updated.PkgName);
                    cmd.Parameters.AddWithValue("@NewPkgStartDate", updated.PkgStartDate);
                    cmd.Parameters.AddWithValue("@NewPkgEndDate", updated.PkgEndDate);
                    cmd.Parameters.AddWithValue("@NewPkgDesc", updated.PkgDesc);
                    cmd.Parameters.AddWithValue("@NewPkgBasePrice", updated.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", updated.PkgAgencyCommission);

                    cmd.Parameters.AddWithValue("@OldPackageId", current.PackageId);
                    cmd.Parameters.AddWithValue("@OldPkgName", current.PkgName);
                    cmd.Parameters.AddWithValue("@OldPkgStartDate", current.PkgStartDate);
                    cmd.Parameters.AddWithValue("@OldPkgEndDate", current.PkgEndDate);
                    cmd.Parameters.AddWithValue("@OldPkgDesc", current.PkgDesc);
                    cmd.Parameters.AddWithValue("@OldPkgBasePrice", current.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", current.PkgAgencyCommission);

                    // open connection
                    connection.Open();
                    // execute UPDATE command
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        success = true;
                } // command object recycled
            } // connection closed and recycled
            return success;
        }

    }
}
