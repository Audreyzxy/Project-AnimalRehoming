<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Donate.aspx.cs" Inherits="RehomingManagement.Donate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1>Donating animals instead of throwing them away can go a long way!</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <h2>Donate animals</h2>
                <p>Dont throw away the pet you dont want. Let us look after the next owner for your pet!</p>
                <img src="images/cuteAnimals.jpg" width="500" />

            </div>
            <div class="col-sm-6">
                <div class="form-group">
                    <label for="txtAnimalName" class="control-label">Animal Name</label>
                    <input type="text" placeholder="Enter Name" class="form-control" id="txtName" required="required" runat="server" />
                </div>
                <%-- <div class="form-group">
                    <label for="txtEmail" class="control-label">Email Address</label>
                    <input type="email" placeholder="Enter Email" class="form-control" id="txtEmail" />
                </div>--%>
                <label for="checkAnimal" class="control-label">Type of Animal</label>
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
                    <label for="txtAdd" class="control-label">Pick up location</label>
                    <input type="text" placeholder="Enter Location" class="form-control" id="txtAdd" runat="server" required="required"/>
                </div>
                <div class="form-group">
                    <label for="txtDate" class="control-label">Pick up date</label>
                    <input type="date" class="form-control" id="txtDate" runat="server" required="required"/>
                </div>
               <%-- <div class="form-group">

                    <asp:FileUpload ID="FileUploadControl" runat="server" />
                    <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_Click" />
                    <br />
                    <br />
                    <asp:Label runat="server" ID="StatusLabel" Text="Upload status: " />
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowHeader="false">
                        <Columns>
                            <asp:BoundField DataField="Text" />
                            <asp:ImageField DataImageUrlField="Value" ControlStyle-Height="100" ControlStyle-Width="100" />
                        </Columns>
                    </asp:GridView>
                </div>--%>
                <div class="form-group">
                    <asp:Button ID="btnSubmit" Text="Submit" CssClass="btn btn-success" runat="server" OnClick="btnSubmit_Click" />

                    <asp:Button ID="btnReset" CssClass="btn btn-danger" runat="server" Text="Reset" OnClientClick="window.location.href='Donate.aspx';return false;" />

                </div>
            </div>
        </div>
    </div>

</asp:Content>
