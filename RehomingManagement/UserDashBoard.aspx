<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDashBoard.aspx.cs" Inherits="RehomingManagement.UserDashBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-sm-4">
            <br />
            <br />
            <img src="images/profile_photo.png" width ="200"/>
            <h2>Welcome <span id="lblUserFullName1" runat="server"></span></h2>
            <h3>Rescue is the best breed.</h3>
            <p class="lead">
                You won't <i>change</i> the world by saving an animal<br />
                But you will <i>change</i> that animal's world
            </p>
            <p><a href="About.aspx" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
        </div>
        <div class="col-sm-4">
            <br />        
            <h2>Your Profile</h2>
            <br />
            <div class="form-group">
                <label for="txtFullName" class="control-label">User Name : <span id="lblUserFullName2" runat="server"></span></label>
            </div>
            <div class="form-group">
                <label for="txtEmail" class="control-label">Email Address : <span id="lblEmail" runat="server"></span></label>
            </div>
            
            <div class="form-group">
                <label for="txtAdd" class="control-label">Role : <span id="lblRole" runat="server"></span></label>             
            </div>
           <%-- <div class="form-group">
                <label for="txtDate" class="control-label">Created Date : <span id="lblCreatedDate" type="date" runat="server"></span></label>               
            </div>  --%>       
        </div>
    </div>




</asp:Content>
