using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    public class SqlDataAccess : DataAccess
    {
        public override void LoadData(string name)
        {
            Console.WriteLine("Loading SQL Data");
        }

        public override void SaveData(string name)
        {
            Console.WriteLine("saving data to SQL");
        }
    }
}
