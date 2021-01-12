<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="ReferendaDetail.aspx.cs" Inherits="Article75.ReferendaDetail" %>

<asp:Content ID="Content3" ContentPlaceHolderID="RenderBody" runat="server">
    
        <div class="single-petition-header">

            <div class="light-shade">

                <div class="container">

                    <div class="row">

                        <div class="col-xs-12">

                            <h1 class="h1 section-heading section-heading-white">                          

                                <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
                                <asp:Label ID="lblId" runat="server" Text="Title" Visible="false"></asp:Label>
                            </h1>
                            
                            <div class="progress-wrapper progress-wrapper-white">

                                <div class="progress small">

                                    <div class="value"></div>

                                </div>

                                <span>67%</span>

                                <div class="clearfix"></div>

                            </div>

                            <div class="meta">

                                <div class="signature-info pull-left">Referendum: <span>SI : 8396</span> vs <span> NO : 5245</span></div>
                                <div class="fb-share-button" data-href="http://185.117.152.92:8081/" data-layout="button" data-size="small"><a target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=http%3A%2F%2F185.117.152.92%3A8081%2F&amp;src=sdkpreparse" class="fb-xfbml-parse-ignore">Share</a></div>

                                <ul class="list-unstyled social-area social-area-signature pull-right">

                                    <li><a href="http://www.facebook.com/share.php?u=http://185.117.152.92:8081/ReferendaDetail.aspx" class="facebook"><i class="fa fa-facebook-f" aria-hidden="true"></i></a></li>


                                    <li><a href="https://plus.google.com/share?url=http://185.117.152.92:8081/ReferendaDetail.aspx" class="google-plus"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>

                                    <li><a href="http://twitter.com/share?http://185.117.152.92:8081/ReferendaDetail.aspx&text=Referendum&via=Article75" class="twitter"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>

                                    <li><a href="http://www.linkedin.com/shareArticle?mini=true&url=http://185.117.152.92:8081/ReferendaDetail.aspx&title=Referendum&summary=ReferendumDetail&source=Article75" class="linkedin"><i class="fa fa-linkedin" aria-hidden="true"></i></a></li>

                                    <li><a href="https://telegram.me/share/url?url=http://185.117.152.92:8081/ReferendaDetail.aspx&title=Referendum&summary=ReferendumDetail&source=Article75" class="telegram"><i class="fa fa-telegram" aria-hidden="true"></i></a></li>

                                    <!--li><a href="#" class="envelop"><i class="fa fa-envelope" aria-hidden="true"></i></a></li-->

                                </ul>



                            </div>

                        </div>

                    </div>

                </div>

            </div>

        </div>



        <div class="single-petition">

            <div class="container">

                <div class="row">

                    <div class="col-xs-12">

                        <div class="meta-info">

                            <div class="creatorinfo">

                                <p class="small">

                                    A Petition by: <b>Jonathan Doe</b>

                                </p>

                                <p class="small">

                                    Created on: 21<sup>st</sup> Feb, 2017

                                </p>

                            </div>

                            <div class="social text-right">
                                <asp:Button ID="BtnNo1" runat="server" onclick="BtnNo1_Click" class="btn btn-brand" Text="NO" UseSubmitBehavior="False"/>	
                                <asp:Button ID="BtnYes1" runat="server" onclick="BtnYes1_Click" class="btn btn-brand" Text="SI" UseSubmitBehavior="False"/>	
                                

                            </div>

                        </div>

                        <div class="petition-info">

                            <p>

                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ornare, nisl ac porta venenatis, sem nisl congue nibh, mattis fermentum sapien sapien at neque.

                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin consectetur ligula leo, quis suscipit erat venenatis nec.

                                Phasellus laoreet velit ac commodo hendrerit. Sed interdum pretium leo, vitae viverra neque mollis a. Ut augue purus, commodo ac consequat ac, convallis non felis.

                                Pellentesque et ante ut velit sagittis porttitor vel a velit. Praesent viverra arcu vehicula tortor maximus, eu tristique eros laoreet.

                                Quisque sed placerat magna. Suspendisse efficitur sem non accumsan eleifend. Nullam tincidunt enim vitae orci blandit, sit amet viverra dolor euismod.

                                Sed dui nibh, venenatis non sollicitudin ac, euismod id ipsum. Proin orci nulla, porta varius arcu et, pellentesque auctor massa.

                                Morbi egestas sapien et lorem vehicula, quis semper mauris interdum. Maecenas eget dui et quam dapibus commodo.

                                <br> <br>

                                Nullam lacinia sed sapien at lobortis. Cras vitae enim at justo pulvinar pellentesque et et augue. Aliquam efficitur ut enim id tincidunt.

                                Nullam eget egestas felis, eget volutpat purus. Suspendisse ac nisi sagittis, rhoncus turpis eget, rhoncus sapien. Maecenas tempor nulla eu risus laoreet tempor.

                                Donec maximus dictum urna id facilisis.

                            </p>

                            <ol>

                                <li>Vestibulum nec dui eget lacus fermentum malesuada.</li>

                                <li>Vestibulum nec dui eget lacus fermentum malesuada.</li>

                                <li>Vestibulum nec dui eget lacus fermentum malesuada.</li>

                                <li>Vestibulum nec dui eget lacus fermentum malesuada.</li>

                                <li>Vestibulum nec dui eget lacus fermentum malesuada.</li>

                            </ol>

                            <p>

                                Vivamus eget sem sit amet eros viverra porttitor a quis lacus. Vestibulum nec dui eget lacus fermentum malesuada.

                                Suspendisse at metus sed lectus vulputate convallis. Aliquam maximus odio non nunc tincidunt pharetra.

                                Curabitur in eros eget tellus accumsan imperdiet eu eget enim. Sed viverra ex mattis justo venenatis, luctus fermentum mi eleifend.

                                Nam non tortor in tellus tristique faucibus sit amet tristique risus. Maecenas in ex id quam eleifend convallis at id ante.

                                Vestibulum ornare posuere mi, nec placerat elit imperdiet nec. Nam aliquet varius enim, ut sollicitudin diam lobortis quis.

                                Ut at tellus non ex dictum congue. Nam vitae eleifend purus.

                            </p>



                        </div>





                    </div>

                </div>

                <div class="petition-media-items">

                    <div class="row petition-video-section">

                        <div class="col-xs-12 col-md-6">

                            <div class="petition-media-video">

                                <iframe src="https://www.youtube.com/embed/YTR21os8gTA"> </iframe>

                            </div>

                        </div>

                        <div class="col-xs-12 col-md-6 petition-video-info">

                            <h4>
                                <asp:Label ID="lblTitleVideo" runat="server" Text="Title"></asp:Label>

                            </h4>

                            <p>

                                Vivamus eget sem sit amet eros viverra porttitor a quis lacus. Vestibulum nec dui eget lacus fermentum malesuada.

                                Suspendisse at metus sed lectus vulputate convallis. Aliquam maximus odio non nunc tincidunt pharetra.

                                Curabitur in eros eget tellus accumsan imperdiet eu eget enim. Sed viverra ex mattis justo venenatis, luctus fermentum mi eleifend.

                                Nam non tortor in tellus tristique faucibus sit amet tristique risus. Maecenas in ex id quam eleifend convallis at id ante.

                                Vestibulum ornare posuere mi, nec placerat elit imperdiet nec.

                            </p>

                        </div>

                    </div>

                    <div class="row petition-media-photos" id="magnific-gallery">

                        <div class="col-xs-12 col-md-3">

                            <a href="assets/img/bird-one.jpg">

                                <img src="http://placehold.it/900x534" class="petition-media-photo img-responsive" alt="bird-photo">

                            </a>

                        </div>

                        <div class="col-xs-12 col-md-3">

                            <a href="assets/img/bird-two.jpg">

                                <img src="http://placehold.it/900x534" class="img-responsive" alt="bird-photo">

                            </a>

                        </div>

                        <div class="col-xs-12 col-md-3">

                            <a href="assets/img/bird-three.jpg">

                                <img src="http://placehold.it/900x534" class="img-responsive" alt="bird-photo">

                            </a>

                        </div>

                        <div class="col-xs-12 col-md-3">

                            <a href="assets/img/bird-four.jpg">

                                <img src="http://placehold.it/900x534" class="img-responsive" alt="bird-photo">

                            </a>

                        </div>

                    </div>

                </div>

                <div class="row">

                    <div class="recipient-area">

                        <div class="col-xs-12 col-md-10 col-md-offset-1">

                            <p class="recipient-heading text-center">The Letter Will be sent to:</p>

                            <div class="row">

                                <div class="col-xs-12 col-md-4">

                                    <div class="recipient">

                                        <p><strong>Ms Jane Doe</strong></p>

                                        <p>Head of Ministry, Environment</p>

                                    </div>

                                </div>

                                <div class="col-xs-12 col-md-4">

                                    <div class="recipient">

                                        <p><strong>Mr. John Doe</strong></p>

                                        <p>Head of Ministry, Information</p>

                                    </div>

                                </div>

                                <div class="col-xs-12 col-md-4">

                                    <div class="recipient">

                                        <p><strong>Ms Jane Doe</strong></p>

                                        <p>Head of Ministry, Humankind</p>

                                    </div>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

            </div>

        </div>



        <div class="letter">

            <div class="container">

                <div class="row">

                    <div class="col-xs-12">

                        <div class="letter-wrapper">

                            <p>

                                To: <br>

                                The ministry of Environment <br> <br>

                                Vivamus nec ullamcorper nibh, non mattis tellus. Suspendisse potenti. Aliquam venenatis erat sed rutrum blandit.

                                Maecenas nisl orci, accumsan vel libero at, mattis sollicitudin lectus. Nunc dolor quam, accumsan non massa nec, placerat facilisis urna.

                                Mauris convallis, erat id porta viverra, lacus nisl varius tellus, in ultrices nunc quam bibendum tellus. Nunc malesuada tellus vel mauris

                                <br> <br>



                                Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                Fusce lacinia faucibus iaculis. Nam facilisis, turpis eu pellentesque imperdiet, purus ex interdum enim, a lacinia odio sem posuere massa.

                                Suspendisse potenti. Donec venenatis, ante sit amet maximus pretium, mauris ipsum suscipit urna, vitae viverra metus augue nec ante.

                                <br> <br>



                                Sincerely, <br>

                                Jonathan Doe

                            </p>

                        </div>

                    </div>

                </div>

            </div>

        </div>

        <div class="updates-area">

            <div class="container">

                <div class="row">

                    <div class="col-xs-12 text-center update-news">

                        <h3 class="section-heading heading-no-top-margin">Updates</h3>

                        <div class="h-line"></div>

                        <div id="updates-carousel" class="owl-carousel owl-theme">

                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>



                            <div class="update-news">

                                <h5>12,304 Rescued</h5>

                                <p>

                                    Porta convallis. Integer magna orci, consequat ac nisl vel, tristique dictum sapien. Nam iaculis sit amet sem a porttitor.

                                    Cras vestibulum tempor ligula eu vehicula. Nam sed purus augue. Donec non semper arcu.

                                </p>

                                <p class="reporter">

                                    John Doe, <b>Reporter</b> <br>

                                    25<sup>th</sup> Feb, 2017

                                </p>

                            </div>

                        </div>

                    </div>

                </div>

            </div>

        </div>



        <div class="sgnature-listing-area">

            <div class="container">

                <div class="row">

                    <div class="col-xs-12 text-center">

                        <h3 class="section-heading heading-no-top-margin">Signatures</h3>

                        <div class="h-line"></div>

                    </div>

                </div>

                <div class="row" id="signatures_cards">

                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>



                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>



                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>



                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>



                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>



                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>



                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>



                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>



                            </div>



                        </div>

                    </div>

                    <div class="col-xs-12 col-sm-6 col-md-4">

                        <div class="sign-card">

                            <div class="thumb-photo">

                                <img src="http://placehold.it/250x250" class="img-responsive" alt="signer-photo">

                            </div>

                            <div class="signers-info">

                                <h5>Jane Doe</h5>

                                <p class="date-time">02-17-2017 at 4:46 PM	<span class="pull-right">#8691</span></p>

                                <p class="message">Etiam sed tortor augue. Aliquam erat volutpat. Etiam malesuada gravida hendrerit facilisis auctor.</p>

                            </div>

                        </div>

                    </div>

                </div>



                <div class="row">

                    <div class="col-xs-12 text-center">

                        <p class="section_view_more">

                            <!--a href="signature-list.html" class="btn btn-brand btn-cta">See All</a-->
                            <a   class="btn btn-brand btn-cta">See All</a>

                        </p>

                    </div>

                </div>

            </div>

        </div>



        <div class="sign-this-petition" id="sign-this-petition">

            <div class="light-shade">

                <div class="container">

                    <div class="row">

                        <div class="col-xs-12 text-center">

                            <h3 class="section-heading heading-no-top-margin">Sign this Referendum</h3>

                            <div class="h-line"></div>

                        </div>

                    </div>

                    <div class="row">

                        <div class="col-xs-12 col-md-10 col-md-offset-1">

                            <form id="signature-form" action="#" class="signature-form" method="POST" novalidate="novalidate">

                                <div class="row" style="display:none">

                                      <label class="sr-only" for="sf-fname">First Name</label>

                                      <div class="col-md-6">

                                        <input type="text" required data-rule-minlength="3" class="form-control" placeholder="First Name" id="sf-fname" name="sf-fname">

                                      </div>

                                      <label class="sr-only" for="sf-lname">Last Name</label>

                                      <div class="col-md-6">

                                        <input type="text" required data-rule-minlength="3" class="form-control" placeholder="Last Name" id="sf-lname" name="sf-lname">

                                      </div>

                                </div>



                                <div class="row"  style="display:none">

                                    <label class="sr-only" for="sf-mail">Email</label>

                                    <div class="col-md-12">

                                      <input type="email" required class="form-control" placeholder="Email" id="sf-mail" name="sf-mail">

                                    </div>

                                </div>

                                <div class="row">

                                  <label class="sr-only" for="detailed-updates">Comments</label>

                                  <div class="col-md-12">

                                    <textarea class="form-control" id="detailed-updates" name="sf-detailed-updates" cols="30" rows="6" placeholder="PERCHE VOTARE SI"></textarea>

                                  </div>

                                </div>

                                <div class="row">

                                  <label class="sr-only" for="detailed-updates">Comments</label>

                                  <div class="col-md-12">

                                    <textarea class="form-control" id="detailed-updates"
                                        name="sf-detailed-updates" cols="30" rows="6" placeholder="PERCHE VOTARE NO"></textarea>
                                      
                                  </div>

                                </div>


                                <p class="text-center"> <button type="submit" class="btn btn-brand btn-cta">Vote This</button></p>

                            </form>

                        </div>

                    </div>

                </div>

            </div>

        </div>



        <div class="comments-area">

            <div class="container">

                <div class="row">

                    <div class="col-xs-12 text-center">

                        <h3 class="section-heading heading-no-top-margin">Comments</h3>

                        <div class="h-line"></div>

                    </div>

                </div>

                <div class="row">

                    <div class="col-md-12">

                        <div class="social-comments text-center">

                            <ul class="nav nav-tabs">

                                <li class="active"><a data-toggle="tab" href="#facebook">Facebook</a></li>

                                <li><a data-toggle="tab" href="#googleplus">Google Plus</a></li>

                                <li><a data-toggle="tab" href="#disqus">Disqus</a></li>

                            </ul>



                            <div class="tab-content">

                                <div id="facebook" class="tab-pane fade in active">

                                    <div class="fb-comments" data-href="https://codeboxr.com/product/viralz-viral-buzz-html-template/" data-numposts="2" data-width="100%"></div>

                                </div>

                                <div id="googleplus" class="tab-pane fade">

                                    <div id="google-comments"></div>

                                </div>

                                <div id="disqus" class="tab-pane fade">

                                    <div id="disqus_thread"></div>

                                    <script type="text/javascript">



                                        /**

                                         *  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.

                                         *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables*/

                                        /*

                                         var disqus_config = function () {

                                         this.page.url = PAGE_URL;  // Replace PAGE_URL with your page's canonical URL variable

                                         this.page.identifier = PAGE_IDENTIFIER; // Replace PAGE_IDENTIFIER with your page's unique identifier variable

                                         };

                                         */

                                    </script>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

            </div>

        </div>



    <!--FOOTER START-->

