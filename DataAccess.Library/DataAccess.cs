using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    /// <summary>
    /// abstract class
    /// we cannot create and instance of an abstract class/interface
    /// </summary>
    public abstract class DataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "TestConnectionString";
        }

        // abstract methods
        public abstract void LoadData(string name);
        public abstract void SaveData(string name);
    }
}
