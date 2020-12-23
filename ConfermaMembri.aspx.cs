// Decompiled with JetBrains decompiler
// Type: Article75.ConfermaMembri
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
  public class ConfermaMembri : Page
  {
    private CUtente ute = new CUtente();
    protected Label lblDefault;
    protected TextBox txtNome;
    protected TextBox txtCognome;
    protected TextBox txtIndirizzo;
    protected TextBox txtCap;
    protected TextBox txtComune;
    protected TextBox txtEmail;
    protected TextBox txtTel;
    protected Button btnOK;
    protected Button btnAnnulla;
    protected Label lblIDReferendum;

    protected void Page_Load(object sender, EventArgs e)
    {
      string empty = string.Empty;
      if (this.Page.IsPostBack)
        return;

      //Welcome to Articolo75.it! Your Will really matters here!
      this.lblDefault.Text = "Benvenuto su Articolo75.it! La tua Volontà, qui conta davvero!";
      this.Azzera();
      if ((string) this.Application["Volontario"] == "SI")
      {
        this.txtCognome.Visible = false;
        this.txtIndirizzo.Visible = false;
        this.txtCap.Visible = false;
        this.txtTel.Visible = false;
      }
      this.txtNome.Focus();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
      if (this.Session["Utente"] == null && (string) this.Application["Logged"] == "YES")
      {//Session expired, please log in again
        MessageBox.Show("Sessione scaduta, si prega di rieffettuare il login");
        this.Server.Transfer("Home.aspx");
      }
      if (this.txtNome.Text == "")
      {// Enter your name!!
        MessageBox.Show("Inserisci il Nome!!");
        this.txtNome.Focus();
      }
      else
      {
        int tipo = 0;
        if ((string) this.Application["Responsabile"] == "SI")
        {
          tipo = 1;
          if (this.txtCognome.Text == "")
          {//Enter the Surname !!
            MessageBox.Show("Inserisci il Cognome!!");
            this.txtCognome.Focus();
            return;
          }
          if (this.txtIndirizzo.Text == "")
          {
            MessageBox.Show("Inserisci l'indirizzo!!");//Enter the address !
                        this.txtIndirizzo.Focus();
            return;
          }
          if (this.txtCap.Text == "")
          {
            MessageBox.Show("Inserisci il Cap!!");//Enter the postcode!
                        this.txtCap.Focus();
            return;
          }
        }
        if ((string) this.Application["Volontario"] == "SI")
          tipo = 2;
        if (this.txtEmail.Text.Length == 0)
        {
          MessageBox.Show("Inserisci la tua email!");//Insert your email!
                    this.txtEmail.Focus();
        }
        else if (!new Regex("^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*").IsMatch(this.txtEmail.Text))
        {
          MessageBox.Show("not correct e-mail!");
          this.txtEmail.Focus();
        }
        else
        {
          string email = this.txtEmail.Text.Trim();
          if (this.Session["ID"] == null || this.Session["ID"].Equals((object) "") || this.Session["Utente"] == null && (string) this.Application["Logged"] == "NO")
          {
            this.ute.DammiUtente(email, 0);
            this.Session["ID"] = (object) this.ute.IDUTE;
            if (this.ute.IDUTE.Equals(""))
            {
            //MessageBox.Show("Un-Registered Email");
            UtilityDB utilityDb = new UtilityDB();
            int ret = 
            utilityDb.WriteConfirmAssociation(email, this.txtComune.Text, this.txtNome.Text,this.txtCognome.Text, tipo);
            if(ret == 3)
                            {
                                MessageBox.Show("Please confirm your email.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to join member.");
                            }
              return;
            }
          }
          if (this.txtComune.Text == "")
          {
            MessageBox.Show("Inserisci il Comune!!");//Enter the Municipality !!
                        this.txtComune.Focus();
          }
          else if (!this.ute.ControlloComune(this.txtComune.Text.Trim()))
          {
            MessageBox.Show("Il Comune non è corretto!!");//The Municipality is not correct !!
            this.txtComune.Focus();
          }
          else
          {
            if (this.Session["TipoUtente"] != null && this.Session["TipoUtente"].ToString().Equals("Anonimo"))
            {
              bool flag = false;
              if ((string) this.Session["ID"] != "")
                flag = this.ute.CancellaReferendumUtenti(this.Session["ID"].ToString());
              if (!flag)
                {//System error! Try later.
                    MessageBox.Show("Errore del sistema! Riprova più tardi.");
                this.Server.Transfer("Home.aspx");
              }
            }
            this.AssignFields();
            int num = 0;
            if ((string) this.Session["ID"] != "")
              num = this.ute.ModificaUtente(this.Session["ID"].ToString(), tipo);
            if (num == 0 || num == 2)
            {
              MessageBox.Show("Errore del sistema! Riprova più tardi.");//System error! Try later.
                        }
            else
            {
              MessageBox.Show("Registrazione andata a buon fine");//Successful registration
                            this.Server.Transfer("Associazione.aspx");
            }
          }
        }
      }
    }

    protected void btnAnnulla_Click(object sender, EventArgs e)
    {
      this.Azzera();
      this.txtNome.Focus();
    }

    protected void Azzera()
    {
      this.txtNome.Text = "";
      this.txtCognome.Text = "";
      this.txtIndirizzo.Text = "";
      this.txtCap.Text = "";
      this.txtComune.Text = "";
      this.txtEmail.Text = "";
      this.txtTel.Text = "";
    }

    protected void AssignFields()
    {
      this.ute.Nome = this.txtNome.Text;
      this.ute.Comune = this.txtComune.Text;
      this.ute.Email = this.txtEmail.Text;
      if (!((string) this.Application["Responsabile"] == "SI"))
        return;
      this.ute.Cognome = this.txtCognome.Text;
      this.ute.Indirizzo = this.txtIndirizzo.Text;
      this.ute.Cap = this.txtCap.Text;
      if (this.txtTel.Text.Trim().Length > 0)
        this.ute.Tel = this.txtTel.Text;
      else
        this.ute.Tel = "0";
    }
  }
}
