using System;
using System.Collections.Generic;
using System.Text;

namespace DAccess.Library
{
    public interface IDataAccess
    {
        string LoadConnectionString(string name);
        void LoadData(string sql);
        void SaveData(string sql);

    }
}
