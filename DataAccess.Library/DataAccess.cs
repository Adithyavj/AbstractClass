using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    /// <summary>
    /// base class
    /// </summary>
    public class DataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "TestConnectionString";
        }
    }
}
