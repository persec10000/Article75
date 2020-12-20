// Decompiled with JetBrains decompiler
// Type: Article75.Layout
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Article75
{
  public class Layout : MasterPage
  {
    protected ContentPlaceHolder Header_Layout;
    protected ContentPlaceHolder CSS_Link;
    protected HtmlLink cbx_style;
    protected HtmlForm form1;
    protected Label lblUtente;
    protected Button LogOutBtn;
    protected Button LogInBtn;
    protected ContentPlaceHolder RenderBody;
    protected ContentPlaceHolder Footer_Layout;
    protected ContentPlaceHolder JS_Link;

    protected void Page_Load(object sender, EventArgs e)
    {
      if ((string) this.Session["Utente"] == null || this.Application["Logged"] == null)
        return;
      this.lblUtente.Visible = true;
      this.lblUtente.Text = "Benvenuto ";
      if ((string) this.Session["UtenteEmail"] == null)
        return;
      CUtente userByEmail = CUtente.GetUserByEmail((string) this.Session["UtenteEmail"]);
      if (userByEmail == null)
        return;
      if (userByEmail.Responsabile)
        this.lblUtente.Text += "Responsabile";
      else if (userByEmail.Volontario)
        this.lblUtente.Text += "Volontario";
      else if (userByEmail._UserType.Equals("Membro"))
        this.lblUtente.Text += "Membro";
      else
        this.lblUtente.Text += "Anonimo";
    }

    protected void LogOut_Click(object sender, EventArgs e)
    {
      this.Application["Logged"] = (object) "NO";
      this.Session["Utente"] = (object) null;
      this.Session.Clear();
      this.Server.Transfer("Home.aspx");
    }

    protected void LogIn_click(object sender, EventArgs e) => this.Server.Transfer("Login.aspx");
  }
}
