using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*
 string connectionString = @"Server=DESKTOP-LHV5FJ2\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true";
*/



namespace Proje06_MVCWithSql.Dal
{
    public static class Db
    {
        private static SqlConnection connection = CreateConnection();
        private static SqlConnection CreateConnection()
        {
            string connectionString = @"Server=DESKTOP-LHV5FJ2\SQLEXPRESS;Database=Northwind;user=sa;password:1234;TrustServerCertificate=true";
            return new SqlConnection(connectionString);
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

                Console.WriteLine("hata");
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
                Console.WriteLine("Bağlantı kapatıldı..");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}