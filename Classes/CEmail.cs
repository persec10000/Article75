using MailKit.Security;
using MimeKit;
using MailKit.Net.Smtp;
using MimeKit.Text;
using System;
using System.Net.Mail;

namespace Article75
{
    public class CEmail
    {
        string mittente;
        string destinatario;
        string messaggio;
        string link;
        string msg;
        string oggetto;
        string server;
        string password; //!!sg
        public CEmail(string mittente, string destinatario, string messaggio,
                      string Link, string msg, string oggetto, string server, string password="")
        {
            this.mittente = mittente;
            this.destinatario = destinatario;
            this.messaggio = messaggio;
            this.link = Link;
            this.msg = msg;
            this.oggetto = oggetto;
            this.server = server;
            this.password = password;

            this.mittente = "notifiche@articolo75.it";
            this.server = "smtpa1.aruba.it";



        }

        public bool Invio()
        {
            try
            {
                // create email message
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("notifiche@articolo75.it"));
                email.To.Add(MailboxAddress.Parse(destinatario));
                email.Subject = oggetto;
                email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };
                if (password.Length > 0)
                {
                    msg += "Password : " + password;
                }

                if (link.Length > 0)
                    email.Body = new TextPart(TextFormat.Html) { Text = messaggio + "<a href=\"" + link + "\"" + ">Clicca qui</a>" + msg }; 
                else
                    email.Body = new TextPart(TextFormat.Html) { Text = messaggio }; 
                // send email
                var smtp = new MailKit.Net.Smtp.SmtpClient();
                smtp.Connect("smtps.aruba.it", 465, SecureSocketOptions.SslOnConnect); 
                smtp.Authenticate("notifiche@articolo75.it", "blD5s6YLFT++");
                smtp.Send(email);
                smtp.Disconnect(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email \n" + ex.ToString());
                return false;
            }
            return true;

            // -----------------
            /*
            try
            {
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress(mittente);
                mail.To.Add(new MailAddress(destinatario));
                mail.Subject = oggetto;

                if (password.Length > 0)
                {
                    msg += "Password : " + password;
                }

                if (link.Length > 0)
                    mail.Body = messaggio + "<a href=\"" + link + "\"" + ">Clicca qui</a>" + msg;
                else
                    mail.Body = messaggio;

                //SmtpClient client = new SmtpClient(server);
                //client.UseDefaultCredentials = true;
                //client.Send(mail);
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(this.server, 25);//587
                //client.Port = 80;
                //client.EnableSsl = false;
                ///client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = true;
                //System.Net.NetworkCredential basicCredential1 = new System.Net.NetworkCredential(mittente, "blD5s6YLFT++");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                
                client.Send(mail);
                return true;

            }
            catch (Exception ex)
            {
                // this is not working.
                MessageBox.Show("Error sending email \n"+ex.ToString());

                // this is working.
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Error sending email to richworld:')</SCRIPT>");

                // this is not working.
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Error sending email:" + ex.Message + ex.ToString() + "')</SCRIPT>");


                return false;
            }
            */
        }
    }
}