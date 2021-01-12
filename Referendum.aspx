<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Referendum.aspx.cs" Inherits="Article75.Referendum" %>

<asp:Content ID="Content3" ContentPlaceHolderID="RenderBody" runat="server">

    <div class="not-alone">

        <div class="container-fluid container-fluid-referendum">

            <!--div class="row"-->

                <div class="row-panel" style="display: none;">

                    <div class="header-panel">

                        <div style=""><img src="assets/img/referendum/referenda.png" /></div>

                    </div>

                </div>

                <div class="row-panel" style="margin-top: 40px;">

                    <div class="content-panel">

                        <table>

                            <tr valign="top">

                                <td width="*" style="padding-right:10px;">

                                    <div class="inline-panel">

                                        <div class="title-line" >
                                            
                                            <asp:Label ID="lblTitolo1" runat="server" Text="Titolo1"></asp:Label>
                                            

                                            

                                        </div>

                                        <div class="content-line">
                                            <!--a href="Petitionz/referendum-detail.html" style="color:#ffffff;"-->
                                            <a href="ReferendaDetail.aspx?id=4&title=Contro Chiesa" style="color:#ffffff;">
                                            <asp:Label ID="lblDescrizione1" runat="server" Text="Descrizione1"></asp:Label>

                                            
                                            <asp:Label ID="lblID1" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label> 

                                            consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.

Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in
                                            </a>
                                        </div>

                                    </div>

                                </td>

                                <td width="133px" style="padding-right:10px;">

                                    <asp:Button ID="BtnSi1" runat="server" onclick="BtnSi1_Click" class="btn btn-brand" Text="SI"/>

                                    <%//if (Application["Referendum"].Equals(lblTitolo1.Text)&&Application["SI"].Equals("SI")){ %>

                                    <%if(Application["ReferendumSiNo_" + lblID1.Text].Equals("SI")){ %>

                                    <img src="assets/img/referendum/yes.png" />

                                    <%} %>

                                </td>

                                <td width="123px">

                                    <asp:Button ID="BtnNo1" runat="server" onclick="BtnNo1_Click" class="btn btn-brand" Text="NO"/>	

                                    <%if(Application["ReferendumSiNo_" + lblID1.Text].Equals("NO")){ %>

                                    <img src="assets/img/referendum/no.png" />

                                    <%} %>

                                </td>

                            </tr>

                        </table>

                    </div>

                </div>



                <div class="row-panel">

                    <div class="content-panel">

                        <table>

                            <tr valign="top">

                                <td width="*" style="padding-right:10px;">

                                    <div class="inline-panel">

                                        <div class="title-line">

                                            <asp:Label ID="lblTitolo2" runat="server" Text="Titolo2"></asp:Label>

                                            

                                        </div>

                                        <div class="content-line">
                                            <a href="ReferendaDetail.aspx?id=1&title=Contro Cip6" style="color:#ffffff;">
                                            <asp:Label ID="lblDescrizione2" runat="server" Text="Descrizione2"></asp:Label>
                                                
                        <asp:Label ID="lblID2" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label>            

                                            consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.

Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in
                                            </a>
                                        </div>

                                    </div>

                                </td>

                                <td width="133px" style="padding-right:10px;">

                                    <asp:Button ID="BtnSi2" runat="server" onclick="BtnSi2_Click" class="btn btn-brand" Text="SI"/>

                                    <%if(Application["ReferendumSiNo_" + lblID2.Text].Equals("SI")){ %>

                                    <img src="assets/img/referendum/yes.png" />

                                    <%} %>

                                </td>

                                <td width="123px">

                                    <asp:Button ID="BtnNo2" runat="server" onclick="BtnNo2_Click" class="btn btn-brand" Text="NO"/>		

                                    <%if(Application["ReferendumSiNo_" + lblID2.Text].Equals("NO")){ %>

                                    <img src="assets/img/referendum/no.png" />

                                    <%} %>

                                </td>

                            </tr>

                        </table>

                    </div>

                </div>



                <div class="row-panel">

                    <div class="content-panel">

                        <table>

                            <tr valign="top">

                                <td width="*" style="padding-right:10px;">

                                    <div class="inline-panel">

                                        <div class="title-line">

                                            <asp:Label ID="lblTitolo3" runat="server" Text="Titolo3"></asp:Label>

                                        </div>

                                        <div class="content-line">
                                            
                                            <a href="ReferendaDetail.aspx?id=3&title=Contro Parlamento" style="color:#ffffff;">
                                            <asp:Label ID="lblDescrizione3" runat="server" Text="Descrizione3"></asp:Label>
                                                
                        <asp:Label ID="lblID3" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label>     

                                            consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.

Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in
                                            </a>
                                        </div>

                                    </div>

                                </td>

                                <td width="133px" style="padding-right:10px;">

                                    <asp:Button ID="BtnSi3" runat="server" onclick="BtnSi3_Click" class="btn btn-brand" Text="SI"/>

                                    <%if(Application["ReferendumSiNo_" + lblID3.Text].Equals("SI")){ %>

                                    <img src="assets/img/referendum/yes.png" />

                                    <%} %>

                                </td>

                                <td width="123px">

                                    <asp:Button ID="BtnNo3" runat="server" onclick="BtnNo3_Click" class="btn btn-brand" Text="NO"/>	

                                    <%if(Application["ReferendumSiNo_" + lblID3.Text].Equals("NO")){ %>

                                    <img src="assets/img/referendum/no.png" />

                                    <%} %>

                                </td>

                            </tr>

                        </table>

                    </div>

                </div>



                <div class="col-xs-12 col-md-12 left-part">

                    <p class="margin-top-4" style="text-align:center;">

                        <a href="Home.aspx" style="margin-bottom:20px;">Vedi elenco completo dei referendum</a>

                    

                    </p><p style="text-align:center;display:block;" >

                        <a href="Proponi.aspx" style="margin-top: 20px;" class="btn btn-brand btn-cta">Proponi un referendum</a>

                    </p>

                </div>

                <div class="col-xs-12 col-md-12 right-part" style="display:none;">

                    <div class="row">

                        <div class="col-xs-12 col-sm-6 text-center one">

                            <img src="assets/img/referendum/1.jpg" alt="">

                            <p>grandi opere impossibili grandi opere impossibili grandi opere impossibili grandi opere impossibili grandi opere impossibili</p>

                        </div>

                        <div class="col-xs-12 col-sm-6 text-center two">

                            <img src="assets/img/referendum/2.jpg" alt="">

                            <p>italia sulle stampelle italia sulle stampelle italia sulle stampelle italia sulle stampelle italia sulle stampelle italia sulle stampelle</p>

                        </div>

                    </div>

                    <div class="row">

                        <div class="col-xs-12 col-sm-6 text-center three">

                            <img src="assets/img/referendum/3.jpg" alt="">

                            <p>legge uguale per tutti salvo eccezzioni</p>

                        </div>

                        <div class="col-xs-12 col-sm-6 text-center four">

                            <img src="assets/img/referendum/4.jpg" alt="">

                            <p>soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash soldi cash</p>

                        </div>

                    </div>

                </div>

