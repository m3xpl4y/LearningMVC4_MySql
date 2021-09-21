﻿using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LearningMVC4_MySql.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(){}

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SmtpClient sc = new SmtpClient();
            sc.Host = "localhost";
            sc.Port = 25;

            MailMessage message = new MailMessage();

            message.From = new MailAddress("admin@anothertest.app");
            message.Subject = subject;
            message.To.Add(new MailAddress(email));
            message.Body = "<html><body> " + htmlMessage + " </body></html>";
            message.IsBodyHtml = true;

            sc.Send(message);
        }
    }
}