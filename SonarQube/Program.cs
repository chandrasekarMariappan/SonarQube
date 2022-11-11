using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace SonarQube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World2!");
            Console.WriteLine("Hello World2132WEWE!");
            Console.WriteLine("Hello Chandrasekar");
            Console.WriteLine("Hello Kumari");
            Console.WriteLine("Suppfathaldasd");
            var connc = @"DATA SOURCE=localhost:1521/xe;SELF TUNING=True;USER ID=system;password=p#11@STC;";
            OracleConnection c = new OracleConnection(connc);

            c.Open();
            c.ClientInfo = "Sample Application";
            c.ModuleName = "Chandrasekar";
            c.ActionName = "Kafka";
            OracleCommand cmd = new OracleCommand("select *from perf where id=3", c);
            OracleDataAdapter adp = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
        }
    }
}
