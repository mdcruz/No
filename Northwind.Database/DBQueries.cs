using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Northwind.Database
{
    public static class DBQueries
    {
        static readonly string connectionString = @"server=(localdb)\MSSqlLocalDB;database=Northwind";
 
        public static void DeleteEmployeeRecord(string name) 
        {
            ExecuteCommand(@"DELETE FROM dbo.Employee
                            WHERE FirstName = '" + name + "'");
        }

        public static void DeleteDepartmentRecord(string name)
        {
            ExecuteCommand(@"DELETE FROM dbo.Department
                            WHERE Name = '" + name + "'");
        }

        public static void DeleteProjectRecord(string name) 
        {
            ExecuteCommand(@"DELETE FROM dbo.Project
                            WHERE Name = '" + name + "'");
        }

        private static DataSet GetDataSet(string sqlCommand)
        {
            DataSet ds = new DataSet();

            using (SqlCommand cmd = new SqlCommand(sqlCommand, new SqlConnection(connectionString)))
            {
                try 
                {
                    cmd.Connection.Open();
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());
                    ds.Tables.Add(table);
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.ToString());
                }

                cmd.Connection.Close();
            }

            return ds;
        }

        private static void ExecuteCommand(string sqlCommand)
        {
            using (SqlCommand cmd = new SqlCommand(sqlCommand, new SqlConnection(connectionString))) 
            {
                try 
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.ToString());
                }

                cmd.Connection.Close();
            }
        }
    }
}
