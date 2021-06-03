using System;
using System.Collections.Generic;
using System.Text;

namespace DAccess.Library
{
    public class SqlDataAccess : DataAccess
    {
        // override the implementation of LoadConnectionString here
        public override string LoadConnectionString(string name)
        {
            // getting output from base
            string output = base.LoadConnectionString(name);

            // adding this to the output
            output += "From SQL";

            return output;
        }

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
