<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mappa.aspx.cs" Inherits="Article75.Mappa" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<!-- Website template by freewebsitetemplates.com -->

<html>

<head runat="server">	

	<title>Mappa</title>

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

    <script type="text/javascript" src="http://maps.google.com/maps/api/js?key=AIzaSyCTM0iYRMlTI27YvqP_pv0MkoL18z98stw&sensor=false"></script>



    <script type="text/javascript">

        var initialize = function () {



            // fornisce latitudine e longitudine

            var latlng = new google.maps.LatLng(45.7468888, 9.7834629);



            // imposta le opzioni di visualizzazione

            var options = { zoom: 10,

                center: latlng,

                mapTypeId: google.maps.MapTypeId.ROADMAP

            };



            var marker = new google.maps.Marker({ position: latlng,

                map: map,

                title: 'Pradalunga'

            });



            // crea l'oggetto mappa

            var map = new google.maps.Map(document.getElementById('map'), options);

        }



        window.onload = initialize;

    </script>



</head>

<body onload="initialize()">

<form id="Connetti" runat="server">

	<div id="header1">

		<div>

			<div id="logo">

				<a href="Default.aspx"><img src="images/logo.png" alt="Logo" /></a>

			</div>

        </div>

     </div>

      <div id="header"> 

        <div>            

			<div id="navigation">

				<div>

					<ul>

						<li><a href="Default.aspx">Elenco Referendum</a></li>

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

            <br/>        

            <div id="map" style="width:75%; height:75%"></div>                                               

            <br />                               

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

				<form action="#">

					<label for="subscribe"><input type="text" id="subscribe" maxlength="30" value="email address" /></label>

					<input class="submit" type="submit" value="" />

				</form>

				<p>Copyright &copy; 2011  Ecothunder Incorporated <br />LRP 727 6783 83839 All rights reserved</p>

			</div>

		</div>

	</div>

    </form>

</body>

</html>