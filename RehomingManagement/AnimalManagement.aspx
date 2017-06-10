<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AnimalManagement.aspx.cs" Inherits="RehomingAnimalManagement.AnimalManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Manage Animals</h1>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-m-12">
                <h2>&nbsp;</h2>
                <div>
                    <asp:GridView ID="gvManageAnimals" runat="server" CaptionAlign="Top"
                        AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3"
                        CellSpacing="2" CssClass="table table-hover table-striped" GridLines="None"
                        EmptyDataText="There Are No Animals"
                        OnRowEditing="gvManageAnimals_RowEditing"
                        OnRowUpdating="gvManageAnimals_RowUpdating"
                        OnRowDeleting="gvManageAnimals_RowDeleting" OnRowCancelingEdit="gvManageAnimals_RowCancelingEdit">
                        <Columns>
                            <asp:TemplateField HeaderText="Animal Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("AnimalName") %>' />
                                    <asp:Label ID="lblAnimalId" Visible="false" runat="server" Text='<%# Eval("AnimalId") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Pick Up Address">
                                <ItemTemplate>
                                    <asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Type of Animals">
                                <ItemTemplate>
                                    <asp:Label ID="lblAnimalType" runat="server" Text='<%# Bind("Type") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Post Date">
                                <ItemTemplate>
                                    <asp:Label ID="lblPostDate" runat="server" Text='<%# Eval("CreatedDate") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="New Owner">
                                <ItemTemplate>
                                    <asp:Label ID="lblAdopter" runat="server" Text='<%# Bind("AdopterName") %>'></asp:Label>
                                </ItemTemplate>
                               <EditItemTemplate>
                                    <asp:DropDownList ID="ddlAdopter" CssClass="form-control" onchange="SetStatusValue(this)" 
                                        AppendDataBoundItems="true" runat="server" 
                                        PreviousValue='<%# Eval("AdopterId") %>' SelectedValue='<%# Bind("AdopterId") %>' 
                                        DataTextField="FullName" DataValueField="AdopterId" DataSourceID="AdopterDataSource">
                                    	<asp:ListItem Value="">Select</asp:ListItem>
                                	</asp:DropDownList>

                                    <asp:SqlDataSource ID="AdopterDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                        SelectCommand="Select AdopterId, FullName from Adopter where Active=1" SelectCommandType="Text"></asp:SqlDataSource>
                                </EditItemTemplate>



                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status">
                                <ItemTemplate>
                                    <asp:Label ID="lblStatus" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:DropDownList ID="ddlStatus" CssClass="form-control" SelectedValue='<%# Bind("Status") %>' runat="server">
                                        <asp:ListItem Value="-1">--Select--</asp:ListItem>
                                        <asp:ListItem Value="New Request">New Request</asp:ListItem>
                                        <asp:ListItem Value="Reserved">Reserved</asp:ListItem>
                                        <asp:ListItem Value="Adopted">Adopted</asp:ListItem>
                                        <asp:ListItem Value="Canceled">Canceled</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField HeaderText="Action" ShowDeleteButton="True"
                                ShowEditButton="True" DeleteText="Delete" />
                        </Columns>
                        <EmptyDataRowStyle BackColor="#eeeeee" BorderColor="Black"
                            BorderStyle="Solid" BorderWidth="1px" Font-Size="Large" ForeColor="#851010"
                            HorizontalAlign="Center" />
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <PagerStyle BackColor="#851010" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

    <script src="Scripts/Custom.js"></script>

</asp:Content>
