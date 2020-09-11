using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace YulgangLogin
{
    public class Database
    {
        private static readonly string databaseFile = "database.db";
        public static string PasswordDatabase;

        public static string PathDatabaseFile()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\YulgangLogin";
            if( !Directory.Exists(path) )
            {
                Directory.CreateDirectory(path);
            }

            return path + @"\" + databaseFile;
        }

        public static void Create()
        {
            if( !File.Exists(PathDatabaseFile()) )
            {
                var conn = new SQLiteConnectionStringBuilder
                {
                    DataSource = PathDatabaseFile(),
                    Version = 3,
                };
                using( var con = new SQLiteConnection(conn.ConnectionString) )
                {
                    con.Open();

                    using( SQLiteCommand command = new SQLiteCommand("CREATE TABLE \"User\" (" +
                        "\"Id\" INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "\"Title\" TEXT NOT NULL," +
                        "\"Username\" TEXT NOT NULL," +
                        "\"Password\" TEXT NOT NULL" +
                        ");", con) )
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
        }
        public static int ExecuteWrite(string query, Dictionary<string, object> args)
        {
            int numberOfRowsAffected;

            //setup the connection to the database
            var conn = new SQLiteConnectionStringBuilder
            {
                DataSource = PathDatabaseFile(),
                Version = 3,
                Password = PasswordDatabase
            };
            using( var con = new SQLiteConnection(conn.ConnectionString) )
            {
                con.Open();

                //open a new command
                using( var cmd = new SQLiteCommand(query, con) )
                {
                    //set the arguments given in the query
                    foreach( var pair in args )
                    {
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                    }

                    //execute the query and get the number of row affected
                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }

                return numberOfRowsAffected;
            }
        }

        public static DataTable ExecuteRead(string query, Dictionary<string, object> args)
        {
            if( string.IsNullOrEmpty(query.Trim()) )
                return null;

            var conn = new SQLiteConnectionStringBuilder
            {
                DataSource = PathDatabaseFile(),
                Version = 3,
                Password = PasswordDatabase
            };
            using( var con = new SQLiteConnection(conn.ConnectionString) )
            {
                con.Open();
                using( var cmd = new SQLiteCommand(query, con) )
                {
                    foreach( KeyValuePair<string, object> entry in args )
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }

                    var da = new SQLiteDataAdapter(cmd);

                    var dt = new DataTable();
                    da.Fill(dt);

                    da.Dispose();
                    return dt;
                }
            }
        }

        public static bool Clean()
        {
            try
            {
                if( File.Exists(PathDatabaseFile()) )
                {
                    File.Delete(PathDatabaseFile());
                }

                return true;
            }
            catch( Exception e )
            {
                return false;
            }
        }

        public static void Import(string path)
        {
            Clean();
            File.Copy(path, PathDatabaseFile());
        }
        public static void Export(string path)
        {
            if( File.Exists(path) )
            {
                File.Delete(path);
            }
            File.Copy(PathDatabaseFile(), path);
        }
        public static bool SetPassword(string password, bool withPassword)
        {
            try
            {
                var conn = new SQLiteConnectionStringBuilder
                {
                    DataSource = PathDatabaseFile(),
                    Version = 3,
                };
                if( withPassword )
                {
                    conn.Add("Password", PasswordDatabase);
                }

                using( var con = new SQLiteConnection(conn.ConnectionString) )
                {
                    con.Open();
                    con.ChangePassword(password);

                    using( SQLiteCommand command = new SQLiteCommand("PRAGMA schema_version;", con) )
                    {
                        var ret = command.ExecuteScalar();
                    }
                    con.Close();

                    return true;
                }
            }
            catch( SQLiteException )
            {
                return false;
            }
        }
        public static bool CheckConnection(string password)
        {
            try
            {
                var conn = new SQLiteConnectionStringBuilder
                {
                    DataSource = PathDatabaseFile(),
                    Version = 3,
                    Password = password
                };
                using( var con = new SQLiteConnection(conn.ConnectionString) )
                {
                    con.Open();
                    Console.WriteLine(con);
                    using( SQLiteCommand command = new SQLiteCommand("PRAGMA schema_version;", con) )
                    {
                        var ret = command.ExecuteScalar();
                    }
                    con.Close();

                    return true;
                }
            }
            catch( SQLiteException e )
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool CheckConnectionDefault()
        {
            try
            {
                var conn = new SQLiteConnectionStringBuilder
                {
                    DataSource = PathDatabaseFile(),
                    Version = 3,
                };
                using( var con = new SQLiteConnection(conn.ConnectionString) )
                {
                    con.Open();

                    using( SQLiteCommand command = new SQLiteCommand("PRAGMA schema_version;", con) )
                    {
                        var ret = command.ExecuteScalar();
                    }
                    con.Close();

                    return true;
                }
            }
            catch( SQLiteException e )
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}