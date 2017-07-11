using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace schedulingtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            //Console.WriteLine(date);

            using (StreamWriter write = new StreamWriter(" ", append: true))
            {
                write.WriteLine(date);
            }

            using (StreamReader email = new StreamReader(" "))
            {
                var message = email.ReadToEnd() + "Console App!  It logs the current time to a file, then reads the file to the end, AND...sends an email.   By the way, it you got this, I just logged into Windows to work on code :) ";
                //Console.WriteLine(message);

                var mail = new MailMessage();
                mail.Body = message.ToString();
                mail.From = new MailAddress(" ");
                mail.To.Add(new MailAddress(" "));
                mail.CC.Add(new MailAddress(" "));
                mail.Bcc.Add(new MailAddress(" "));
                mail.Subject = "Hello";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(" ", "");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }

        }



    }
}




    

