// Decompiled with JetBrains decompiler
// Type: Article75.ConfermaToken
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Article75
{
  public partial class ConfermaToken : System.Web.UI.Page
  {
    private string codice = "";
        protected Label lblUtente;


        private void Page_Load(object sender, EventArgs e)
    {
      if (this.Request.QueryString["codice"] == null)
        return;
      this.codice = this.Request.QueryString["codice"];
      UtilityDB utilityDb = new UtilityDB();
      if (!utilityDb.ValidateToken(this.codice))
        return;
      string email = utilityDb.CheckEmailToken(this.codice);
      CUtente cutente = new CUtente();
      utilityDb.SendPassword(email);
      this.Session["Utente"] = (object) email;
        this.Session["UtenteEmail"] = (object)email;
        //this.Session["ID"] = (object)cutente.IDUTE;
        //    this.Application["Logged"] = (object)"YES";

            this.lblUtente.Visible = true;
      this.lblUtente.Text = "Benvenuto Utente " + (string) this.Session["Utente"];
    this.Response.Write("<script LANGUAGE='JavaScript' >alert('Successfully registered! Please check your email in order to get your password.')</script>");
    this.Server.Transfer("Referendum.aspx");//this.Server.Transfer("Login.aspx"); // 2021.1.8 7AM

        }
    }
}
