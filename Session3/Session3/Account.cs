using Session3.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Session3
{
    
    public class Account
    {
        private readonly IDatabase _db;
        private readonly ILoggerTextFile _loggerTextFile;
        private readonly IEmailSender _emailSender;
        private readonly IMockCondition _mockCondition;

        private string emailAddress = string.Empty;
        private string password = string.Empty;
        private string ip = string.Empty;
        private int port = -1;

        public Account(IDatabase db, ILoggerTextFile loggerTextFile, IEmailSender emailSender, IMockCondition mockCondition)
        {

            _db = db;
            _loggerTextFile = loggerTextFile;
            _emailSender = emailSender;
            _mockCondition = mockCondition;

        }

        public void Login(string userName, string password)
        {

            if(validateUserName(userName) && validatePassword(password))
            {
                _db.SaveData();
            }
            else
            {
                HandleException();
            }
            
        }

        private bool validateUserName(string userName)
        {
            userName = userName.ToLower();
            bool isUserName = Regex.IsMatch(userName, @"^([a-z0-9_\.\-\+]+)@([\da-z\.\-]+)\.([a-z\.]{2,6})$", RegexOptions.IgnoreCase);
            return isUserName;
        }

        private bool validatePassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{6,}");

            var isValidatedPassword = hasNumber.IsMatch(password) 
                                      && (hasLowerChar.IsMatch(password) || hasUpperChar.IsMatch(password)) 
                                      && hasMinimum8Chars.IsMatch(password);
            return isValidatedPassword;
        }

        private void HandleException()
        {

            string handleException = _mockCondition.GetSetting();

            if (handleException.ToLower() == "database")
            {
                _db.SaveException("exception");
            }
            else if (handleException.ToLower() == "emailsender")
            {
                _emailSender.SendEmail("Exception");
            }
            else if (handleException.ToLower() == "loggertextfile")
            {
                _loggerTextFile.LogInfo("Exception");
            }
        
        }

    }
}
