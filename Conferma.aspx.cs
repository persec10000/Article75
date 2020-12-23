// Decompiled with JetBrains decompiler
// Type: Article75.Conferma
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
  public class Conferma : System.Web.UI.Page
    {
    protected Label lblDefault;
    protected Label lblMessaggio;
    protected Label lblComune;
    protected Label lblConferma;
    protected TextBox txtComune;
    protected TextBox txtEmail;
    protected Button btnOK;
    protected Button btnAnnulla;
    protected Label lblIDReferendum;

    protected void Page_Load(object sender, EventArgs e)
    {
      string empty = string.Empty;
      if (this.Page.IsPostBack)
        return;
      this.lblDefault.Text = "Benvenuto su Articolo75.it! La tua Volontà, qui conta davvero!";
      this.lblComune.Text = "Per convalidare la tua scelta dovrai recarti al tuo comune di residenza per firmare.";
      this.lblConferma.Text = "Riceverai una email quando l'associazione Articolo 75.it avrà attivato il servizio.";
      this.lblMessaggio.Text = !(this.Application["SI"].ToString() == "SI") ? "Hai premuto NO per il referendum " + this.Application["Referendum"].ToString() : "Hai premuto SI per il referendum " + this.Application["Referendum"].ToString();
      this.txtComune.Text = "";
      this.txtEmail.Text = "";
      this.txtComune.Focus();
      this.lblIDReferendum.Text = this.Application["IDReferendum"].ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
      if (this.Session["Utente"] != null && this.Session["Utente"].ToString().Equals("Anonimo"))
      {
        MessageBox.Show("Controlla la posta elettronica, clicca sul link per continuare ad utilizzare questo sito.");
        this.txtComune.Text = "";
        this.txtEmail.Text = "";
      }
      else if (this.txtEmail.Text.Length == 0)
      {
        MessageBox.Show("Inserisci la tua email!");
        this.txtEmail.Focus();
      }
      else if (!new Regex("^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*").IsMatch(this.txtEmail.Text))
      {
        MessageBox.Show("not correct e-mail!");
        this.txtEmail.Focus();
      }
      else
      {
        string str1 = this.txtEmail.Text.Trim();
        if (this.txtComune.Text == "")
        {
          MessageBox.Show("Inserisci il Comune!!");
          this.txtComune.Focus();
        }
        else
        {
          UtilityDB utilityDb = new UtilityDB();
          string str2 = new CReferendum().DammiNomeReferendum(this.lblIDReferendum.Text.Trim());
          string email = str1;
          string comune = this.txtComune.Text.Trim();
          string text = this.lblIDReferendum.Text;
          string SiNo = this.Application["SI"].ToString();
          switch (utilityDb.WriteConfirmReferendum(email, comune, text, SiNo, "NO"))
          {
            case 0:
              //Thanks, you will receive a confirmation email shortly.
              MessageBox.Show("Grazie, riceverai a breve una email di conferma.");
              this.txtComune.Text = "";
              this.txtEmail.Text = "";
              this.Session["Utente"] = (object) "Anonimo";
              this.Session["UtenteEmail"] = (object) str1;
              this.Server.Transfer("Referendum.aspx");
              break;
            case 1:
              //Caution!! Data storage error, please try again thanks.
              MessageBox.Show("Attenzione!! Errore di memorizzazione dati, riprovare grazie.");
              this.txtComune.Text = "";
              this.txtEmail.Text = "";
              this.txtComune.Focus();
              break;
            case 2:
              //Thank you for voting for the referendum
              MessageBox.Show("Grazie per aver votato per il referendum " + str2);
              this.txtComune.Text = "";
              this.txtEmail.Text = "";
              this.Session["Utente"] = (object) str1;
              this.Session["UtenteEmail"] = (object) str1;
              this.Server.Transfer("Referendum.aspx");
              break;
            case 3:
              this.Session["UtenteEmail"] = (object) str1;
              if (str2.Length > 0)
                {
                    //You have already voted for the referendum
                    MessageBox.Show("Hai già votato per il referendum " + str2);
                }
                else
                {
                    MessageBox.Show("Hai già votato per questo referendum!!");//You have already voted for this referendum !!
                }
              this.Session["Utente"] = (object) str1;
              this.Server.Transfer("Referendum.aspx");
              break;
          }
        }
      }
    }

    protected void btnAnnulla_Click(object sender, EventArgs e)
    {
      this.Session.Clear();
      this.txtComune.Text = "";
      this.txtEmail.Text = "";
      this.Server.Transfer("Referendum.aspx");
    }
  }
}
