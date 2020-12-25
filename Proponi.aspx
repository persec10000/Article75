<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Proponi.aspx.cs" Inherits="Article75.Proponi" %>

<asp:Content ID="Content3" ContentPlaceHolderID="RenderBody" runat="server">

    <div class="blog-listing-header blog-listing-no-header proponi-body-panel">

        <div class="light-shade">

            <div class="container">

                <div class="row">

                    <div class="col-xs-12">

                        <h1 class="h1 section-heading">Proponi Referendum</h1>

                        <p class="">

                            Aliquam erat volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed cursus erat ut placerat dictum. Etiam id facilisis enim, sed mattis magna. <br>

                        </p>

                    </div>

                </div>



                <div class="row form-group">

                    <label class="col-sm-2">Legge del</label>

                    <div class="col-sm-4">

                        <asp:TextBox ID="txtDataLegge" runat="server" MaxLength="18"></asp:TextBox>

                    </div>

                    <label class="col-sm-2">N°</label>

                    <div class="col-sm-4">

                        <asp:TextBox ID="txtNumeroLegge" runat="server" MaxLength="10" TextMode="SingleLine"></asp:TextBox>

                    </div>

                </div>

                <div class="row form-group">

                    <label class="col-sm-2">Slogan</label>

                    <div class="col-sm-10">

                        <asp:TextBox ID="txtTitolo" runat="server" MaxLength="50"></asp:TextBox>

                    </div>

                </div>

                <div class="row form-group">

                    <label class="col-sm-2">Descrizione Slogan</label>

                    <div class="col-sm-4">

                        <asp:TextBox ID="txtSlogan" runat="server" Height="100px" MaxLength="255" TextMode="MultiLine"></asp:TextBox>

                    </div>

                    <label class="col-sm-2">Stralcio</label>

                    <div class="col-sm-4">

                        <asp:TextBox ID="txtStralcio" runat="server" Height="100px" TextMode="MultiLine"></asp:TextBox>

                    </div>

                </div>

                <div class="row form-group">

                    <label class="col-sm-2">Perchè votare SI</label>

                    <div class="col-sm-4">

                        <asp:TextBox ID="txtVotoSI" runat="server" Height="100px" TextMode="MultiLine"></asp:TextBox>

                    </div>

                    <label class="col-sm-2">Perchè votare NO</label>

                    <div class="col-sm-4">

                        <asp:TextBox ID="txtVotoNO" runat="server" Height="100px" TextMode="MultiLine"></asp:TextBox>

                    </div>

                </div>

                <div class="row form-group">

                    <label class="col-sm-12">Link di riferimento</label>

                </div>

                <div class="row form-group">

                    <div class="col-sm-4">

                        <asp:TextBox ID="TextLink1" runat="server" MaxLength="200"></asp:TextBox>

                    </div>

                    <div class="col-sm-4">

                        <asp:TextBox ID="TextLink2" runat="server" MaxLength="200"></asp:TextBox>

                    </div>

                    <div class="col-sm-4">

                        <asp:TextBox ID="TextLink3" runat="server" MaxLength="200"></asp:TextBox>

                    </div>

                </div>

                <div class="row form-group">

                    <div class="col-sm-12" style="text-align:center;margin-top:50px;">

                        <asp:Button ID="btnAccedi" runat="server" Width="200px" class="btn btn-brand cbx-send-btn btn-cta" onclick="btnAccedi_Click" Text="OK" />

                        &nbsp;&nbsp;&nbsp;

                        <asp:Button ID="btnAnnulla" runat="server" Width="200px" class="btn btn-brand cbx-send-btn btn-cta" onclick="btnAnnulla_Click" Text="Annulla" />

                    </div>

                </div>

            </div>

        </div>

    </div>

    <script>$("main").addClass("blog-listing");</script>

</asp:Content>

	