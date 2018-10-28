using Session3.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3.Implement
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string exception)
        {
            Console.WriteLine("Send real Exception to email");
        }
    }
}
