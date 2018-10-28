using Session3.Implement;
using Session3.Interface;
using System;
using System.Text.RegularExpressions;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voi moi interface, ta define mot Module tuong ung
            DIContainer.SetModule<IDatabase, Database>();
            DIContainer.SetModule<ILoggerTextFile, LoggerTextFile>();
            DIContainer.SetModule<IEmailSender, EmailSender>();
            DIContainer.SetModule<IMockCondition, MockCondition>();


            DIContainer.SetModule<Account, Account>();

            //DI Container se tu inject Database, LoggerTextFile, EmailSender, MockCondition vao Account
            var account = DIContainer.GetModule<Account>();
            account.Login("Cuongnm22@wru.vn", "123");

            Console.ReadKey();
        }
    }

}
