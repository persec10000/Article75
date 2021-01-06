using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Article75
{
    public partial class FondiDetail : System.Web.UI.Page
    {
        private UtilityDB Utility = new UtilityDB();
        private CFund fundManage = new CFund();
        private CUtente ute = new CUtente();
        protected Button BtnYes1;
        protected Button BtnNo111;
        protected Label lblTitle;
        protected Label lblTitleVideo;
        protected Label lblId;

        protected string strTitle;
        protected string strId;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.strTitle = this.Request.QueryString["title"];
            this.strId = this.Request.QueryString["id"];
            this.Application["Fondi"] = (object)this.strTitle;
            this.Application["IDFondi"] = (object)this.strId;
            this.lblTitle.Text = this.strTitle;
            this.lblTitleVideo.Text = this.strTitle;
            this.lblId.Text = this.strId;
        }

        protected void BtnNo111_Click(object sender, EventArgs e)
        {
            int nRet;
            int idFund = int.Parse(this.Application["IDFondi"].ToString());
            int idUser = int.Parse(this.strId); 
            this.Application["SI"] = (object)"NO";
            this.Application["Fondi"] = (object)this.strTitle;
            this.Application["IDFondi"] = (object)this.strId;
            if (this.Session["Utente"] != null)
            {
                nRet = this.fundManage.CountingFund(idFund, idUser, this.Application["SI"].ToString());
            }
            else
                this.Server.Transfer("Login.aspx");
        }
        
        protected void BtnYes1_Click(object sender, EventArgs e)
        {
            int nRet;
            int idFund = int.Parse(this.Application["IDFondi"].ToString());
            int idUser = int.Parse(this.strId);//this.Session["ID"].ToString()
            this.Application["SI"] = (object)"SI";
            this.Application["Fondi"] = (object)this.strTitle;
            this.Application["IDFondi"] = (object)this.strId;
            if (this.Session["Utente"] != null)
            {
                nRet = this.fundManage.CountingFund(idFund, idUser, this.Application["SI"].ToString());
            }
            else
                this.Server.Transfer("Login.aspx");//Login
        }

    }
}