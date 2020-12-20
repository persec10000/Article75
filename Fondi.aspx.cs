// Decompiled with JetBrains decompiler
// Type: Article75.Fondi
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
  public class Fondi : System.Web.UI.Page
    {
        private UtilityDB Utility = new UtilityDB();
        private CFund fundManage = new CFund();

        protected Button btnYes1;
        protected Button btnNo1;
        protected Label lblDesc1;
        protected Label lblAmount1;
        protected Label lblTitle1;
        protected Label lblID1;

        protected Button btnYes2;
        protected Button btnNo2;
        protected Label lblDesc2;
        protected Label lblAmount2;
        protected Label lblTitle2;
        protected Label lblID2;

        protected Button btnYes3;
        protected Button btnNo3;
        protected Label lblDesc3;
        protected Label lblAmount3;
        protected Label lblTitle3;
        protected Label lblID3;

        protected Button btnYes4;
        protected Button btnNo4;
        protected Label lblDesc4;
        protected Label lblAmount4;
        protected Label lblTitle4;
        protected Label lblID4;

        protected Button btnYes5;
        protected Button btnNo5;
        protected Label lblDesc5;
        protected Label lblAmount5;
        protected Label lblTitle5;
        protected Label lblID5;

        int nYesNo1;
        int nYesNo2;
        int nYesNo3;
        int nYesNo4;
        int nYesNo5;

        protected void Page_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Fondi Page loaded!");
            this.Application["retpage"] = "Fondi.aspx";

            List<CFund> allFund = CFund.GetAllFund();
            int i = 0;
            foreach (CFund cfund in allFund)
            {
                if (cfund.title != null && !cfund.desc.Equals(""))
                {
                    if(i==0)
                    {
                        this.lblDesc1.Text = cfund.desc;
                        this.lblAmount1.Text = cfund.amount.ToString();
                        this.lblTitle1.Text = cfund.title;
                        this.btnYes1.Text = "SI:" + cfund.yes.ToString();
                        this.btnNo1.Text = "NO:" + cfund.no.ToString();
                        this.lblID1.Text = cfund.IDUTE.ToString();

                        this.lblTitle1.ForeColor = System.Drawing.Color.Black;
                        this.lblAmount1.ForeColor = System.Drawing.Color.Black;
                        this.lblDesc1.ForeColor = System.Drawing.Color.Black;
                        
                        if ((this.Session["ID"] != null)&& (this.Session["ID"].ToString().Length > 0))
                        {
                            this.Application["FundYesNo_" + this.lblID1.Text] = CFund.GetYesNo(int.Parse(cfund.IDUTE), int.Parse(this.Session["ID"].ToString()));
                        }

                    }
                    if (i == 1)
                    {
                        this.lblDesc2.Text = cfund.desc;
                        this.lblAmount2.Text = cfund.amount.ToString();
                        this.lblTitle2.Text = cfund.title;
                        this.btnYes2.Text = "SI:" + cfund.yes.ToString();
                        this.btnNo2.Text = "NO:" + cfund.no.ToString();
                        this.lblID2.Text = cfund.IDUTE.ToString();

                        this.lblTitle2.ForeColor = System.Drawing.Color.Black;
                        this.lblAmount2.ForeColor = System.Drawing.Color.Black;
                        this.lblDesc2.ForeColor = System.Drawing.Color.Black;

                        if ((this.Session["ID"] != null) && (this.Session["ID"].ToString().Length > 0))
                        {
                            this.Application["FundYesNo_" + this.lblID2.Text] = CFund.GetYesNo(int.Parse(cfund.IDUTE), int.Parse(this.Session["ID"].ToString()));
                        }

                    }
                    if (i == 2)
                    {
                        this.lblDesc3.Text = cfund.desc;
                        this.lblAmount3.Text = cfund.amount.ToString();
                        this.lblTitle3.Text = cfund.title;
                        this.btnYes3.Text = "SI:" + cfund.yes.ToString();
                        this.btnNo3.Text = "NO:" + cfund.no.ToString();
                        this.lblID3.Text = cfund.IDUTE.ToString();

                        this.lblTitle3.ForeColor = System.Drawing.Color.Black;
                        this.lblAmount3.ForeColor = System.Drawing.Color.Black;
                        this.lblDesc3.ForeColor = System.Drawing.Color.Black;

                        if ((this.Session["ID"] != null) && (this.Session["ID"].ToString().Length > 0))
                        {
                            this.Application["FundYesNo_" + this.lblID3.Text] = CFund.GetYesNo(int.Parse(cfund.IDUTE), int.Parse(this.Session["ID"].ToString()));
                        }

                    }
                    if (i == 3)
                    {
                        this.lblDesc4.Text = cfund.desc;
                        this.lblAmount4.Text = cfund.amount.ToString();
                        this.lblTitle4.Text = cfund.title;
                        this.btnYes4.Text = "SI:" + cfund.yes.ToString();
                        this.btnNo4.Text = "NO:" + cfund.no.ToString();
                        this.lblID4.Text = cfund.IDUTE.ToString();

                        this.lblTitle4.ForeColor = System.Drawing.Color.Black;
                        this.lblAmount4.ForeColor = System.Drawing.Color.Black;
                        this.lblDesc4.ForeColor = System.Drawing.Color.Black;

                        if ((this.Session["ID"] != null) && (this.Session["ID"].ToString().Length > 0))
                        {
                            this.Application["FundYesNo_" + this.lblID4.Text] = CFund.GetYesNo(int.Parse(cfund.IDUTE), int.Parse(this.Session["ID"].ToString()));
                        }

                    }
                    if (i == 4)
                    {
                        this.lblDesc5.Text = cfund.desc;
                        this.lblAmount5.Text = cfund.amount.ToString();
                        this.lblTitle5.Text = cfund.title;
                        this.btnYes5.Text = "SI:" + cfund.yes.ToString();
                        this.btnNo5.Text = "NO:" + cfund.no.ToString();
                        this.lblID5.Text = cfund.IDUTE.ToString();

                        this.lblTitle5.ForeColor = System.Drawing.Color.Black;
                        this.lblAmount5.ForeColor = System.Drawing.Color.Black;
                        this.lblDesc5.ForeColor = System.Drawing.Color.Black;

                        if ((this.Session["ID"] != null) && (this.Session["ID"].ToString().Length > 0))
                        {
                            this.Application["FundYesNo_" + this.lblID5.Text] = CFund.GetYesNo(int.Parse(cfund.IDUTE), int.Parse(this.Session["ID"].ToString()));
                        }else //(this.Session["ID"] == null)
                        {
                            this.Application["FundYesNo_" + this.lblID1.Text] = (object)-1;
                            this.Application["FundYesNo_" + this.lblID2.Text] = (object)-1;
                            this.Application["FundYesNo_" + this.lblID3.Text] = (object)-1;
                            this.Application["FundYesNo_" + this.lblID4.Text] = (object)-1;
                            this.Application["FundYesNo_" + this.lblID5.Text] = (object)-1;
                        }
                    }



                }
                i++;
            }

        }

        private int VoteFund()
        {
            int nRet;
            int idFund = int.Parse( this.Application["IDFondi"].ToString() );
            int idUser = int.Parse(this.Session["ID"].ToString());
            nRet = this.fundManage.CountingFund(idFund, idUser, this.Application["SI"].ToString());
            return nRet;

        }
        protected void btnYes1_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"SI";
            this.Application["Fondi"] = (object)this.lblTitle1.Text;
            this.Application["IDFondi"] = (object)this.lblID1.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnYes1.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }
        protected void btnYes2_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"SI";
            this.Application["Fondi"] = (object)this.lblTitle2.Text;
            this.Application["IDFondi"] = (object)this.lblID2.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnYes2.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }

        protected void btnYes3_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"SI";
            this.Application["Fondi"] = (object)this.lblTitle3.Text;
            this.Application["IDFondi"] = (object)this.lblID3.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnYes3.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }

        protected void btnYes4_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"SI";
            this.Application["Fondi"] = (object)this.lblTitle4.Text;
            this.Application["IDFondi"] = (object)this.lblID4.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnYes4.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }

        protected void btnYes5_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"SI";
            this.Application["Fondi"] = (object)this.lblTitle5.Text;
            this.Application["IDFondi"] = (object)this.lblID5.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet  = this.VoteFund();
                btnYes5.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }
        protected void btnNo1_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"NO";
            this.Application["Fondi"] = (object)this.lblTitle1.Text;
            this.Application["IDFondi"] = (object)this.lblID1.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnNo1.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }

        protected void btnNo2_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"NO";
            this.Application["Fondi"] = (object)this.lblTitle2.Text;
            this.Application["IDFondi"] = (object)this.lblID2.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnNo2.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }

        protected void btnNo3_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"NO";
            this.Application["Fondi"] = (object)this.lblTitle3.Text;
            this.Application["IDFondi"] = (object)this.lblID3.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnNo3.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }

        protected void btnNo4_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"NO";
            this.Application["Fondi"] = (object)this.lblTitle4.Text;
            this.Application["IDFondi"] = (object)this.lblID4.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnNo4.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }

        protected void btnNo5_Click(object sender, EventArgs e)
        {
            int nRet;
            this.Application["SI"] = (object)"NO";
            this.Application["Fondi"] = (object)this.lblTitle5.Text;
            this.Application["IDFondi"] = (object)this.lblID5.Text;
            if (this.Session["ID"] != null) // check userID on User table, // Session["Utente"]
            {
                nRet = this.VoteFund();
                btnNo5.Text = this.Application["SI"] + ":"+nRet.ToString();
            }
            else
                this.Server.Transfer("Login.aspx");
        }


    }
}
