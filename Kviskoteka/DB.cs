using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Kviskoteka
{
    static class DB
    {
        static string connectionString = "Data Source=MyDatabase.sqlite;Version=3;";
        public static void Prepare()
        {
            using (SQLiteConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    //string prov = "drop table ABC";
                    //SQLiteCommand com = new SQLiteCommand(prov, connection);
                    //com.ExecuteNonQuery();

                    string createABCPitalica = @"create table if not exists ABC(
                                        Id integer primary key autoincrement,
                                        pitanje varchar(100) not null,
                                        tocan varchar(20) not null,
                                        drugi varchar(20) not null,
                                        treci varchar(20) not null)";
                    SQLiteCommand command = new SQLiteCommand(createABCPitalica, connection);
                    command.ExecuteNonQuery();

                    //prov = "drop table Asoc";
                    //com = new SQLiteCommand(prov, connection);
                    //com.ExecuteNonQuery();

                    string createAsocijacije = @"create table if not exists Asoc(
                                        Id integer primary key autoincrement,
                                        p11 varchar(20) not null, p12 varchar(20) not null, p13 varchar(20) not null, p14 varchar(20) not null, p1o varchar(20) not null,
                                        p21 varchar(20) not null, p22 varchar(20) not null, p23 varchar(20) not null, p24 varchar(20) not null, p2o varchar(20) not null,
                                        p31 varchar(20) not null, p32 varchar(20) not null, p33 varchar(20) not null, p34 varchar(20) not null, p3o varchar(20) not null,
                                        p41 varchar(20) not null, p42 varchar(20) not null, p43 varchar(20) not null, p44 varchar(20) not null, p4o varchar(20) not null,
                                        rjesenje varchar(20) not null)";
                    SQLiteCommand command1 = new SQLiteCommand(createAsocijacije, connection);
                    command1.ExecuteNonQuery();

                    //prov = "drop table Zavr";
                    //com = new SQLiteCommand(prov, connection);
                    //com.ExecuteNonQuery();

                    string createZavrsnaIgra = @"create table if not exists Zavr(
                                        Id integer primary key autoincrement,
                                        pitanje varchar(100) not null,
                                        odgovor varchar(30) not null)";
                    SQLiteCommand command2 = new SQLiteCommand(createZavrsnaIgra, connection);
                    command2.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //error log
                }

            }
        }
        
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            return connection;
        }
    }
}