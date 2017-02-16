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
    class AsocijacijeAccess
    {
        public static string AddAsocijacija(Asocijacije asoc)
        {
            using (SQLiteConnection connection = DB.GetConnection())
            {
                try
                {
                    connection.Open();
                    string insertAsoc = @"insert into Asoc(P11, P12, P13, P14, P1o, P21, P22, P23, P24, P2o, P31, P32, P33, P34, P3o, P41, P42, P43, P44, P4o, Rjesenje)
                                            values ('" + asoc.P11 + "', '" + asoc.P12 + "', '" + asoc.P13 + "', '" + asoc.P14 + "', '" + asoc.P1o + "', '" + asoc.P21 + "', '" + asoc.P22 + "', '" + asoc.P23 + "', '" + asoc.P24 + "', '" + asoc.P2o + "', '" + asoc.P31 + "', '" + asoc.P32 + "', '" + asoc.P33 + "', '" + asoc.P34 + "', '" + asoc.P3o + "', '" + asoc.P41 + "', '" + asoc.P42 + "', '" + asoc.P43 + "', '" + asoc.P44 + "', '" + asoc.P4o + "', '" + asoc.Rjesenje +  "')";
                    SQLiteCommand command = new SQLiteCommand(insertAsoc, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return "Error: insert to table Asoc";
                }
                return null;
            }
        }

        public static List<Asocijacije> getAll()
        {

            List<Asocijacije> pitanja = new List<Asocijacije>();
            using (SQLiteConnection connection = DB.GetConnection())
            {

                connection.Open();
                string select = @"select * from Asoc";
                SQLiteCommand command = new SQLiteCommand(select, connection);
                SQLiteDataReader row = command.ExecuteReader();

                while(row.Read())
                {
                    int id = Int32.Parse(row["Id"].ToString());
                    string p11 = row["P11"].ToString();
                    string p12 = row["P12"].ToString();
                    string p13 = row["P13"].ToString();
                    string p14 = row["P14"].ToString();
                    string p1o = row["P1o"].ToString();
                    string p21 = row["P21"].ToString();
                    string p22 = row["P22"].ToString();
                    string p23 = row["P23"].ToString();
                    string p24 = row["P24"].ToString();
                    string p2o = row["P2o"].ToString();
                    string p31 = row["P31"].ToString();
                    string p32 = row["P32"].ToString();
                    string p33 = row["P33"].ToString();
                    string p34 = row["P34"].ToString();
                    string p3o = row["P3o"].ToString();
                    string p41 = row["P41"].ToString();
                    string p42 = row["P42"].ToString();
                    string p43 = row["P43"].ToString();
                    string p44 = row["P44"].ToString();
                    string p4o = row["P4o"].ToString();
                    string rjesenje = row["Rjesenje"].ToString();
                    Asocijacije nova = new Asocijacije(id, p11, p12, p13, p14, p1o, p21, p22, p23, p24, p2o, p31, p32, p33, p34, p3o, p41, p42, p43, p44, p4o, rjesenje);
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
