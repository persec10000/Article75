<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Contattaci.aspx.cs" Inherits="Article75.Contattaci" %>
<asp:Content ID="Content3" ContentPlaceHolderID="RenderBody" runat="server">
    <div class="contact-section">
        <div class="container-fluid">
            <div data-lat="44.5403" data-lng="-78.5463" data-title="Title Here" data-content="Here is description" class="cbxmapcanvas" id="map_canvas">
            </div>

            <div class="col-xs-12 col-md-6 col-sm-offset-3">
                <div id="contact_page_wrap">
                    <h1 class="h2 section-heading heading-no-top-margin">Contattaci</h1>
                        <div class="form-group">
                            <asp:TextBox ID="contactName" placeholder="Nome" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                            <label for="cbxname" class="error valid" id="cbxname-error"></label>
                        </div>
                        <div class="form-group">

                            <asp:TextBox ID="contactSurname" placeholder="Cognome" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                            <label for="cbxsurname" class="error valid" id="cbxsurname-error"></label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="contactEmail" placeholder="Email" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                            <label for="cbxemail" class="error valid" id="cbxemail-error"></label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="contactTel" placeholder="Telefono" runat="server" MaxLength="50" class="form-control"></asp:TextBox>
                            <label for="cbxtel" class="error valid" id="cbxtel-error"></label>
                        </div>
                        <div class="form-group">
                        <textarea required data-rule-minlength="20" placeholder="Specifica se ci contatti per proporre un reerendum oppure per diventare un volontario locale, grazie" rows="8" id="cbxmessage" name="cbxmessage" class="form-control cbxmessage cbx-textarea-control">
                        </textarea>
                            <label for="cbxmessage" class="error valid" id="cbxmessage-error"></label>
                        </div>
                        <button class="btn btn-block cbx-send-btn btn-cta" name="submit" type="submit">
                            Send Message
                        </button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>