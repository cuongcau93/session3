using Session3.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3.Implement
{
    public class Database : IDatabase
    {
        public void SaveData()
        {
            Console.WriteLine("Save data to database");
        }

        public void SaveException(string exception)
        {
            Console.WriteLine("Saved exception to real database");
        }
    }
}
