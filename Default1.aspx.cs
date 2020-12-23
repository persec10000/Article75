// Decompiled with JetBrains decompiler
// Type: Article75.Default1
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
  public partial class Default1 : System.Web.UI.Page
  {
    private UtilityDB Utility = new UtilityDB();
    private CUtente ute = new CUtente();
    protected Label lblUtente;
    protected HyperLink HLnkPass;
    protected Button btnOut;
    protected Label lblID1;
    protected Label lblDescrizione1;
    protected Label lblTitolo1;
    protected ImageButton BtnSi1;
    protected ImageButton BtnNo1;
    protected Label lblTitolo2;
    protected Label lblDescrizione2;
    protected Label lblID2;
    protected ImageButton BtnSi2;
    protected ImageButton BtnNo2;
    protected Label lblTitolo3;
    protected Label lblDescrizione3;
    protected Label lblID3;
    protected ImageButton BtnSi3;
    protected ImageButton BtnNo3;

    protected void Page_Load(object sender, EventArgs e)
    {
      CReferendum creferendum = new CReferendum();
      if ((string) this.Session["Utente"] != null && this.Application["Logged"] != null)
      {
        this.lblUtente.Visible = true;
        this.lblUtente.Text = "Benvenuto Utente " + (string) this.Session["Utente"];
        if ((string) this.Session["Utente"] != null)
        {
          this.HLnkPass.Visible = true;
          this.btnOut.Visible = true;
        }
      }
      Label lblId1 = this.lblID1;
      Label lblTitolo1 = this.lblTitolo1;
      Label lblDescrizione1 = this.lblDescrizione1;
      Label lblId2 = this.lblID2;
      Label lblTitolo2 = this.lblTitolo2;
      Label lblDescrizione2 = this.lblDescrizione2;
      Label lblId3 = this.lblID3;
      Label lblTitolo3 = this.lblTitolo3;
      Label lblDescrizione3 = this.lblDescrizione3;
      creferendum.ReadReferendum(lblId1, lblTitolo1, lblDescrizione1, lblId2, lblTitolo2, lblDescrizione2, lblId3, lblTitolo3, lblDescrizione3);
    }

    protected void btnOut_Click(object sender, EventArgs e)
    {
      this.Application["Logged"] = (object) "NO";
      this.Session["Utente"] = (object) null;
      this.Server.Transfer("Home.aspx");
    }

    protected void BtnSi1_Click(object sender, ImageClickEventArgs e)
    {
      this.Application["SI"] = (object) "SI";
      this.Application["Referendum"] = (object) this.lblTitolo1.Text;
      this.Application["IDReferendum"] = (object) this.lblID1.Text;
      if (this.Session["Utente"] != null)
        CheckUser();
      else
        Server.Transfer("Conferma.aspx");
    }

        protected void btnConteggia_Click(object sender, EventArgs e)
        {
            CReferendum Ref = new CReferendum();
            Ref.ConteggiaReferendum();
        }

        protected void btnMappa_Click(object sender, EventArgs e)
        {
            Server.Transfer("Mappa.aspx");
        }

    protected void BtnNo1_Click(object sender, ImageClickEventArgs e)
    {
      this.Application["SI"] = (object) "NO";
      this.Application["Referendum"] = (object) this.lblTitolo1.Text;
      this.Application["IDReferendum"] = (object) this.lblID1.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");
    }

    protected void BtnSi2_Click(object sender, ImageClickEventArgs e)
    {
      this.Application["SI"] = (object) "SI";
      this.Application["Referendum"] = (object) this.lblTitolo2.Text;
      this.Application["IDReferendum"] = (object) this.lblID2.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");
    }

    protected void BtnNo2_Click(object sender, ImageClickEventArgs e)
    {
      this.Application["SI"] = (object) "NO";
      this.Application["Referendum"] = (object) this.lblTitolo2.Text;
      this.Application["IDReferendum"] = (object) this.lblID2.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");
    }

    protected void BtnSi3_Click(object sender, ImageClickEventArgs e)
    {
      this.Application["SI"] = (object) "SI";
      this.Application["Referendum"] = (object) this.lblTitolo3.Text;
      this.Application["IDReferendum"] = (object) this.lblID3.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");
    }

    protected void BtnNo3_Click(object sender, ImageClickEventArgs e)
    {
      this.Application["SI"] = (object) "NO";
      this.Application["Referendum"] = (object) this.lblTitolo3.Text;
      this.Application["IDReferendum"] = (object) this.lblID3.Text;
      if (this.Session["Utente"] != null)
        this.CheckUser();
      else
        this.Server.Transfer("Conferma.aspx");
    }

    private void CheckUser()
    {
      if (this.Session["Utente"].ToString().Equals("Anonimo"))
      {
        MessageBox.Show("Controlla la posta elettronica, clicca sul link per continuare ad utilizzare questo sito.");
      }
      else
      {
        this.ute.DammiUtente(this.Session["Utente"].ToString(), 0);
        if (this.ute.TipoUtente == "Membro")
        {
          MessageBox.Show("Sei membro dell'associazione e non puoi rilasciare dati sensibili, quali le tue opinioni politiche, sui nostri database. Riceverai notifica di tutti i nostri referendum.");
        }
        else
        {
          this.Utility.IDUTE = this.ute.IDUTE;
          string str = new CReferendum().DammiNomeReferendum(this.Application["IDReferendum"].ToString());
          switch (this.Utility.WriteConfirmReferendum(this.Session["Utente"].ToString(), this.Utility.Comune, this.Application["IDReferendum"].ToString(), this.Application["SI"].ToString(), "SI"))
          {
            case 0:
              MessageBox.Show("Grazie, riceverai a breve una email di conferma.");
              this.Server.Transfer("Home.aspx");
              break;
            case 1:
              MessageBox.Show("Attenzione!! Errore di memorizzazione dati, riprovare grazie.");
              break;
            case 2:
              MessageBox.Show("Grazie per aver votato per il referendum " + str);
              this.Server.Transfer("Home.aspx");
              break;
            case 3:
              if (str.Length > 0)
                MessageBox.Show("Hai già votato per il referendum " + str);
              else
                MessageBox.Show("Hai già votato per questo referendum!!");
              this.Server.Transfer("Home.aspx");
              break;
          }
        }
      }
    }
  }
}
