// Decompiled with JetBrains decompiler
// Type: Article75.Italia
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
  public partial class Italia : System.Web.UI.Page
  {

    protected void Page_PreInit(object sender, EventArgs e)
    {
            // Articolo75DS.SelectCommand = "SELECT * FROM Utenti ORDER BY ID"; //??!!SG
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
            MessageBox.Show("Hai cliccato su " + e.PostBackValue);
        }
  }
}
