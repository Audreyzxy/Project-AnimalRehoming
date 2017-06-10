<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RehomingManagement._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headCSS" runat="server">
    <link href="Content/ani_carousel.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="headJS" runat="server">
    <script type="text/javascript" src="Scripts/ani_carousel.js"></script>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="slide-wrapper">
        <div class="container">
            <div id="myCarousel" class="carousel slide">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner">
                    <div class="item item1 active">
                        <div class="fill" style="background-color: lightgray;">
                            <div class="inner-content">
                                <div class="carousel-img">
                                    <img src="images/poor_animal1.jpg" width="320" />
                                    <%-- <img src="http://vocefalandoingles.com/wp-content/uploads/2016/09/sofa.png" alt="sofa" class="img img-responsive" />
                              --%>
                                </div>
                                <div class="carousel-desc">

                                    <h2>Rescue</h2>
                                    <p>Rescue animals are intelligent, emotional beings who deserve a chance at a long, happy life, and the rewards you get from rescuing are far greater than buying a animal. </p>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item item2">
                        <div class="fill" style="background-color: lightgray;">
                            <div class="inner-content">
                                <div class="carousel-img">
                                    <img src="images/poor_animal2.jpg" width="320" />
                                    <%-- <img src="http://cdn.homedit.com/wp-content/uploads/2011/08/137CLUB2ST.png" alt="white-sofa" class="img img-responsive" />
                                    --%>
                                </div>
                                <div class="carousel-desc">

                                    <h2>Care</h2>
                                    <p>Animals don't just need food and water, they need appropriate shelter and living space, regular vet check-ups and preventative vet care to ensure they remain happy and healthy. Just as importantly, your pet needs you: your time, love and attention. Many pets need mental stimulation and regular exercise to prevent them from becoming bored or overweight.</p>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item item3">
                        <div class="fill" style="background-color: lightgray;">
                            <div class="inner-content">
                                <div class="col-md-6">

                                    <div class="carousel-img">
                                        <img src="images/poor_animal3.jpeg" width="320" />

                                        <%-- <img src="http://vocefalandoingles.com/wp-content/uploads/2016/09/sofa.png" alt="sofa" class="img img-responsive" />
                                        --%>
                                    </div>
                                </div>

                                <div class="col-md-6 text-left">
                                    <div class="carousel-desc">

                                        <h2>Protect</h2>
                                        <p>A sustainable future for the planet can only be achieved if both animals and people are part of the solution.</p>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>

    <div class="row">
        <div class="col-md-4">
            <h2>Prevent Cruelty</h2>
            <p>
                We work with the community to prevent cruelty and encourage the humane treatment of all animals.</p>
            <p>
                <a class="btn btn-primary" href="Adopt.aspx">Adopt &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Animal Rescue</h2>
            <p>
                Our work on the front line rescuing animals who have been in an accident, abused or abandoned.</p>
            <p>
                <a class="btn btn-primary" href="Donate.aspx">Donate &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>What We Do</h2>
            <p>
                Animals who are sick, injured, lost, abused or simply abandoned. We are the only charity with the power to protect all animals including prosecuting people under the Animal Welfare. We rely entirely on the generosity of the community to do our work as we receive no government funding.  </p>
            <p>
                <a class="btn btn-primary" href="About.aspx">Read more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
