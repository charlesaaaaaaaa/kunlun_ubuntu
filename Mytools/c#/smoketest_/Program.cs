using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace smoketest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connSting = "Host=192.168.0.126;Port=5001;Username=abc;Password=abc;Database=postgres";
            var conn = new NpgsqlConnection(connSting);
            NpgsqlDataAdapter DA = new NpgsqlDataAdapter();

	    string drop1 = "drop table if exists SmokeTestTable_csharp;";
            string create = "create table SmokeTestTable_csharp(id int primary key,name text,gender text);";
            string insert = "insert into SmokeTestTable_csharp values(1,'li','male'),(2,'delete_me','male'),(3,'update_me','female');";
	    string delete = "delete from Smoketesttable_csharp where id = 2";
            string update = "update SmokeTestTable_csharp set name = 'update' where id = 3";
            string select1 = "select * from SmokeTestTable_csharp";

	    conn.Open();
	    using (var com1 = new NpgsqlCommand(drop1,conn))
            using (var com2 = new NpgsqlCommand(create, conn))
	    using (var com3 = new NpgsqlCommand(insert, conn))
	    using (var com4 = new NpgsqlCommand(delete, conn))
	    using (var com5 = new NpgsqlCommand(update, conn))
	    using (var com6 = new NpgsqlCommand(select1, conn))

	    {

                com1.ExecuteNonQuery();
                Console.WriteLine("step 1 : drop   table successful!");

		com2.ExecuteNonQuery();
                Console.WriteLine("step 2 : create table successful!");

		com3.ExecuteNonQuery();
                Console.WriteLine("step 3 : insert table successful!");

		com4.ExecuteNonQuery();
                Console.WriteLine("step 4 : update table successful!");

		com5.ExecuteNonQuery();
                Console.WriteLine("step 5 : update table successful!");

		com6.ExecuteNonQuery();
                Console.WriteLine("step 6 : update table successful!");
	    }
        }
    }
}
