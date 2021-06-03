using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    public class SqlDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "TestConnectionString";
        }

        public void LoadData(string name)
        {
            Console.WriteLine("Loading SQL Data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine("saving data to SQL");
        }
    }
}
