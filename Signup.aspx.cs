using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article75
{
    public partial class Signup : System.Web.UI.Page
    {
        protected TextBox txtFirstName;
        protected TextBox txtLastName;
        protected TextBox txtComune;
        protected TextBox txtMail;
        protected Button btnCreateAccount;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)this.Session["Utente"] != null && this.Application["Logged"] != null)
            {
                //Attention you are already recognized by the system.
                this.Response.Write("<script LANGUAGE='JavaScript' >alert('Attenzione sei già riconosciuto dal sistema')</script>");
                this.Server.Transfer("Home.aspx");
            }
            this.Session.Clear();
            if (this.Page.IsPostBack)
                return;
            this.txtFirstName.Focus();
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtFirstName.Text.Length > 0) && (txtLastName.Text.Length > 0) && (txtMail.Text.Length > 0) && (txtComune.Text.Length > 0))
                {
                    //alert('Geocode was not successful for the following reason: ');
                    System.Diagnostics.Debug.WriteLine("Send email....!!!!!!!! ");
                    //console.log('Geocode was not successful for the following reason: ');
                    UtilityDB utilityDb = new UtilityDB();
                    utilityDb.CreateUser(txtMail.Text, txtFirstName.Text, txtLastName.Text, txtComune.Text);

                    this.Response.Write("<script LANGUAGE='JavaScript' >alert('Successfully registered! Please check your email in order to get your password.')</script>");
                    this.Server.Transfer("Login.aspx"); // this.Server.Transfer("Referendum.aspx");
                }
                else
                {// "Please input all the fields."
                    MessageBox.Show("Si prega di inserire tutti i campi!");
                }
            }
            catch (Exception ex)
            {
            }
        }



    }
}