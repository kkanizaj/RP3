using Kviskoteka.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviskoteka.Model.Extras
{
    class ABCPitalicaAccess
    {
        public static string AddABCPitalica(ABCPitalica abc)
        {
            using (SQLiteConnection connection = DB.GetConnection())
            {
                try
                {
                    connection.Open();
                    string insertABC = @"insert into ABC(pitanje, tocan, drugi, treci)
                                            values ('" + abc.Pitanje + "', '" + abc.Tocan + "', '" + abc.Drugi + "', '" + abc.Treci + "')";
                    SQLiteCommand command = new SQLiteCommand(insertABC, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return "Error: insert to table ABC";
                }
                return null;
            }
        }

        public static List<ABCPitalica> getAll()
        {

            List<ABCPitalica> pitanja = new List<ABCPitalica>();
            using (SQLiteConnection connection = DB.GetConnection())
            {
                
                connection.Open();
                string select = @"select * from ABC";
                SQLiteCommand command = new SQLiteCommand(select, connection);
                SQLiteDataReader row = command.ExecuteReader();

                while(row.Read()) 
                {
                    int id = Int32.Parse(row["Id"].ToString());
                    string pitanje = row["pitanje"].ToString();
                    string tocan = row["tocan"].ToString();
                    string drugi = row["drugi"].ToString();
                    string treci = row["treci"].ToString();
                    ABCPitalica nova = new ABCPitalica(id, pitanje, tocan, drugi, treci);
                    pitanja.Add(nova);
                }

                return pitanja;
            }

        }

        public static DataTable GetDataTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SQLiteConnection c = DB.GetConnection())
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            dt.Load(rdr);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
