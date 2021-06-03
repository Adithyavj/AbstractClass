using DAccess.Library;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UsingInterface
            //List<IDataAccess> databases = new List<IDataAccess>()
            //{
            //    new SqlDataAccess(),
            //    new SqliteDataAccess()
            //};

            //foreach (var db in databases)
            //{
            //    db.LoadConnectionString("demo");
            //    db.LoadData("select * from table");
            //    db.SaveData("insert into table");
            //    Console.WriteLine();
            //}
            #endregion

            // using abstract class
            #region UsingAbstractClass
            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine();
            }
            #endregion

            Console.ReadLine();
        }
    }
}
