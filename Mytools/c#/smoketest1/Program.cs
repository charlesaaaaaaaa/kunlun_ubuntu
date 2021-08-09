using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SmokeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n========== C# Driver ============");
            string connSting = "Host=192.168.0.113;Port=5001;Username=benchmarksql_test;Password=benchmarksql_test;Database=benchmarksql_test";
            var conn = new NpgsqlConnection(connSting);
            
            NpgsqlDataAdapter DA = new NpgsqlDataAdapter();
            //NpgsqlCommand cmd_select = new NpgsqlCommand("select * from SmokeTestTable_csharp");
            //DA.SelectCommand = cmd_select;
            
            
            
	    for(int i =1;i<=1000;i++){
            string drop1 = "SELECT w_street_1, w_street_2, w_city, w_state, w_zip, w_name FROM benchmarksql.warehouse WHERE w_id = 1;";
            string create = "SELECT c_discount, c_last, c_credit, w_tax  FROM benchmarksql.customer, benchmarksql.warehouse WHERE w_id = 1 AND w_id = c_w_id AND c_d_id = 1 AND c_id = 109;";

            conn.Open();
            
            using (var com1 = new NpgsqlCommand(drop1, conn)) 
            using (var com2 = new NpgsqlCommand(create, conn)) 

            {
                
                //drobd1.ExecuteNonQuery();
                //Console.WriteLine("drop table success!");
                //credb1.ExecuteNonQuery();
                //Console.WriteLine("create database success!");
                //comm.ExecuteNonQuery();
                //Console.WriteLine("commit success!");
                //swdb1.ExecuteNonQuery();
                //Console.WriteLine("switch database success!");

                com1.ExecuteNonQuery();
                Console.WriteLine("drop   table success!");
                com2.ExecuteNonQuery();
                Console.WriteLine("create table success!");
            }
            conn.Close();
            Console.WriteLine("=================================\n");
        }
	}
    }
}