<div class="container petition-list fondi-item-panel" style="display:none">
            <div class="row" style="display:block">

                <div class="col-sm-6 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="banner">

                            <a href="Petitionz/single-petition.html"><img src="http://placehold.it/567x222" alt="petition-cover"></a>

                        </div>

                        <div class="contents">

                            <h2 class="h5"><a href="Petitionz/single-petition.html">Decrease Travellers taxes</a></h2>

                            <p>Target: 100,822 Signatures</p>

                            <div class="progress-wrapper">

                                <div class="progress small">

                                    <div class="value"></div>

                                </div>

                                <span>67%</span>

                                <div class="clearfix"></div>

                            </div>

                            <div class="report-info">

                                <div class="reporter">

                                    <img src="http://placehold.it/250x250" alt="reporters-photo">

                                    <p>Jane Doe</p>

                                </div>

                                <div class="date">

                                    <a href="create-petition.html#sign-this-petition" class="btn btn-sm btn-brand">Sign This<div class="ripple-container"></div></a>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

                <div class="col-sm-6 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="banner">

                            <a href="Petitionz/single-petition.html"><img src="http://placehold.it/567x222" alt="petition-cover"></a>

                        </div>

                        <div class="contents">

                            <h2 class="h5"><a href="Petitionz/single-petition.html">Ensure a flexible work hour</a></h2>

                            <p>Target: 9,822 Signatures</p>

                            <div class="progress-wrapper">

                                <div class="progress small">

                                    <div class="value"></div>

                                </div>

                                <span>67%</span>

                                <div class="clearfix"></div>

                            </div>



                            <div class="report-info">

                                <div class="reporter">

                                    <img src="http://placehold.it/250x250" alt="reporters-photo">

                                    <p>Jane Doe</p>

                                </div>

                                <div class="date">

                                    <a href="create-petition.html#sign-this-petition" class="btn btn-sm btn-brand">Sign This<div class="ripple-container"></div></a>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

            </div>

            <div class="row" style="display:block">

                <div class="col-sm-6 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="banner">

                            <a href="Petitionz/single-petition.html"><img src="http://placehold.it/567x222" alt="petition-cover"></a>

                        </div>

                        <div class="contents">

                            <h2 class="h5"><a href="Petitionz/single-petition.html">Ensure road safety at Prime State</a></h2>

                            <p>Target: 10,102 Signatures</p>

                            <div class="progress-wrapper">

                                <div class="progress small">

                                    <div class="value"></div>

                                </div>

                                <span>67%</span>

                                <div class="clearfix"></div>

                            </div>

                            <div class="report-info">

                                <div class="reporter">

                                    <img src="http://placehold.it/250x250" alt="reporters-photo">

                                    <p>Jane Doe</p>

                                </div>

                                <div class="date">

                                    <a href="create-petition.html#sign-this-petition" class="btn btn-sm btn-brand">Sign This<div class="ripple-container"></div></a>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

                <div class="col-sm-6 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="banner">

                            <a href="Petitionz/single-petition.html"><img src="http://placehold.it/567x222" alt="petition-cover"></a>

                        </div>

                        <div class="contents">

                            <h2 class="h5"><a href="Petitionz/single-petition.html">Take action for saving Environment</a></h2>

                            <p>Target: 12,822 Signatures</p>

                            <div class="progress-wrapper">

                                <div class="progress small">

                                    <div class="value"></div>

                                </div>

                                <span>67%</span>

                                <div class="clearfix"></div>

                            </div>

                            <div class="report-info">

                                <div class="reporter">

                                    <img src="http://placehold.it/250x250" alt="reporters-photo">

                                    <p>Jane Doe</p>

                                </div>

                                <div class="date">

                                    <a href="create-petition.html#sign-this-petition" class="btn btn-sm btn-brand">Sign This<div class="ripple-container"></div></a>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

            </div>

            <div class="row" style="display:block">

                <div class="col-sm-6 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="banner">

                            <a href="Petitionz/single-petition.html"><img src="http://placehold.it/567x222" alt="petition-cover"></a>

                        </div>

                        <div class="contents">

                            <h2 class="h5"><a href="Petitionz/single-petition.html">Ensure Fire safety all over the country</a></h2>

                            <p>Target: 2,822 Signatures</p>

                            <div class="progress-wrapper">

                                <div class="progress small">

                                    <div class="value"></div>

                                </div>

                                <span>67%</span>

                                <div class="clearfix"></div>

                            </div>

                            <div class="report-info">

                                <div class="reporter">

                                    <img src="http://placehold.it/250x250" alt="reporters-photo">

                                    <p>Jane Doe</p>

                                </div>

                                <div class="date">

                                    <a href="create-petition.html#sign-this-petition" class="btn btn-sm btn-brand">Sign This<div class="ripple-container"></div></a>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

                <div class="col-sm-6 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="banner">

                            <a href="Petitionz/single-petition.html"><img src="http://placehold.it/567x222" alt="petition-cover"></a>

                        </div>

                        <div class="contents">

                            <h2 class="h5"><a href="Petitionz/single-petition.html">Recrtuit more traffic police to stop accidents</a></h2>

                            <p>Target: 12,822 Signatures</p>

                            <div class="progress-wrapper">

                                <div class="progress small">

                                    <div class="value"></div>

                                </div>

                                <span>67%</span>

                                <div class="clearfix"></div>

                            </div>

                            <div class="report-info">

                                <div class="reporter">

                                    <img src="http://placehold.it/250x250" alt="reporters-photo">

                                    <p>Jane Doe</p>

                                </div>

                                <div class="date">

                                    <a href="create-petition.html#sign-this-petition" class="btn btn-sm btn-brand">Sign This<div class="ripple-container"></div></a>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

            </div>

            <div class="row" style="display:block">

                <div class="col-xs-12">

                    <div id="pagination-wrapper" class="text-center">

                        <ul class="pagination">

                            <li class="disabled">

                                <a href="#" aria-label="Previous">

                                    <i class="fa fa-angle-double-left" aria-hidden="true"></i>

                                </a>

                            </li>

                            <li><a href="#">1</a></li>

                            <li><a href="#">2</a></li>

                            <li><a href="#">3</a></li>

                            <li><a href="#">4</a></li>

                            <li><a href="#">5</a></li>

                            <li>

                                <a href="#" aria-label="Next">

                                    <i class="fa fa-angle-double-right" aria-hidden="true"></i>

                                </a>

                            </li>

                        </ul>

                    </div>

                </div>

            </div>



        </div>
            </div>

        </div>

    <!--/div-->

</asp:Content>