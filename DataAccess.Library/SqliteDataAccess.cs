using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    public class SqliteDataAccess : DataAccess
    {
        public void LoadData(string name)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine("saving data to SQLite");
        }
    }
}
