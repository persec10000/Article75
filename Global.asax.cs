// Decompiled with JetBrains decompiler
// Type: Article75.Global
// Assembly: Article75, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78677B1B-7861-49F7-8726-E85DF5A6A568
// Assembly location: E:\f_2020.11.17_italy\articolo75.it-20201119-Backup\bin\Article75.dll

using System;
using System.Web;

namespace Article75
{
  public class Global : HttpApplication
  {
    protected void Application_Start(object sender, EventArgs e)
    {
      new Start().ScriviData();
      this.Application["SI"] = (object) "";
      this.Application["Referendum"] = (object) "";
      this.Application["IDReferendum"] = (object) "";
      this.Application["Responsabile"] = (object) "";
      this.Application["Volontario"] = (object) "";
      this.Application["Logged"] = (object) "NO";
    }

    protected void Session_Start(object sender, EventArgs e)
    {
    }

    protected void Application_BeginRequest(object sender, EventArgs e)
    {
    }

    protected void Application_AuthenticateRequest(object sender, EventArgs e)
    {
    }

    protected void Application_Error(object sender, EventArgs e)
    {
    }

    protected void Session_End(object sender, EventArgs e)
    {
    }

    protected void Application_End(object sender, EventArgs e)
    {
    }
  }
}
