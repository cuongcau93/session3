using Session3.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3.Implement
{
    public class LoggerTextFile : ILoggerTextFile
    {
        public void LogInfo(string exception)
        {
            Console.WriteLine("Write Real Exception to TexFile");
        }
    }
}
