using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
/*
    string connectionString = @"Server=DESKTOP-LHV5FJ2\SQLEXPRESS;Database=Northwind;user=enginniyazi;password=432Er5&;TrustServerCertificate=true";
*/
namespace Proje06_MvcWithSql.Dal
{
    public static class Db
    {
        public static SqlConnection connection = CreateConnection();
        private static SqlConnection CreateConnection()
        {
            string connectionString = @"Server=DESKTOP-LHV5FJ2\SQLEXPRESS;Database=Northwind;user=sa; password=1234;TrustServerCertificate=true";
            return new SqlConnection(connectionString);
            //kendii sql servere ımı bağladım .
        }
        public static void OpenCn()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                Console.WriteLine("Bağlantı başarıyla kuruldu...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void CloseCn()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                Console.WriteLine("Bağlantı kapatıldı...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

//adonet teknolojisi:veri tabanına bağlanmaıza neden olur.nugget package manager ile 