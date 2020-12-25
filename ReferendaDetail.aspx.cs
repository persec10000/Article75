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
        protected void Page_Load(object sender, EventArgs e)
        {
            this.strTitle = this.Request.QueryString["title"];
            this.strId = this.Request.QueryString["id"];
            this.Application["Referendum"] = (object)this.strTitle;
            this.Application["IDReferendum"] = (object)this.strId;
            this.lblTitle.Text = this.strTitle;
            this.lblTitleVideo.Text = this.strTitle;
            this.lblId.Text = this.strId;
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
