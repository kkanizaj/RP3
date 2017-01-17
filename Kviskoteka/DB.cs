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
                    string createABCPitalica = @"create table if not exists ABCPitalica(
                                        id integer primary key autoincrement,
                                        pitanje varchar(100) not null,
                                        tocan varchar(20) not null,
                                        drugi varchar(20) not null,
                                        treci varchar(20) not null)";
                    SQLiteCommand command = new SQLiteCommand(createABCPitalica, connection);
                    command.ExecuteNonQuery();
                    string createAsocijacije = @"create table if not exists Asocijacije(
                                        id integer primary key autoincrement,
                                        p11 varchar(10) not null, p12 varchar(10) not null, p13 varchar(10) not null, p14 varchar(10) not null, p1o varchar(10) not null,
                                        p21 varchar(10) not null, p22 varchar(10) not null, p23 varchar(10) not null, p24 varchar(10) not null, p2o varchar(10) not null,
                                        p31 varchar(10) not null, p32 varchar(10) not null, p33 varchar(10) not null, p34 varchar(10) not null, p3o varchar(10) not null,
                                        p41 varchar(10) not null, p42 varchar(10) not null, p43 varchar(10) not null, p44 varchar(10) not null, p4o varchar(10) not null,
                                        rjesenje varchar(50) not null)";
                    SQLiteCommand command1 = new SQLiteCommand(createAsocijacije, connection);
                    command1.ExecuteNonQuery();
                    string createZavrsnaIgra = @"create table if not exists ZavrsnaIgra(
                                        id integer primary key autoincrement,
                                        pitanje varchar(100) not null,
                                        odgovor varchar(20) not null)";
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
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }
    }
}