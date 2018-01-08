using System;
using System.Collections.Generic;

namespace SQLExample.Classes
{
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
        }

        public static bool Insert<T>(ref T data, string db_path) // Insert data into the db_path (database) path
        {
            using (var conn = new SQLite.SQLiteConnection(db_path)) // Use this sqlite connection to insert our data into the db_path
            {
                conn.CreateTable<T>(); // Create a table with the data we have obtained

                if (conn.Insert(data) != 0) // Check the data to see if it does not return empty/zero 
                    return true; // Return true if there is actually data to be used
            }


            return false; // Otherwise, return false
        }

        public static List<Book> Read(string db_path)
        {
            
        }

    }
}
