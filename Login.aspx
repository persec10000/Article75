<%@ Page Title="Aticolo75 | Login" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Article75.Login" %>

<asp:Content ID="Content3" ContentPlaceHolderID="RenderBody" runat="server">

    <div class="login-section">

        <div class="container-fluid">

            <div class="row light-shade">

                <div class="left-part col-md-6 col-xs-12">

                </div>

                <div class="right-part col-md-6 col-xs-12">

                    <h2 class="h1 section-heading">Log In</h2>

                    <div class="form-group">

                        <asp:TextBox ID="txtUtente" runat="server" MaxLength="50" placeholder="Email" class="form-control"></asp:TextBox>

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtPassword" runat="server" MaxLength="12" placeholder="Password" class="form-control" TextMode="Password"></asp:TextBox>

                    </div>

                    <asp:Button ID="btnAccedi" class="btn btn-brand cbx-send-btn btn-cta" runat="server" Text="OK" onclick="btnAccedi_Click" />

                    <div>

                        <p><a href="Signup.aspx">Create Account</a> | <a href="CambiaPassword.aspx">Forgot Password ?</a> | <a href="#">FAQ</a></p>

                    </div>

                </div>

            </div>

        </div>

    </div> 

</asp:Content>

	