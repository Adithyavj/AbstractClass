using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    public class SqlDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "TestConnectionString";
        }

        public void LoadData()
        {
            Console.WriteLine("Loading SQL Data");
        }

        public void SaveData()
        {
            Console.WriteLine("saving data to SQL");
        }
    }
}
