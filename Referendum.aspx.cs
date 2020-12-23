// Decompiled with JetBrains decompiler
// Type: Article75.Referendum
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
  public class Referendum : System.Web.UI.Page
  {
    private UtilityDB Utility = new UtilityDB();
    private CUtente ute = new CUtente();
    protected Label lblTitolo1;
    protected Label lblDescrizione1;
    protected Label lblID1;
    protected Button BtnSi1;
    protected Button BtnNo1;
    protected Label lblTitolo2;
    protected Label lblDescrizione2;
    protected Label lblID2;
    protected Button BtnSi2;
    protected Button BtnNo2;
    protected Label lblTitolo3;
    protected Label lblDescrizione3;
    protected Label lblID3;
    protected Button BtnSi3;
    protected Button BtnNo3;

    protected void Page_Load(object sender, EventArgs e)
    {
      new CReferendum().ReadReferendum(this.lblID1, this.lblTitolo1, this.lblDescrizione1, this.lblID2, this.lblTitolo2, this.lblDescrizione2, this.lblID3, this.lblTitolo3, this.lblDescrizione3);
      if (this.Session["UtenteEmail"] != null && !this.Session["UtenteEmail"].Equals((object) ""))
      {
        this.Application["ReferendumSiNo_" + this.lblID1.Text] = (object) CReferendum.GetReferendumByEmailAndId((string) this.Session["UtenteEmail"], this.lblID1.Text);
        this.Application["ReferendumSiNo_" + this.lblID2.Text] = (object) CReferendum.GetReferendumByEmailAndId((string) this.Session["UtenteEmail"], this.lblID2.Text);
        this.Application["ReferendumSiNo_" + this.lblID3.Text] = (object) CReferendum.GetReferendumByEmailAndId((string) this.Session["UtenteEmail"], this.lblID3.Text);
      }
      else
      {
        this.Application["ReferendumSiNo_" + this.lblID1.Text] = (object) "";
        this.Application["ReferendumSiNo_" + this.lblID2.Text] = (object) "";
        this.Application["ReferendumSiNo_" + this.lblID3.Text] = (object) "";
      }
      //MessageBox.Show("Referendum Page loaded!");
      this.Application["retpage"]= "Referendum.aspx";
    }

    protected void BtnSi1_Click(object sender, EventArgs e)
    {
      this.Application["SI"] = (object) "SI";
      this.Application["Referendum"] = (object) this.lblTitolo1.Text;
      this.Application["IDReferendum"] = (object) this.lblID1.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");//Login
    }

    protected void btnConteggia_Click(object sender, EventArgs e)
    {
        new CReferendum().ConteggiaReferendum();
    }

    protected void btnMappa_Click(object sender, EventArgs e)
    {
        this.Server.Transfer("Mappa.aspx");
    }

    protected void BtnNo1_Click(object sender, EventArgs e)
    {
      this.Application["SI"] = (object) "NO";
      this.Application["Referendum"] = (object) this.lblTitolo1.Text;
      this.Application["IDReferendum"] = (object) this.lblID1.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");//Login
    }

    protected void BtnSi2_Click(object sender, EventArgs e)
    {
      this.Application["SI"] = (object) "SI";
      this.Application["Referendum"] = (object) this.lblTitolo2.Text;
      this.Application["IDReferendum"] = (object) this.lblID2.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");//Login
    }

    protected void BtnNo2_Click(object sender, EventArgs e)
    {
      this.Application["SI"] = (object) "NO";
      this.Application["Referendum"] = (object) this.lblTitolo2.Text;
      this.Application["IDReferendum"] = (object) this.lblID2.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");//Login
    }

    protected void BtnSi3_Click(object sender, EventArgs e)
    {
      this.Application["SI"] = (object) "SI";
      this.Application["Referendum"] = (object) this.lblTitolo3.Text;
      this.Application["IDReferendum"] = (object) this.lblID3.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");//Login
    }

    protected void BtnNo3_Click(object sender, EventArgs e)
    {
      this.Application["SI"] = (object) "NO";
      this.Application["Referendum"] = (object) this.lblTitolo3.Text;
      this.Application["IDReferendum"] = (object) this.lblID3.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");//Login
    }

    protected void Detail_Click(object sender, EventArgs e)
    {
        this.Server.Transfer("Petitionz/referendum-detail.html");
        this.Server.Transfer("ReferendumDetail.aspx");
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
