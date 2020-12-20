// Decompiled with JetBrains decompiler
// Type: Article75.CambiaPassword
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
  public class CambiaPassword : Page
  {
    protected TextBox txtVecchiaPassword;
    protected TextBox txtNuovaPassword;
    protected Button btnOK;
    protected Button btnAnnulla;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
      if ((string) this.Session["Utente"] != null)
      {
        if (this.txtVecchiaPassword.Text.Length <= 0)
        {
          this.Response.Write("<script>alert('Inserire la vecchia password!!');</script>");
          this.txtVecchiaPassword.Focus();
        }
        else if (this.txtNuovaPassword.Text.Length <= 0)
        {
          MessageBox.Show("Inserire la nuova password!!");
          this.txtNuovaPassword.Focus();
        }
        else if (new CUtente()
        {
          Email = this.Session["Utente"].ToString()
        }.CambiaPassword(this.txtVecchiaPassword.Text.Trim(), this.txtNuovaPassword.Text.Trim()))
        {
          MessageBox.Show("Cambio Password effettuato con successo!");
          this.Server.Transfer("Default.aspx");
        }
        else
        {
          MessageBox.Show("Attenzione.... Vecchia Password non corrispondente!!");
          this.txtVecchiaPassword.Focus();
        }
      }
      else
        MessageBox.Show("Sessione scaduta, si prega di riconnettersi!");
    }

    protected void btnAnnulla_Click(object sender, EventArgs e)
    {
      this.txtVecchiaPassword.Text = "";
      this.txtNuovaPassword.Text = "";
      this.Server.Transfer("Default.aspx");
    }
  }
}
