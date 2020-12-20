<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Associazione.aspx.cs" Inherits="Article75.Associazione" %>

<asp:Content ID="Content2" ContentPlaceHolderID="RenderBody" runat="server">

	<div class="association-panel">

        <div class="container-fluid">

            <div class="row">

                <div class="col-xs-12 col-md-6 left-part">

                    <div style="width:100%;padding-top: 3px;" class="col-xs-12 col-sm-6 text-center four" >

                        <div><h2 class="h1 section-heading" style="font-size: 24px;">L'associazione Articolo75.it è</h2></div>

                        <img src="assets/img/association/centro.png" alt="">

                    </div>

                </div>

                <div class="col-xs-12 col-md-6 right-part">

                    <h2 class="h1 section-heading">Senza scopi di lucro</h2>

                    <p>

                        - Gratis - I fondatori I'hanno finanziata -<br>

                        - I fondi vengono gestiti da tutti -<br>

                    </p>

                    <h2 class="h1 section-heading">Apartitica</h2>

                    <p>

                        - senza vertici - Un sito democratico nei contenuti -<br>

                        - Siamo garanti delle volontà individuali -<br>

                    </p>

                    <h2 class="h1 section-heading">Automatica</h2>

                    <p>

                        - Un Diritto di tutti - Un servizio alla cittadinanza -<br>

                        - Non serve potere politico o mediatico -<br>

                    </p>

                </div>

            </div>

        </div>

    </div>

    <div id="article_map"></div>

    <div id="section" class="assoication-main-panel">	

        <p><h2>Responsabile Locale</h2></p>

        <ul>                    

            <li>Oltre alla email forniscono un indirizzo.</li>

            <li>Si rendono dosponibili a consegnare moduli e documenti agli altri membri.</li>

        </ul>

        <p><asp:Button ID="btnResponsabile" runat="server" onclick="btnResponsabile_Click" 

            Text="Diventa Responsabile Locale" class="btn btn-brand cbx-send-btn" /></p>

        

        <p><h2>Volontario Locale</h2></p>

        <ul>

            <li>Permettono di essere contattati per email.</li>

            <li>Si renodono disponibile a consegnare moduli e documenti al propio comune di residenza.</li>

        </ul>

        <p><asp:Button ID="btnVolontario" runat="server" onclick="btnVolontario_Click" 

            Text="Diventa Volontario Locale" class="btn btn-brand cbx-send-btn" /></p>

	</div> 

    <asp:TextBox ID="U_Email" class="U_Email" runat="server" style="display:none;"></asp:TextBox>

    <asp:TextBox ID="U_Name" class="U_Name" runat="server" style="display:none;"></asp:TextBox>

    <asp:TextBox ID="U_Responsible" class="U_Responsible" runat="server" style="display:none;"></asp:TextBox>

    <asp:TextBox ID="U_Type" class="U_Type" runat="server" style="display:none;"></asp:TextBox>

    <asp:TextBox ID="U_Address" class="U_Address" runat="server" style="display:none;"></asp:TextBox>

    <asp:TextBox ID="U_Volon" class="U_Volon" runat="server" style="display:none;"></asp:TextBox>

<script>

    var map;

    var locations, i;

    var geocoder;

    var infowindow;

    function loadLocations() {

        var address = $(".U_Address").val().split("&&");

        var names = $(".U_Name").val().split("&&");

        var responsibles = $(".U_Responsible").val().split("&&");

        var types = $(".U_Type").val().split("&&");

        var emails = $(".U_Email").val().split("&&");

        var volons = $(".U_Volon").val().split("&&");

        locations = new Array(address.length);

        for (var i = 0; i < address.length; i++) {

            locations[i] = new Array(10);

            locations[i][0] = address[i];

            locations[i][1] = (names[i] == "" ? "This" : names[i]) + " is " + (responsibles[i] == "True" ? " resonsible " : volons[i] == "True" ? " volontario " : "") + types[i] + ". email:" + emails[i];

            locations[i][2] = responsibles[i] == "True" ? "R" : volons[i] == "True"?"V" : types[i] == 'Membro' ? 'M' : "A";

            locations[i][3] = responsibles[i] == "True" ? "green" : volons[i] == "True" ? "yellow" : types[i] == 'Membro' ? 'orange' : "red";

        }

    }

    function initAutocomplete() {

        loadLocations();

        var mapOptions = {

            center: new google.maps.LatLng(41.8719, 12.5674),

            zoom: 8,

            mapTypeId: google.maps.MapTypeId.ROADMAP

        };

        geocoder = new google.maps.Geocoder();

        infowindow = new google.maps.InfoWindow();

        map = new google.maps.Map(document.getElementById("article_map"), mapOptions);

        //!!OKS
        //UtilityDB utilityDb = new UtilityDB();
        //utilityDb.SendEmailConfirm("richworld3tai@gmail.com", "fL92P34IhAWQHDJ");
        //alert('send mail: ');

        for (i = 0; i < locations.length; i++) {

            geocodeAddress(i);

        }

    }

    function pinSymbol(color) {

        return {

            path: 'M 0,0 C -2,-20 -10,-22 -10,-30 A 10,10 0 1,1 10,-30 C 10,-22 2,-20 0,0 z',

            fillColor: color,

            fillOpacity: 1,

            strokeColor: '#000',

            strokeWeight: 2,

            scale: 1

        };

    }

    function geocodeAddress(i) {

        geocoder.geocode({ 'address': locations[i][0] }, function (results, status) {
            
            if (status === 'OK') {

                map.setCenter(results[0].geometry.location);

                var marker = new google.maps.Marker({

                    map: map,

                    position: results[0].geometry.location,

                    label: locations[i][2],

                    icon: pinSymbol(locations[i][3])//'assets/img/icons/award.png'

                }); 

                //console.log(results[0]);

                google.maps.event.addListener(marker, 'click', (function (marker, i) {

                    return function () {

                        infowindow.setContent(locations[i][1]);

                        infowindow.open(map, marker);

                        if (map.getZoom() == 8) {

                            map.setZoom(12);

                            map.setCenter(marker.getPosition());

                        } else {

                            map.setZoom(8);

                            map.setCenter(marker.getPosition());

                        }

                    }



                })(marker, i));

            } else {

                //alert('Geocode was not successful for the following reason: ' + status);
                System.Diagnostics.Debug.WriteLine('Geocode was not successful for the following reason: ' + status);
                console.log('Geocode was not successful for the following reason: ' + status);

            }

        });

    }



</script>

<!-- if load google maps then load this api, change api key as it may expire for limit cross as this is provided with any theme -->

<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCbCHyYWM0eCnJhK08UJCq_wwGkGJhwvMU&libraries=places&callback=initAutocomplete"

async defer></script>   

</asp:Content>



