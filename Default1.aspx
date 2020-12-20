<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default1.aspx.cs" Inherits="Article75.Default1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!-- Website template by freewebsitetemplates.com -->

<html>

<head runat="server">	

	<title>Articolo75.it</title>

	<link rel="stylesheet" type="text/css" href="css/style.css" />

	<!--[if IE 9]>

		<link rel="stylesheet" type="text/css" href="css/ie9.css" />

	<![endif]-->

	<!--[if IE 8]>

		<link rel="stylesheet" type="text/css" href="css/ie8.css" />

	<![endif]-->

	<!--[if IE 7]>

		<link rel="stylesheet" type="text/css" href="css/ie7.css" />

	<![endif]-->

    <style type="text/css">       	    

	    .style1

        {

            text-align: center;

        }

	</style>

</head>

<body>



	<form id="form1" runat="server">

	<div id="header1">

		<div>

			<div id="logo">

				<a href="Default.aspx"><img src="images/logo.png" alt="Logo" /></a>

			</div>            

            <div id="Img">

                <asp:ImageButton ID="btnLogin" runat="server" Height="102px" 

                ImageUrl="~/images/LoginPro.png" Width="99px" PostBackUrl="~/Login.aspx" />                

            </div>

        </div>

     </div>

      <div id="header"> 

        <div>                   

            <asp:Label ID="lblUtente" runat="server" Text="Utente" Visible="False"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:HyperLink ID="HLnkPass" runat="server" Visible="False" 

                Font-Underline="True" NavigateUrl="~/CambiaPassword.aspx">Cambia Password</asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="btnOut" runat="server" onclick="btnOut_Click" Visible="False"

                Text="Log Out" />

        &nbsp;

            <asp:Button ID="btnConteggia" runat="server" onclick="btnConteggia_Click" 

                Text="Conteggia" />

        &nbsp;

            <asp:Button ID="btnMappa" runat="server" onclick="btnMappa_Click" 

                Text="Mappa" />

              

			<div id="navigation">

				<div>

					<ul>

						<li class="current"><a href="Default.aspx">Elenco Referendum</a></li>

						<li><a href="Idea.aspx">L'idea</a></li>

						<li><a href="Associazione.aspx">L'associazione</a></li>						

                        <li><a href="#">Diffondi</a></li>

                        <li><a href="#">Progetto</a></li>

                        <li><a href="#">Fondi</a></li>

                        <li><a href="#">Chi Siamo</a></li>

						<li><a href="#">Blog</a></li>

					</ul>

				</div>

			</div>            

            </div>

		</div>	

	<div id="content">

		<div id="section">

			<div>				

				<h1><asp:Label ID="lblTitolo1" runat="server" Text="Titolo1" Font-Size="18pt"></asp:Label></h1>				

                    <asp:Label ID="lblDescrizione1" runat="server" Text="Descrizione1" Font-Size="14pt"></asp:Label>

                    <asp:Label ID="lblID1" runat="server" Text="ID" Font-Size="6pt" 

                    Visible="False"></asp:Label>                               

					<asp:ImageButton ID="BtnSi1" runat="server" Height="36px" 

                    ImageUrl="~/images/BottoneGSI.jpg" Width="141px" onclick="BtnSi1_Click" />

                    &nbsp;&nbsp;&nbsp;

                    <asp:ImageButton ID="BtnNo1" runat="server" Height="36px" 

                    ImageUrl="~/images/BottoneGNO.jpg" Width="141px" onclick="BtnNo1_Click" />									

			</div>	           

            <div>

				<h1><asp:Label ID="lblTitolo2" runat="server" Text="Titolo2" Font-Size="18pt"></asp:Label></h1>				

                    <asp:Label ID="lblDescrizione2" runat="server" Text="Descrizione2" Font-Size="14pt"></asp:Label>

                    <asp:Label ID="lblID2" runat="server" Text="ID" Font-Size="6pt" 

                    Visible="False"></asp:Label>            

					<asp:ImageButton ID="BtnSi2" runat="server" Height="36px" 

                    ImageUrl="~/images/BottoneGSI.jpg" Width="141px" onclick="BtnSi2_Click" />

                    &nbsp;&nbsp;&nbsp;

                    <asp:ImageButton ID="BtnNo2" runat="server" Height="36px" 

                    ImageUrl="~/images/BottoneGNO.jpg" Width="141px" onclick="BtnNo2_Click" />					

			</div>            

            <div>

				<h1><asp:Label ID="lblTitolo3" runat="server" Text="Titolo3" Font-Size="18pt"></asp:Label></h1>				

                    <asp:Label ID="lblDescrizione3" runat="server" Text="Descrizione3" Font-Size="14pt"></asp:Label>

                    <asp:Label ID="lblID3" runat="server" Text="ID" Font-Size="6pt" 

                    Visible="False"></asp:Label>                				

					<asp:ImageButton ID="BtnSi3" runat="server" Height="36px" 

                    ImageUrl="~/images/BottoneGSI.jpg" Width="141px" onclick="BtnSi3_Click" />

                    &nbsp;&nbsp;&nbsp;

                    <asp:ImageButton ID="BtnNo3" runat="server" Height="36px" 

                    ImageUrl="~/images/BottoneGNO.jpg" Width="141px" onclick="BtnNo3_Click" />					

			</div>	                          

            <div>

                <p class="style1">

                    <a href="Default.aspx">Vedi elenco completo dei referendum</a>

                </p>

            </div>		            		

            <div>

                <br />

                <br />

				<a href="Proponi.aspx"><h1>Proponi un referendum</h1></a>                						

			</div>						

		</div>        

		<div id="featured">

			<ul>

				<li class="first">

					<a href="powerearth.html"><img src="images/map-in-grass.jpg" alt="Image" /></a>

					<span></span>

					<p>Lorem ipsum dolor sit amet,consectetur adipiscing elit. Cras lectus felis, auctor quis imperdiet vel, tempor non neque. Proin sed sapien quis magna lobortis</p>

					<a class="link" href="powerearth.html">The power of Earth</a>

				</li>

				<li>

					<a href="earthmad.html"><img src="images/little-girl-hugging-the-globe.jpg" alt="Image" /></a>

					<span></span>

					<p>Lorem ipsum dolor sit amet,consectetur adipiscing elit. Cras lectus felis, auctor quis imperdiet vel, tempor non neque. Proin sed sapien quis magna lobortis</p>

					<a class="link" href="earthmad.html">Earth No Mad</a>

				</li>

				<li>

					<a href="osmosisbeats.html"><img src="images/pointing-area-in-globe.jpg" alt="Image" /></a>

					<span></span>

					<p>Lorem ipsum dolor sit amet,consectetur adipiscing elit. Cras lectus felis, auctor quis imperdiet vel, tempor non neque. Proin sed sapien quis magna lobortis</p>

					<a class="link" href="osmosisbeats.html">Osmosis Beats</a>

				</li>

			</ul>

		</div>

	</div>

	<div id="footer">

		<div>

			<div class="first">

				<h3><a href="Default.aspx">Ecothunder</a></h3>

				<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent placerat eleifend arcu, sit amet rutrum lectus lobortis quis. Donec aliquam</p>

				<div>

					<p>Telephone. : <span>12345678-90</span></p>

					<p>Fax : <span>23456789-01</span></p>

					<p>Email : <span>ask@ecothunder.com</span></p>

				</div>

			</div>

			<div>

				<h3>Get Social with us!</h3>

				<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent placerat eleifend arcu, sit amet rutrum lectus lobortis quis. Donec aliquam</p>

				<div>

					<a href="http://facebook.com/freewebsitetemplates" class="facebook" target="_blank"></a>

					<a href="http://twitter.com/fwtemplates" class="twitter" target="_blank"></a>

					<a href="#" class="linked-in"></a>

				</div>

			</div>

			<div>

				<h3>Share your thoughts!</h3>

				<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent placerat eleifend arcu, sit amet rutrum lectus lobortis quis. Donec aliquam</p>

					<label for="subscribe"><input type="text" id="subscribe" maxlength="30" value="email address" /></label>

					<input class="submit" type="submit" value="" />

				<p>Copyright &copy; 2011  Ecothunder Incorporated <br />LRP 727 6783 83839 All rights reserved</p>

			</div>

		</div>

	</div>

    </form>

</body>

</html>