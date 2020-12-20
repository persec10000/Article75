// Decompiled with JetBrains decompiler
// Type: Article75.Associazione
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
  public class Associazione : Page
  {
    private UtilityDB Utility = new UtilityDB();
    private CUtente ute = new CUtente();
    protected Button btnResponsabile;
    protected Button btnVolontario;
    protected TextBox U_Email;
    protected TextBox U_Name;
    protected TextBox U_Responsible;
    protected TextBox U_Type;
    protected TextBox U_Address;
    protected TextBox U_Volon;

    protected void Page_Load(object sender, EventArgs e)
    {
      this.Application["retpage"]= "Associazione.aspx";

      this.Application["Responsabile"] = (object) "";
      this.Application["Volontario"] = (object) "";
      this.ute.IDUTE = "NO";
      List<CUtente> allUsers = CUtente.GetAllUsers();
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      foreach (CUtente cutente in allUsers)
      {
        if (cutente.Comune != null && !cutente.Comune.Equals("") )
        {
          if(cutente.Responsabile || cutente.Volontario)
          {
            str1 = str1 + (str1.Equals("") ? "" : "&&") + cutente.Email;
            str2 = str2 + (str2.Equals("") ? "" : "&&") + cutente.Nome;
            str3 = str3 + (str3.Equals("") ? "" : "&&") + cutente.Responsabile.ToString();
            str4 = str4 + (str4.Equals("") ? "" : "&&") + cutente._UserType;
            str5 = str5 + (str5.Equals("") ? "" : "&&") + cutente.Comune;
            str6 = str6 + (str6.Equals("") ? "" : "&&") + cutente.Volontario.ToString();

          }
        }
      }
      this.U_Email.Text = str1;
      this.U_Name.Text = str2;
      this.U_Responsible.Text = str3;
      this.U_Type.Text = str4;
      this.U_Address.Text = str5;
      this.U_Volon.Text = str6;
    }

    protected void btnResponsabile_Click(object sender, EventArgs e)
    {
      this.Application["Responsabile"] = (object) "SI";
      if (this.Session["Utente"] != null)
      {
        this.CheckUser(1);
        this.Server.Transfer("ConfermaMembri.aspx");
      }
      else
        this.Server.Transfer("ConfermaMembri.aspx");
    }

    protected void btnVolontario_Click(object sender, EventArgs e)
    {
      this.Application["Volontario"] = (object) "SI";
      if (this.Session["Utente"] != null)
      {
        this.CheckUser(2);
        this.Server.Transfer("ConfermaMembri.aspx");
      }
      else
        this.Server.Transfer("ConfermaMembri.aspx");
    }

    private void CheckUser(int tipo)
    {
      this.ute.DammiUtente(this.Session["Utente"].ToString(), tipo);
      this.Session["TipoUtente"] = (object) this.ute.TipoUtente;
      this.Session["ID"] = (object) this.ute.IDUTE;
      this.Session["TipoMembro"] = (object) tipo.ToString();
    }
  }
}
