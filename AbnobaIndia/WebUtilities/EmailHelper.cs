using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;

namespace AbnobaIndia.WebUtilities
{
    public class EmailHelper
    {
        public static int Port { get { return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["MailingPort"].ToString()); } }
        public static string Host { get { return System.Configuration.ConfigurationManager.AppSettings["MailingHost"].ToString(); } }
        public static string UserEmailName { get { return System.Configuration.ConfigurationManager.AppSettings["MailingEmail"].ToString(); } }
        public static string Password { get { return System.Configuration.ConfigurationManager.AppSettings["MailingPassword"].ToString(); } }


        public static bool SendMails(string toAddress, string ccAddress, string bodyText, string subject)
        {
            bool isMailSend = false;
            try
            {
                //smtp settings
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = EmailHelper.Host;
                    smtp.Port = EmailHelper.Port;

                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;

                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(EmailHelper.UserEmailName, EmailHelper.Password);
                    //smtp.Credentials = new NetworkCredential(EmailHelper.UserEmailName, "Yaantra123");
                    smtp.Timeout = 20000;

                    MailMessage msgMail = new MailMessage();

                    if (toAddress.Contains(","))
                    {
                        var toaddresses = toAddress.Split(new char[] { ',' });
                        if (toaddresses.Length > 0)
                            foreach (string val in toaddresses)
                                msgMail.To.Add(new MailAddress(val));
                    }
                    else
                        msgMail.To.Add(new MailAddress(toAddress));
                    /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018*/
                    if (!string.IsNullOrEmpty(ccAddress))
                    {
                        /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018 ends here*/
                        if (ccAddress.Contains(","))
                        {
                            var ccAddresses = ccAddress.Split(new char[] { ',' });
                            if (ccAddresses.Length > 0)
                                foreach (string val in ccAddresses)
                                    msgMail.CC.Add(new MailAddress(val));
                        }
                        else
                            msgMail.CC.Add(new MailAddress(ccAddress));
                        /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018*/
                    }
                    /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018 ends here*/

                    msgMail.From = (new MailAddress(EmailHelper.UserEmailName, "ABNOBA"));
                    msgMail.Body = bodyText;
                    msgMail.Subject = subject;
                    msgMail.IsBodyHtml = true;
                    //Passing values to smtp object
                    smtp.Send(msgMail);
                    // smtp.Send(fromAddress, toAddress, subject, bodyText);
                    isMailSend = true;
                }
            }
            catch (Exception ex)
            {
                isMailSend = false;
            }
            return isMailSend;
        }
        public static bool SendCareerMails(string toAddress, string ccAddress, string attachmentFilename, string bodyText, string subject)
        {
            bool isMailSend = false;
            try
            {
                //smtp settings
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = EmailHelper.Host;
                    smtp.Port = EmailHelper.Port;

                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;

                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(EmailHelper.UserEmailName, EmailHelper.Password);
                    //smtp.Credentials = new NetworkCredential(EmailHelper.UserEmailName, "Yaantra123");
                    smtp.Timeout = 20000;

                    MailMessage msgMail = new MailMessage();

                    if (toAddress.Contains(","))
                    {
                        var toaddresses = toAddress.Split(new char[] { ',' });
                        if (toaddresses.Length > 0)
                            foreach (string val in toaddresses)
                                msgMail.To.Add(new MailAddress(val));
                    }
                    else
                        msgMail.To.Add(new MailAddress(toAddress));
                    /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018*/
                    if (!string.IsNullOrEmpty(ccAddress))
                    {
                        /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018 ends here*/
                        if (ccAddress.Contains(","))
                        {
                            var ccAddresses = ccAddress.Split(new char[] { ',' });
                            if (ccAddresses.Length > 0)
                                foreach (string val in ccAddresses)
                                    msgMail.CC.Add(new MailAddress(val));
                        }
                        else
                            msgMail.CC.Add(new MailAddress(ccAddress));
                        /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018*/
                    }
                    /*code added for if condition checking only whether the cc addres is not empty or null, pawan roopwal, 05-April,2018 ends here*/

                    msgMail.From = (new MailAddress(EmailHelper.UserEmailName, "KPS, Vikaspuri"));
                    msgMail.Body = bodyText;
                    msgMail.Subject = subject;
                    msgMail.IsBodyHtml = true;
                    //msgMail.Attachments.Add(new Attachment((attachmentFilename.INPU.PostedFile.InputStream, attachmentFilename));

                    //if (attachmentFilename != null)
                    //msgMail.Attachments.Add(new Attachment(attachmentFilename));
                    //Passing values to smtp object
                    smtp.Send(msgMail);
                    // smtp.Send(fromAddress, toAddress, subject, bodyText);
                    isMailSend = true;
                }
            }
            catch (Exception ex)
            {
                isMailSend = false;
            }
            return isMailSend;
        }
        public static bool SendMails(string toAddress, string bccAddress, string ccAddress, string bodyText, string subject)
        {
            bool isMailSend = false;
            try
            {
                //smtp settings
                var smtp = new System.Net.Mail.SmtpClient();
                {

                    smtp.Host = EmailHelper.Host;
                    smtp.Port = EmailHelper.Port;

                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;

                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(EmailHelper.UserEmailName, EmailHelper.Password);
                    //smtp.Credentials = new NetworkCredential(EmailHelper.UserEmailName, "Yaantra123");
                    smtp.Timeout = 20000;


                    MailMessage msgMail = new MailMessage();

                    if (toAddress.Contains(","))
                    {
                        var toaddresses = toAddress.Split(new char[] { ',' });
                        if (toaddresses.Length > 0)
                            foreach (string val in toaddresses)
                                msgMail.To.Add(new MailAddress(val));
                    }
                    else
                        msgMail.To.Add(new MailAddress(toAddress));

                    if (ccAddress.Contains(","))
                    {
                        var ccAddresses = ccAddress.Split(new char[] { ',' });
                        if (ccAddresses.Length > 0)
                            foreach (string val in ccAddresses)
                                msgMail.CC.Add(new MailAddress(val));
                    }
                    else
                        msgMail.CC.Add(new MailAddress(ccAddress));

                    if (bccAddress.Contains(","))
                    {
                        var bccAddresses = bccAddress.Split(new char[] { ',' });
                        if (bccAddress.Length > 0)
                            foreach (string val in bccAddresses)
                                msgMail.Bcc.Add(new MailAddress(val));
                    }
                    else
                        msgMail.Bcc.Add(new MailAddress(bccAddress));


                    msgMail.From = (new MailAddress(EmailHelper.UserEmailName, ""));
                    msgMail.Body = bodyText;
                    msgMail.Subject = subject;
                    msgMail.IsBodyHtml = true;
                    //Passing values to smtp object
                    smtp.Send(msgMail);
                    // smtp.Send(fromAddress, toAddress, subject, bodyText);
                    isMailSend = true;
                }
            }
            catch (Exception ex)
            {
                isMailSend = false;
            }
            return isMailSend;
        }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string GetUniqueOTPNo()
        {
            //byte[] buffer = Guid.NewGuid().ToByteArray();
            //return BitConverter.ToUInt32(buffer, 8).ToString();
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 7; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }



        public static bool SendTestMail()
        {
            bool isMailSend = false;
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("no_reply@yaantra.com");
            message.To.Add(new MailAddress("dev.singh008@gmail.com"));
            message.CC.Add(new MailAddress("devendra.singh@yaantra.com"));
            message.Subject = "Test";
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = "Hi Dev, Do not reply this Mail";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("no_reply@yaantra.com", "Gadgetwood@11");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

            return isMailSend;
        }


    }
}
