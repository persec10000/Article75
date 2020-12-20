<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="CambiaPassword.aspx.cs" Inherits="Article75.CambiaPassword" %>

<asp:Content ID="Content2" ContentPlaceHolderID="RenderBody" runat="server">

	<div class="login-section">

        <div class="container-fluid">

            <div class="row light-shade">

                <div class="left-part col-md-6 col-xs-12">

                </div>

                <div class="right-part col-md-6 col-xs-12">

                    <h2 class="h1 section-heading">Cambio Password</h2>

                    <div class="form-group">

                        <asp:TextBox ID="txtVecchiaPassword" runat="server" MaxLength="50" placeholder="Vecchia Password" TextMode="Password" class="form-control"></asp:TextBox>

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtNuovaPassword" runat="server" MaxLength="12" placeholder="Nuova Password" class="form-control" TextMode="Password"></asp:TextBox>

                    </div>

                    <asp:Button ID="btnOK" class="btn btn-brand cbx-send-btn btn-cta" runat="server" Text="OK" OnClick="btnOK_Click"/>

                    <asp:Button ID="btnAnnulla" class="btn btn-brand cbx-send-btn btn-cta" runat="server" Text="Annulla" OnClick="btnAnnulla_Click"/>

                    

                </div>

            </div>

        </div>

    </div>

</asp:Content>