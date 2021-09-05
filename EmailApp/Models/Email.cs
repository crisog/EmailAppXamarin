using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp.Models
{
    public class Email
    {
        public Email(string from, string to, string subject, string body, string timestamp)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
            Timestamp = timestamp;
        }

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Timestamp { get; set; }

    }
}
