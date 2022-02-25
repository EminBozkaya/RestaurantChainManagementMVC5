using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Core.Utilities.Common
{
    public static class MailHelper
    {
        public static void SendMail(string title, string body, string to)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            SmtpClient smtp = new SmtpClient(appSettings["MailSmtp"], Convert.ToInt32(appSettings["MailPort"]));

            MailMessage message = new MailMessage();


            message.From = new MailAddress(appSettings["MailFrom"], appSettings["MailDisplayName"]);
            message.To.Add(to);
            message.Subject = title;
            message.Body = body;
            message.IsBodyHtml = true;


            smtp.Credentials = new NetworkCredential(appSettings["MailUserName"], appSettings["MailPassword"]);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(message);
            }
            catch (SmtpException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SendMail(string title, string body, string to, List<string> cc, List<Attachment> attachmentList)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            SmtpClient smtp = new SmtpClient(appSettings["SmtpHost"], Convert.ToInt32(appSettings["SmtpPort"]));
            MailMessage message = new MailMessage();


            message.From = new MailAddress(appSettings["From"], appSettings["DisplayName"]);
            message.To.Add(to);
            foreach (var item in cc)
                message.CC.Add(item);

            foreach (var item in attachmentList)
                message.Attachments.Add(item);

            message.Subject = title;
            message.Body = body;
            message.IsBodyHtml = true;

            smtp.Credentials = new NetworkCredential(appSettings["UserName"], appSettings["Password"]);
            smtp.EnableSsl = true;
            smtp.Send(message);
        }

        public static void SendMail(string title, string body, List<string> to, string cc, List<Attachment> attachmentList)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            SmtpClient smtp = new SmtpClient(appSettings["SmtpHost"], Convert.ToInt32(appSettings["SmtpPort"]));
            MailMessage message = new MailMessage();

            message.From = new MailAddress(appSettings["From"], appSettings["DisplayName"]);
            message.CC.Add(cc);
            foreach (var item in to)
                message.To.Add(item);

            foreach (var item in attachmentList)
                message.Attachments.Add(item);

            message.Subject = title;
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Credentials = new NetworkCredential(appSettings["UserName"], appSettings["Password"]);
            smtp.EnableSsl = true;
            smtp.Send(message);
        }

        public static void SendMail(string title, string body, List<string> to)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            SmtpClient smtp = new SmtpClient(appSettings["SmtpHost"], Convert.ToInt32(appSettings["SmtpPort"]));
            MailMessage message = new MailMessage();

            message.From = new MailAddress(appSettings["From"], appSettings["DisplayName"]);
            foreach (var item in to)
                message.To.Add(item);

            message.Subject = title;
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Credentials = new NetworkCredential(appSettings["UserName"], appSettings["Password"]);
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
