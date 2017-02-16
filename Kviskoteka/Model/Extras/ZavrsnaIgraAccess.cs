using Kviskoteka.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviskoteka.Model.Extras
{
    class ZavrsnaIgraAccess
    {
        public static string AddZavrsnaIgra(ZavrsnaIgra zavr)
        {
            using (SQLiteConnection connection = DB.GetConnection())
            {
                try
                {
                    connection.Open();
                    string insertZavr = @"insert into Zavr(Pitanje, Odgovor)
                                            values ('" + zavr.Pitanje +"', '" + zavr.Odgovor + "')";
                    SQLiteCommand command = new SQLiteCommand(insertZavr, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return "Error: insert to table Zavr";
                }
                return null;
            }
        }

        public static List<ZavrsnaIgra> getAll()
        {

            List<ZavrsnaIgra> pitanja = new List<ZavrsnaIgra>();
            using (SQLiteConnection connection = DB.GetConnection())
            {

                connection.Open();

                string select = @"select * from Zavr";
                SQLiteCommand command = new SQLiteCommand(select, connection);
                SQLiteDataReader row = command.ExecuteReader();

                while (row.Read())
                {
                    int id = Int32.Parse(row["Id"].ToString());
                    string pitanje = row["Pitanje"].ToString();
                    string odgovor = row["Odgovor"].ToString();
                    ZavrsnaIgra nova = new ZavrsnaIgra(id, pitanje, odgovor);
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
