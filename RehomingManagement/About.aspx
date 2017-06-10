<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="RehomingManagement.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row header">
            <div class="col-sm-5"></div>
            <div class="logo col-sm-4">
                <h1>About Us</h1>
            </div>
            <div class="col-sm-3"></div>
        </div>
        <hr />

        <div class="row main">
            <div class="content col-sm-6">
                <div>
                    <h3>Our mission: </h3>
                    <p>To encourage the humane treatment of all animals and to prevent cruelty being inflicted upon them.</p>

                </div>
                <div>
                    <h3>Our Dreams: </h3>
                    <p>We end the needless suffering of animals </p>
                    <p>
                        We influence decision makers to put animals on the global agenda
                    </p>
                    <p>We help the world see how important animals are to all of us </p>
                    <p>We inspire people to change animals’ lives for the better</p>
                    <p>We move the world to protect animals.</p>
                    <p>We end the needless suffering of animals </p>

                </div>


            </div>
            <div class="content col-sm-6">
                <div>
                    <h3>Our Privacy Policy: </h3>
                </div>
                <div>
                    <h4>1. What personal information do we collect? </h4>
                    <p>
                        We collect the personal information you give to us when you fill in datafields and
submit that information to us while using this website. This information will include
your name, address, contact number(s) and email address.
                    </p>
                </div>
                <div>
                    <h4>2. How do we use personal information? </h4>
                    <p>We use your personal information for the following purposes: </p>
                    <ul>
                        <li>to reply to your queries;                        </li>
                        <li>to process your donation;</li>
                        <li>to correspond with you in relation to any competition you have entered;</li>


                    </ul>



                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Prevent Cruelty</h2>
            <p>
                We work with the community to prevent cruelty and encourage the humane treatment of all animals.
            </p>
            <p>
                <a class="btn btn-primary" href="Adopt.aspx">Adopt &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Animal Rescue</h2>
            <p>
                Our work on the front line rescuing animals who have been in an accident, abused or abandoned.
            </p>
            <p>
                <a class="btn btn-primary" href="Donate.aspx">Donate &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>What We Do</h2>
            <p>
                Animals who are sick, injured, lost, abused or simply abandoned. We are the only charity with the power to protect all animals including prosecuting people under the Animal Welfare. We rely entirely on the generosity of the community to do our work as we receive no government funding. 
            </p>
            <p>
                <a class="btn btn-primary" href="About.aspx">Read more &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