<footer id="footer">



    <div class="container">

        <div class="row">

            <div class="col-xs-12 col-sm-6" style="display:none">

                <div class="footer-single footer-about">

                    <h2 class="title footer-logo"><a href="index.html"><img src="assets/img/petitionz-logo.png" alt="PetitionZ logo" class="img-responsive"></a></h2>

                    <p>

                        Eleifend tempus eros pellentesque vehicula. Aliquam turpis justo,mattis id neque et,

                        semper lacinia purus. Vivamus dapibus tellus blandit efficitur justo lacinia eu.

                        Praesent at nibh sit amet risus dictum nec eu quam. Fusce nec nisi dui.

                    </p>

                    <ul class="list-unstyled social-area">

                        <li><a href="#" class="facebook"><i class="fa fa-facebook-f" aria-hidden="true"></i></a></li>

                        <li><a href="#" class="google-plus"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>

                        <li><a href="#" class="twitter"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>

                        <li><a href="#" class="linkedin"><i class="fa fa-linkedin" aria-hidden="true"></i></a></li>

                        <li><a href="#" class="envelop"><i class="fa fa-envelope" aria-hidden="true"></i></a></li>

                    </ul>

                    <p>&#xA9; 2017 Copyright <span>PetitionZ</span> theme. All Rights reserved. <a href="#">Codeboxr.com</a></p>

                </div>

            </div>

            <!--div class="col-xs-12 col-sm-6"-->
            <div class="col-xs-12 col-sm-12">

                <h4 class="stay_connected_title">Stay Connected</h4>

                <div class="subscribe-form">

                    <form class="subscribe-form-action" action="#">

                        <div class="form-group subscribe-input">

                            <input name="subscribe" id="subscribe" class="form-control cbx-input form-control" required="required" placeholder="Email Address" type="email">

                        </div>

                        <div class="form-group subscribe-btn">

                            <button class="btn" name="subscribe-submit" type="submit">Subscribe</button>

                        </div>

                    </form>

                </div>

                <p>

                    Vivamus dapibus tellus blandit efficitur justo lacinia eu.

                    Praesent at nibh sit amet risus dictum nec eu quam. Fusce nec nisi dui.

                </p>



            </div> <!--//.col-->

        </div> <!--//.main row-->

    </div> <!--//.container-->

