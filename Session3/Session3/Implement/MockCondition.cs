using Session3.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3.Implement
{
    public class MockCondition : IMockCondition
    {
        public string GetSetting()
        {

            string handleException = "emailSender"; //Get executed product code

            if (handleException.StartsWith("database"))
                return "Database";
            else if (handleException.StartsWith("emailSender"))
                return "EmailSender";
            else if (handleException.StartsWith("loggerTextFile"))
                return "LoggerTextFile";

            return string.Empty;

        }
    }
}
