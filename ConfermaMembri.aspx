<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="ConfermaMembri.aspx.cs" Inherits="Article75.ConfermaMembri" %>

<asp:Content ID="Content2" ContentPlaceHolderID="RenderBody" runat="server">

	<style>

        #description {

        font-family: Roboto;

        font-size: 15px;

        font-weight: 300;

      }



      #infowindow-content .title {

        font-weight: bold;

      }



      #infowindow-content {

        display: none;

      }



      #map #infowindow-content {

        display: inline;

      }



      .pac-card {

        margin: 10px 10px 0 0;

        border-radius: 2px 0 0 2px;

        box-sizing: border-box;

        -moz-box-sizing: border-box;

        outline: none;

        box-shadow: 0 2px 6px rgba(0, 0, 0, 0.3);

        background-color: #fff;

        font-family: Roboto;

      }



      #pac-container {

        padding-bottom: 12px;

        margin-right: 12px;

      }



      .pac-controls {

        display: inline-block;

        padding: 5px 11px;

      }



      .pac-controls label {

        font-family: Roboto;

        font-size: 13px;

        font-weight: 300;

      }



      #ctl00_RenderBody_txtComune:focus {

        border-color: #4d90fe;

      }



      #title {

        color: #fff;

        background-color: #4d90fe;

        font-size: 25px;

        font-weight: 500;

        padding: 6px 12px;

      }

      #target {

        width: 345px;

      }

    </style>

    <div class="login-section comform-section">

        <div class="container-fluid">

            <div class="row light-shade">

                <div id="article_map" class="left-part col-md-6 col-xs-12">

                </div>

                <div class="right-part col-md-6 col-xs-12 section-heading">

                    <p class="title"><asp:Label ID="lblDefault" runat="server" Text="Label"  AutoCompleteType="None"></asp:Label></p>

                    

                    <div class="form-group">

                        <asp:TextBox ID="txtNome" runat="server" MaxLength="20" placeholder="Nome" AutoCompleteType="None" class="form-control"></asp:TextBox> 

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtCognome" runat="server" MaxLength="20" placeholder="Cognome" AutoCompleteType="None" class="form-control"></asp:TextBox> 

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtIndirizzo" runat="server" MaxLength="200" placeholder="Indirizzo" AutoCompleteType="None" class="form-control"></asp:TextBox>

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtCap" runat="server" MaxLength="10" placeholder="Cap" AutoCompleteType="None" class="form-control"></asp:TextBox>

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtComune" runat="server" placeholder="Comune" AutoCompleteType="None" class="form-control"></asp:TextBox>

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" MaxLength="50" AutoCompleteType="None"  class="form-control"></asp:TextBox>

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtTel" runat="server" placeholder="Tel" MaxLength="50" AutoCompleteType="None" class="form-control"></asp:TextBox>

                    </div>

                    <br>

                    <asp:Button ID="btnOK" runat="server" Text="OK" class="btn btn-brand cbx-send-btn" onclick="btnOk_Click" /> 

                    <asp:Button ID="btnAnnulla" runat="server" class="btn btn-brand cbx-send-btn" onclick="btnAnnulla_Click" Text="Annulla" />

                    <asp:Label ID="lblIDReferendum" runat="server" Text="Label" Visible="False"></asp:Label>

                </div>

            </div>

        </div>

    </div>

<script>

    var map;

    function initAutocomplete() {

        var mapOptions = {

            center: new google.maps.LatLng(41.8719, 12.5674),

            zoom: 8,

            mapTypeId: google.maps.MapTypeId.ROADMAP

        };

        map = new google.maps.Map(document.getElementById("article_map"), mapOptions);

        // Create the search box and link it to the UI element.

        var searchBox = new google.maps.places.SearchBox(document.getElementById("ctl00_RenderBody_txtComune"));

        // Bias the SearchBox results towards current map's viewport.

        map.addListener('bounds_changed', function () {

            //alert('bounds_changed');

            searchBox.setBounds(map.getBounds());

        });



        var markers = [];

        // Listen for the event fired when the user selects a prediction and retrieve

        // more details for that place.

        searchBox.addListener('places_changed', function () {

            var places = searchBox.getPlaces();



            if (places.length == 0) {

                return;

            }



            // Clear out the old markers.

            markers.forEach(function (marker) {

                marker.setMap(null);

            });

            markers = [];



            // For each place, get the icon, name and location.

            var bounds = new google.maps.LatLngBounds();

            places.forEach(function (place) {

                if (!place.geometry) {

                    console.log("Returned place contains no geometry");

                    return;

                }

                var icon = {

                    url: place.icon,

                    size: new google.maps.Size(71, 71),

                    origin: new google.maps.Point(0, 0),

                    anchor: new google.maps.Point(17, 34),

                    scaledSize: new google.maps.Size(25, 25)

                };



                // Create a marker for each place.

                markers.push(new google.maps.Marker({

                    map: map,

                    icon: icon,

                    title: place.name,

                    position: place.geometry.location

                }));



                if (place.geometry.viewport) {

                    // Only geocodes have viewport.

                    bounds.union(place.geometry.viewport);

                } else {

                    bounds.extend(place.geometry.location);

                }

            });

            map.fitBounds(bounds);

        });

    }

    document.getElementById('ctl00_RenderBody_txtComune').addEventListener('keypress', function (event) {

        if (event.keyCode == 13) {

            event.preventDefault();

        }

    });



</script>

<!-- if load google maps then load this api, change api key as it may expire for limit cross as this is provided with any theme -->

    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCbCHyYWM0eCnJhK08UJCq_wwGkGJhwvMU&libraries=places&callback=initAutocomplete"

    async defer></script>   

</asp:Content>

