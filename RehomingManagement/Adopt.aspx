<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adopt.aspx.cs" Inherits="RehomingManagement.Adopt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1>Adoption is the best breeding!</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <h2>Adopt animals</h2>
                <p>Take me to home</p>            
                <img src="images/kitty%20cat.jpg"  width="500"/>
            </div>
            <div class="col-sm-6">
                <div class="form-group">
                    <label for="txtName" class="control-label">Your Full Name</label>
                    <input type="text" placeholder="Enter Name" class="form-control" id="txtName" required="required" runat="server"/>
                </div>
                <div class="form-group">
                    <label for="txtEmail" class="control-label">Your Email Address</label>
                    <input type="email" placeholder="Enter Email" class="form-control" id="txtEmail" required="required" runat="server"/>
                </div>
                <div class="form-group">
                    <label for="txtPhone" class="control-label">Your Phone Number</label>
                    <input type="text" placeholder="Enter Phone number" class="form-control" id="txtPhone" required="required" runat="server"/>
                </div> 
                <label for="checkAnimal" class="control-label">The Type of Animal You Want To Apply For:</label>
                <div class="checkbox">
                    <label>
                        <input type="radio" value="cat" id="chkCat" runat="server" checked>Cat</label>
                </div>
                <div class="checkbox">

                    <label>
                        <input type="radio" value="dog" id="chkDog" runat="server">Dog</label>
                </div>
                <div class="checkbox">
                    <label>
                        <input type="radio" value="smallAnimal" id="chkSAnimal" runat="server">Small Animal</label>
                </div>
                <div class="checkbox">
                    <label>
                        <input type="radio" value="farmAnimal" id="chkFAnimal" runat="server">Farm Animal</label>
                </div>              
                
                <div class="form-group">
                    <asp:Button ID="btnApply" runat="server" Text="Apply" CssClass="btn btn-success" OnClick="btnApply_Click"/>
                     <asp:Button ID="btnReset" OnClientClick="window.location.href='Adopt.aspx'; return false;" runat="server" CssClass="btn btn-danger" Text="Reset" />
                    
                </div>
            </div>
        </div>
    </div>











</asp:Content>
