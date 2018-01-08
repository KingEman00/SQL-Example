using System;
using SQLite;

namespace SQLExample.Classes
{
    public class Book
    {
        public Book()
        {
        }

        [PrimaryKey, AutoIncrement] // Everytime we add something new the primary key will increase by 1
        public int ID { get; set; } // Set ID as public string
        public string Name { get; set; } // Set name as public string
        public string Author { get; set; } // Set author as public string

    }
}
