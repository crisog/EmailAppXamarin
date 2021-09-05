using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp.Models
{
    public class Email
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public Email() {}

        public Email(string from, string to, string subject, string body, double unixTimestamp)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
            DateTime = $"{UnixTimeStampToDateTime(unixTimestamp).ToShortDateString()} {UnixTimeStampToDateTime(unixTimestamp).ToShortTimeString()}";
        }

        public string From { get; set; }
        public string FormattedFrom
        {
            get
            {
                return $"From: {From}";
            }
        }
        public string To { get; set; }
        public string FormattedTo
        {
            get
            {
                return $"To: {To}";
            }
        }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string DateTime { get; set; }

    }
}
