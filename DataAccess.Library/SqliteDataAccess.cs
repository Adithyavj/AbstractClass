using System;
using System.Collections.Generic;
using System.Text;

namespace DAccess.Library
{
    public class SqliteDataAccess : DataAccess
    {
        public override void LoadData(string name)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string name)
        {
            Console.WriteLine("saving data to SQLite");
        }
    }
}