</footer> <!--//.FOOTER END-->



    <!--Body content ends-->



    <!-- *** ADD YOUR SITE SCRIPT HERE *** -->

<!-- if load google maps then load this api, change api key as it may expire for limit cross as this is provided with any theme -->

<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyChihC--Jb_QURoXd2MugyC53cDQjrV2MY"></script>



<!-- jQuery JS  -->

<script src="assets/vendor/jquery/jquery-3.2.1.min.js"> </script>

<!--script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script-->





<!-- BOOTSTRAP JS and Material  -->

<script src="assets/vendor/bootstrap/js/bootstrap.min.js"> </script>

<script src="assets/vendor/bootstrap-material/js/material.min.js"> </script>





<!-- jquery sortable js -->

<script src="assets/vendor/jquery-sortable/jquery-sortable-min.js"></script>



<!-- Owlcarousel -->

<script src="assets/vendor/owlcarousel/owl.carousel.js"></script>



<!-- Magnific popup -->

<script src="assets/vendor/magnific/jquery.magnific-popup.js"></script>





<script src="assets/vendor/waypoints/jquery.waypoints.min.js"></script>

<script src="assets/vendor/counterup/jquery.counterup.min.js"></script>



<!-- mustache.js -->

<script src="assets/vendor/mustache/mustache.min.js"></script>



<!-- jquery-file-upload -->

<script src="assets/vendor/jquery-file-upload/js/vendor/jquery.ui.widget.js"></script>

<script src="assets/vendor/jquery-file-upload/js/load-image.all.min.js"></script>

<script src="assets/vendor/jquery-file-upload/js/canvas-to-blob.min.js"></script>

<script src="assets/vendor/jquery-file-upload/js/jquery.iframe-transport.js"></script>

<script src="assets/vendor/jquery-file-upload/js/jquery.fileupload.js"></script>

<script src="assets/vendor/jquery-file-upload/js/jquery.fileupload-process.js"></script>

<script src="assets/vendor/jquery-file-upload/js/jquery.fileupload-image.js"></script>

<script src="assets/vendor/jquery-file-upload/js/jquery.fileupload-validate.js"></script>



<!-- jQuery Validator -->

<script src="assets/vendor/validation/jquery.validate.min.js"></script>





<!-- google map plugin -->

<script src="assets/js/jqcbxgooglemap.js"></script>



<!-- PetitionZ SCRIPT  -->

<script src="assets/js/theme.min.js"></script>





<!-- CUSTOM SCRIPT  -->

<script src="assets/js/custom.js"></script>









</asp:Content>