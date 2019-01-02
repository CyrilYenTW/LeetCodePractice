using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Unique_Email_Addresses
    {
        public Unique_Email_Addresses()
        {
            var emails = new string[]{ "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"};

            NumUniqueEmailsV3(emails);
        }

        public int NumUniqueEmailsV2(string[] emails)
        {
            var dicEmail = new Dictionary<string, int>();

            foreach (var email in emails)
            {
                var IsGetAtSignal = false;
                var IsGetPlusSignal = false;
                var tempEmail = string.Empty;

                foreach(var c in email)
                {
                    if (IsGetAtSignal == true)
                    {
                        tempEmail += c;
                        continue;
                    }

                    if (c == '@')
                    {
                        IsGetAtSignal = true;
                        tempEmail += c;
                        continue;
                    }

                    if (c == '+')
                    {
                        IsGetPlusSignal = true;
                        continue;
                    }

                    if (IsGetPlusSignal && IsGetAtSignal == false)
                    {
                        continue;
                    }

                    if (c == '.')
                    {
                        continue;
                    }

                    tempEmail += c;
                }

                if (dicEmail.ContainsKey(tempEmail) == false)
                {
                    dicEmail.Add(tempEmail, 0);
                }
            }

            return dicEmail.Count;
        }

        public int NumUniqueEmailsV1(string[] emails)
        {
            var emailList = new List<string>();

            foreach (var email in emails)
            {
                var plusIndex = email.IndexOf("+");
                var atIndex = email.IndexOf("@");
                var domainString = email.Substring(atIndex);
                var account = email.Substring(0, plusIndex == -1 ? atIndex : plusIndex).Replace(".", "");
                var tempEmail = account + domainString;

                if (emailList.Contains(tempEmail) == false)
                {
                    emailList.Add(tempEmail);
                }
            }

            return emailList.Count;
        }

        public int NumUniqueEmailsV3(string[] emails)
        {
            var emailList = new HashSet<string>();

            foreach (var email in emails)
            {
                var emailItems = email.Split('@');
                var account = emailItems[0].Substring(0, emailItems[0].IndexOf('+')).Replace(".", "");

                emailList.Add(account + "@" + emailItems[1]);
            }

            return emailList.Count;
        }
    }
}
