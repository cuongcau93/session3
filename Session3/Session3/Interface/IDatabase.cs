using System;
using System.Collections.Generic;
using System.Text;

namespace Session3.Interface
{
    public interface IDatabase
    {
        void SaveData();

        void SaveException(string exception);
    }
}
