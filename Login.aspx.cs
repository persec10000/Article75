// Decompiled with JetBrains decompiler
// Type: Article75.Login
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
  public class Login : Page
  {
    protected TextBox txtUtente;
    protected TextBox txtPassword;
    protected Button btnAccedi;

    protected void Page_Load(object sender, EventArgs e)
    {
      if ((string) this.Session["Utente"] != null && this.Application["Logged"] != null)
      {
        //Attention you are already recognized by the system.
        this.Response.Write("<script LANGUAGE='JavaScript' >alert('Attenzione sei già riconosciuto dal sistema')</script>");
        this.Server.Transfer("Home.aspx");
      }
      this.Session.Clear();
      if (this.Page.IsPostBack)
        return;
      //this.txtUtente.Text = "1234";
      //this.txtPassword.Text = "1234";
      this.txtUtente.Focus();
    }

    protected void btnAccedi_Click(object sender, EventArgs e)
    {
      try
      {
        CUtente cutente = new CUtente();
        cutente.login(this.txtUtente.Text.Trim(), this.txtPassword.Text.Trim());
        if (cutente.Email.Length > 0)
        {

            //alert('Geocode was not successful for the following reason: ');
            System.Diagnostics.Debug.WriteLine("Send email....!!!!!!!! " );
            //console.log('Geocode was not successful for the following reason: ');
            //UtilityDB utilityDb = new UtilityDB();
            //utilityDb.SendEmailConfirm("richworld3tai@gmail.com", "fL92P34IhAWQHDJ");
            //utilityDb.SendEmailConfirm("persec10000@gmail.com", "fL92P34IhAWQHDJ","asdfasdf");



          this.Session["Utente"] = (object) cutente.Email;
          this.Session["UtenteEmail"] = (object) cutente.Email;
          this.Session["ID"] = (object)cutente.IDUTE;
          this.Application["Logged"] = (object) "YES";
        this.Response.Write("<script LANGUAGE='JavaScript' >alert('Login success!')</script>");
        if (this.Application["retpage"]==null)
                    {
                        this.Application["retpage"] = "Home.aspx";
                    }
        this.Server.Transfer( this.Application["retpage"].ToString() ); // this.Server.Transfer("Referendum.aspx");
        }
        else
        {// "I don't recognize the user ..... try again"
            MessageBox.Show("Non riconosco l'utente..... riprova !");
          //this.txtUtente.Text = "1234";
          //this.txtPassword.Text = "1234";
        }
      }
      catch (Exception ex)
      {
      }
    }

    protected void btnAnnulla_Click(object sender, EventArgs e)
    {
      this.Session.Clear();
      this.txtUtente.Text = "";
      this.txtPassword.Text = "";
      this.txtUtente.Focus();
    }
  }
}
