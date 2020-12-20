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

            this.mittente = "richworld3tai@gmail.com";
            this.server = "smtp.gmail.com";
        }

        public bool Invio()
        {
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
                SmtpClient client = new SmtpClient( "smtp.gmail.com", 587);//587
                //client.Port = 80;
                //client.EnableSsl = false;
                ///client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = true;
                System.Net.NetworkCredential basicCredential1 = new System.Net.NetworkCredential(mittente,                                     "t7u9z6msg999");
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
        }
    }
}