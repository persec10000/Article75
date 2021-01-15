using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
    public class ReferendaDetail : System.Web.UI.Page
    {
        private UtilityDB Utility = new UtilityDB();
        private CUtente ute = new CUtente();
        protected Button BtnYes1;
        protected Button BtnNo1;
        protected Label lblTitle;
        protected Label lblTitleVideo;
        protected Label lblId;

        protected string strTitle;
        protected string strId;

        public static string strShareUrlFacebook;
        public static string strShareUrlTelegram;
        public static string strShareUrlMail;
        public static string strShareUrlGmail;
        public static string strShareUrlYahooMail;
        public static string strShareUrlOutlookMail;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.strTitle = this.Request.QueryString["title"];
            this.strId = this.Request.QueryString["id"];
            this.Application["Referendum"] = (object)this.strTitle;
            this.Application["IDReferendum"] = (object)this.strId;
            this.Application["Description"] = (object)("Votiamo per "+this.strTitle);
            this.lblTitle.Text = this.strTitle;
            this.lblTitleVideo.Text = this.strTitle;
            this.lblId.Text = this.strId;

            string strShareUrl = this.strTitle;
            strShareUrl = HttpUtility.UrlEncodeUnicode(strShareUrl);

            strShareUrlFacebook =
                "http://www.facebook.com/share.php?u="+ HttpUtility.UrlEncodeUnicode("http://185.117.152.92:8081/ReferendaDetail.aspx?id=") +
                this.strId + "&title=" +
                strShareUrl;
            strShareUrlTelegram =
                "https://telegram.me/share/url?url=http://185.117.152.92:8081/ReferendaDetail.aspx?id=" +
                this.strId +
                HttpUtility.UrlEncodeUnicode("&title=") + HttpUtility.UrlEncodeUnicode(HttpUtility.UrlEncodeUnicode(this.strTitle)) +
                "&text=" + this.Application["Description"].ToString();
            strShareUrlMail =
                "mailto:?subject = "+ 
                this.Application["Description"].ToString()+
                " & amp; body = Check out this website http://185.117.152.92:8081/";
            strShareUrlGmail = "https://mail.google.com/mail/?view=cm&su=" +
                this.Application["Description"].ToString() +
                "&to&body=" +
                /*
                HttpUtility.UrlEncodeUnicode("<a href=\"")+
                */
                HttpUtility.UrlEncodeUnicode("http://185.117.152.92:8081/ReferendaDetail.aspx?id=") +
                this.strId + HttpUtility.UrlEncodeUnicode("&title=") + HttpUtility.UrlEncodeUnicode(HttpUtility.UrlEncodeUnicode(this.strTitle)) +
                /*
                HttpUtility.UrlEncodeUnicode("\">Clicca qui</a>") +
                "<br>.I have already voted. "+*/
                "&scc=1<mpl=default<mplcache=2&emr=1&osid=1#identifier";
            strShareUrlYahooMail = "http://compose.mail.yahoo.com/?&Subject="+
                this.Application["Description"].ToString() +
                "&To=&Body=" +
                HttpUtility.UrlEncodeUnicode("http://185.117.152.92:8081/ReferendaDetail.aspx?id=") +
                this.strId + HttpUtility.UrlEncodeUnicode("&title=") + HttpUtility.UrlEncodeUnicode(HttpUtility.UrlEncodeUnicode(this.strTitle)) ;
            strShareUrlOutlookMail = "https://mail.live.com/default.aspx?rru=compose&subject=" +
                this.Application["Description"].ToString() +
                "&to=&body=" +
                HttpUtility.UrlEncodeUnicode("http://185.117.152.92:8081/ReferendaDetail.aspx?id=") +
                this.strId + HttpUtility.UrlEncodeUnicode("&title=") + HttpUtility.UrlEncodeUnicode(HttpUtility.UrlEncodeUnicode(this.strTitle)) +
                "&lc=1033&id=64855&mkt=en-us&cbcxt=mai";
        }
        protected void BtnNo1_Click(object sender, EventArgs e)
        {
            this.Application["SI"] = (object)"NO";
            this.Application["Referendum"] = (object)this.strTitle;
            this.Application["IDReferendum"] = (object)this.strId;
            if (this.Session["Utente"] != null)
            {
                this.CheckUser();
            }
            else
                this.Server.Transfer("Conferma.aspx");//Login
        }

        protected void BtnYes1_Click(object sender, EventArgs e)
        {
            this.Application["SI"] = (object)"SI";
            this.Application["Referendum"] = (object)this.strTitle;
            this.Application["IDReferendum"] = (object)this.strId;
            if (this.Session["Utente"] != null)
            {
                this.CheckUser();
            }
            else
                this.Server.Transfer("Conferma.aspx");//Login
        }

        private void CheckUser()
        {
            if (this.Session["Utente"].ToString().Equals("Anonimo"))
            {
                // "Check your email, click on the link to continue using this site."
                MessageBox.Show("Controlla la posta elettronica, clicca sul link per continuare ad utilizzare questo sito.");
            }
            else
            {
                this.ute.DammiUtente(this.Session["Utente"].ToString(), 0);
                if (this.ute.TipoUtente == "Membro")
                {
                    //"You are a member of the association and you cannot release sensitive data, such as your political opinions, on our databases. You will be notified of all our referendums."
                    MessageBox.Show("Sei membro dell'associazione e non puoi rilasciare dati sensibili, quali le tue opinioni politiche, sui nostri database. Riceverai notifica di tutti i nostri referendum.");
                }
                else
                {
                    this.Utility.IDUTE = this.ute.IDUTE;
                    string str = new CReferendum().DammiNomeReferendum(this.Application["IDReferendum"].ToString());
                    switch (this.Utility.WriteConfirmReferendum(this.Session["Utente"].ToString(), this.Utility.Comune, this.Application["IDReferendum"].ToString(), this.Application["SI"].ToString(), "SI"))
                    {
                        case 0:
                            //"Thanks, you will receive a confirmation email shortly."
                            MessageBox.Show("Grazie, riceverai a breve una email di conferma.");
                            this.Server.Transfer("Referendum.aspx");
                            break;
                        case 1:
                            //"Caution!! Data storage error, please try again thanks."
                            MessageBox.Show("Attenzione!! Errore di memorizzazione dati, riprovare grazie.");
                            break;
                        case 2:
                            //"Thank you for voting for the referendum"
                            MessageBox.Show("Grazie per aver votato per il referendum " + str);
                            this.Server.Transfer("Referendum.aspx");
                            break;
                        case 3:
                            if (str.Length > 0)
                            {
                                MessageBox.Show("Hai già votato per il referendum " + str);//You have already voted for the referendum
                            }
                            else
                            {
                                MessageBox.Show("Hai già votato per questo referendum!!");//You have already voted for this referendum !!
                            }
                            this.Server.Transfer("Referendum.aspx");
                            break;
                    }
                }
            }
        }

    }
}
