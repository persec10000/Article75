<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Fondi.aspx.cs" Inherits="Article75.Fondi" %>

<asp:Content ID="Content3" ContentPlaceHolderID="RenderBody" runat="server">

    <div class="featured-listing-header">

            <div class="light-shade">

                <div class="container">

                    <div class="row">

                        <div class="col-xs-12">

                            <h1 class="h1 section-heading section-heading-white">Fondi</h1>

                            <p class="section-info-white">

                                Aliquam erat volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed cursus erat ut placerat dictum. <br>

                                Etiam id facilisis enim, sed mattis magna. <br>

                            </p>

                        </div>

                    </div>

                </div>

            </div>

        </div>



        <div class="container petition-list fondi-item-panel">

            <div class="row">

                <div class="col-sm-12 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="contents">

                            <table border="0" style="width:100%;">

                                <tr>

                                    <td width="100px">

                                        <img src="assets/img/fondi/1.png" style="width:80%;height:80%;"/>

                                    </td>

                                    <td width="*">

                                        <div class="row">
                                            <label class="col-sm-6" style="color:#5a0b66">Descrizione</label>
                                            <label class="col-sm-6">
                                                <img src="assets/img/fondi/euro.png" />
                                                <asp:Label ID="lblAmount1" runat="server" Text="400" ></asp:Label>
                                            </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-10" >
                                            <asp:Label ID="lblDesc1" runat="server" Text="Descrizione 1" ></asp:Label>
                                            </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-2" style="color:#5a0b66">Dettagli</label>
                                            <label class="col-sm-10" >
                                                <asp:Label ID="lblTitle1" runat="server" Text="title1" ></asp:Label>
                                                <asp:Label ID="lblID1" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label> 
                                            </label>
                                        </div>

                                    </td>

                                    <td width="50px">

                                        <div class="row">
                                            <asp:Button ID="btnYes1" class="btn"  onclick="btnYes1_Click" runat="server" Text="SI" style="text-align:center"/>
                                        </div>

                                        <div class="row">
                                            <asp:Button ID="btnNo1" class="btn" onclick="btnNo1_Click" runat="server" Text="No"/>
                                        </div>

                                    </td>

                                    <td width="50px">

                                    <%if(Application["FundYesNo_" + lblID1.Text].Equals((object)1)){ %>

                                    <img src="assets/img/referendum/yes.png" style="width: 80px;height: 80px;" />

                                    <%} %>
                                    <%if(Application["FundYesNo_" + lblID1.Text].Equals((object)0)){ %>

                                    <img src="assets/img/referendum/no.png" style="width: 80px;height: 80px;" />

                                    <%} %>

                                    </td>


                                </tr>

                            </table>

                        </div>

                    </div>

                </div>

            </div>


            <div class="row">

                <div class="col-sm-12 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="contents">

                            <table border="0" style="width:100%;">

                                <tr>

                                    <td width="100px">

                                        <img src="assets/img/fondi/2.png" style="width:80%;height:80%;"/>

                                    </td>

                                    <td width="*">

                                        <div class="row">
                                            <label class="col-sm-6" style="color:#5a0b66">Descrizione</label>
                                            <label class="col-sm-6">
                                                <img src="assets/img/fondi/euro.png" />
                                                <asp:Label ID="lblAmount2" runat="server" Text="400" ></asp:Label>
                                            </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-10" >
                                            <asp:Label ID="lblDesc2" runat="server" Text="Descrizione 1" ></asp:Label>
                                                </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-2" style="color:#5a0b66">Dettagli</label>
                                            <label class="col-sm-10" >
                                                <asp:Label ID="lblTitle2" runat="server" Text="title1" ></asp:Label>
                                                <asp:Label ID="lblID2" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label> 
                                            </label>
                                        </div>

                                    </td>

                                    <td width="50px">

                                        <div class="row">
                                            <asp:Button ID="btnYes2" class="btn"  onclick="btnYes2_Click" runat="server" Text="SI" style="text-align:center"/>
                                        </div>

                                        <div class="row">
                                            <asp:Button ID="btnNo2" class="btn"  onclick="btnNo2_Click" runat="server" Text="No"/>
                                        </div>

                                    </td>

                                    <td width="50px">

                                    <%if(Application["FundYesNo_" + lblID2.Text].Equals((object)1)){ %>

                                    <img src="assets/img/referendum/yes.png" style="width: 80px;height: 80px;" />

                                    <%} %>
                                    <%if(Application["FundYesNo_" + lblID2.Text].Equals((object)0)){ %>

                                    <img src="assets/img/referendum/no.png" style="width: 80px;height: 80px;" />

                                    <%} %>

                                    </td>


                                </tr>

                            </table>

                        </div>

                    </div>

                </div>

            </div>


            <div class="row">

                <div class="col-sm-12 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="contents">

                            <table border="0" style="width:100%;">

                                <tr>

                                    <td width="100px">

                                        <img src="assets/img/fondi/3.png" style="width:80%;height:80%;"/>

                                    </td>

                                    <td width="*">

                                        <div class="row">
                                            <label class="col-sm-6" style="color:#5a0b66">Descrizione</label>
                                            <label class="col-sm-6">
                                                <img src="assets/img/fondi/euro.png" />
                                                <asp:Label ID="lblAmount3" runat="server" Text="400" ></asp:Label>
                                            </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-10" >
                                            <asp:Label ID="lblDesc3" runat="server" Text="Descrizione 1" ></asp:Label>
                                                </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-2" style="color:#5a0b66">Dettagli</label>
                                            <label class="col-sm-10" >
                                                <asp:Label ID="lblTitle3" runat="server" Text="title1" ></asp:Label>
                                                <asp:Label ID="lblID3" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label> 
                                            </label>
                                        </div>

                                    </td>

                                    <td width="50px">

                                        <div class="row">
                                            <asp:Button ID="btnYes3" class="btn"  onclick="btnYes3_Click" runat="server" Text="SI" style="text-align:center"/>
                                        </div>

                                        <div class="row">
                                            <asp:Button ID="btnNo3" class="btn"  onclick="btnNo3_Click" runat="server" Text="No"/>
                                        </div>

                                    </td>

                                    <td width="50px">

                                    <%if(Application["FundYesNo_" + lblID3.Text].Equals((object)1)){ %>

                                    <img src="assets/img/referendum/yes.png" style="width: 80px;height: 80px;" />

                                    <%} %>
                                    <%if(Application["FundYesNo_" + lblID3.Text].Equals((object)0)){ %>

                                    <img src="assets/img/referendum/no.png" style="width: 80px;height: 80px;" />

                                    <%} %>

                                    </td>


                                </tr>

                            </table>

                        </div>

                    </div>

                </div>

            </div>


            <div class="row">

                <div class="col-sm-12 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="contents">

                            <table border="0" style="width:100%;">

                                <tr>

                                    <td width="100px">

                                        <img src="assets/img/fondi/4.png" style="width:80%;height:80%;"/>

                                    </td>

                                    <td width="*">

                                        <div class="row">
                                            <label class="col-sm-6" style="color:#5a0b66">Descrizione</label>
                                            <label class="col-sm-6">
                                                <img src="assets/img/fondi/euro.png" />
                                                <asp:Label ID="lblAmount4" runat="server" Text="400" ></asp:Label>
                                            </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-10" >
                                            <asp:Label ID="lblDesc4" runat="server" Text="Descrizione 1" ></asp:Label>
                                                </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-2" style="color:#5a0b66">Dettagli</label>
                                            <label class="col-sm-10" >
                                                <asp:Label ID="lblTitle4" runat="server" Text="title1" ></asp:Label>
                                                <asp:Label ID="lblID4" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label> 
                                            </label>
                                        </div>

                                    </td>

                                    <td width="50px">

                                        <div class="row">
                                            <asp:Button ID="btnYes4" class="btn"  onclick="btnYes4_Click" runat="server" Text="SI" style="text-align:center"/>
                                        </div>

                                        <div class="row">
                                            <asp:Button ID="btnNo4" class="btn"  onclick="btnNo4_Click" runat="server" Text="No"/>
                                        </div>

                                    </td>

                                    <td width="50px">

                                    <%if(Application["FundYesNo_" + lblID4.Text].Equals((object)1)){ %>

                                    <img src="assets/img/referendum/yes.png" style="width: 80px;height: 80px;" />

                                    <%} %>
                                    <%if(Application["FundYesNo_" + lblID4.Text].Equals((object)0)){ %>

                                    <img src="assets/img/referendum/no.png" style="width: 80px;height: 80px;" />

                                    <%} %>

                                    </td>


                                </tr>

                            </table>

                        </div>

                    </div>

                </div>

            </div>


            <div class="row">

                <div class="col-sm-12 col-xs-12  petition-item-box">

                    <div class="petition-item card">

                        <div class="contents">

                            <table border="0" style="width:100%;">

                                <tr>

                                    <td width="100px">

                                        <img src="assets/img/fondi/5.png" style="width:80%;height:80%;"/>

                                    </td>

                                    <td width="*">

                                        <div class="row">
                                            <label class="col-sm-6" style="color:#5a0b66">Descrizione</label>
                                            <label class="col-sm-6">
                                                <img src="assets/img/fondi/euro.png" />
                                                <asp:Label ID="lblAmount5" runat="server" Text="400" ></asp:Label>
                                            </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-10" >
                                            <asp:Label ID="lblDesc5" runat="server" Text="Descrizione 1" ></asp:Label>
                                                </label>
                                        </div>

                                        <div class="row">
                                            <label class="col-sm-2" style="color:#5a0b66">Dettagli</label>
                                            <label class="col-sm-10" >
                                                <asp:Label ID="lblTitle5" runat="server" Text="title1" ></asp:Label>
                                                <asp:Label ID="lblID5" runat="server" Text="ID" Font-Size="6pt" Visible="False"></asp:Label> 
                                            </label>
                                        </div>

                                    </td>

                                    <td width="50px">

                                        <div class="row">
                                            <asp:Button ID="btnYes5" class="btn"  onclick="btnYes5_Click" runat="server" Text="SI" style="text-align:center"/>
                                        </div>

                                        <div class="row">
                                            <asp:Button ID="btnNo5" class="btn"  onclick="btnNo5_Click" runat="server" Text="No"/>
                                        </div>
                                    </td>

                                    <td width="50px">

                                    <%if(Application["FundYesNo_" + lblID5.Text].Equals((object)1)){ %>

                                    <img src="assets/img/referendum/yes.png" style="width: 80px;height: 80px;" />

                                    <%} %>
                                    <%if(Application["FundYesNo_" + lblID5.Text].Equals((object)0)){ %>

                                    <img src="assets/img/referendum/no.png" style="width: 80px;height: 80px;" />

                                    <%} %>

                                    </td>


                                </tr>

                            </table>

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

</asp:Content>

