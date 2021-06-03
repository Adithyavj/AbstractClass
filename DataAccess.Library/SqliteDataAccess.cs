using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    public class SqliteDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "TestConnectionString";
        }

        public void LoadData()
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public void SaveData()
        {
            Console.WriteLine("saving data to SQLite");
        }
    }
}
