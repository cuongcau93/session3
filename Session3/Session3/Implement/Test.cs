using Session3.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3.Implement
{
    public class Test : IDatabase
    {
        public void SaveData()
        {
            Console.WriteLine("tesst");
        }

        public void SaveException(string exception)
        {
            Console.WriteLine("tesst");
        }
    }
}
