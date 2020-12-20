<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Conferma.aspx.cs" Inherits="Article75.Conferma" %>

<asp:Content ID="Content2" ContentPlaceHolderID="RenderBody" runat="server">

	<div class="login-section comform-section">

        <div class="container-fluid">

            <div class="row light-shade">

                <div id="article_map" class="left-part col-md-6 col-xs-12">

                </div>

                <div class="right-part col-md-6 col-xs-12 section-heading">

                    

                        <p class="title"><asp:Label ID="lblDefault" runat="server" Text="Label"></asp:Label></p>

                        <p><asp:Label ID="lblMessaggio" runat="server"  Text="Label"></asp:Label></p>

                        <p><asp:Label ID="lblComune" runat="server" Text="Label"></asp:Label></p>

                        <p><asp:Label ID="lblConferma" runat="server" Text="Label"></asp:Label></p>           

                    

                    <div class="form-group">

                        <asp:TextBox ID="txtComune" runat="server" MaxLength="50" placeholder="Comune di residenza" class="form-control" AutoCompleteType="None"></asp:TextBox>

                    </div>

                    <div class="form-group">

                        <asp:TextBox ID="txtEmail" class="txtEmail form-control" runat="server" MaxLength="50" placeholder="Email" AutoCompleteType="None"></asp:TextBox>

                  </div>

                    <asp:Button ID="btnOK" runat="server" Text="OK" class="btn btn-brand cbx-send-btn btn-cta" onclick="btnOk_Click" />

                    <asp:Button ID="btnAnnulla" runat="server" Text="Annulla" class="btn btn-brand cbx-send-btn btn-cta" onclick="btnAnnulla_Click" />

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

            $("#ctl00_RenderBody_txtEmail").focus();

        }

    }); 

    document.getElementById('ctl00_RenderBody_txtEmail').addEventListener('keypress', function (event) {

        if (event.keyCode == 13) {

            event.preventDefault();

            $("#ctl00_RenderBody_btnOK").focus();

        }

    });

</script>

<!-- if load google maps then load this api, change api key as it may expire for limit cross as this is provided with any theme -->

    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCbCHyYWM0eCnJhK08UJCq_wwGkGJhwvMU&libraries=places&callback=initAutocomplete"

    async defer></script>   

</asp:Content>