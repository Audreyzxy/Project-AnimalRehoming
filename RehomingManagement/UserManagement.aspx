<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="RehomingManagement.UserManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headCSS" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headJS" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Manage Users</h1>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-m-12">
                <h2>&nbsp;</h2>
                <div>
                    <asp:GridView ID="gvManageUsers" runat="server" CaptionAlign="Top"
                        AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3"
                        CellSpacing="2" CssClass="table table-hover table-striped" GridLines="None"
                        EmptyDataText="There Are No Users"
                        OnRowEditing="gvManageUsers_RowEditing"
                        OnRowUpdating="gvManageUsers_RowUpdating"
                        OnRowDeleting="gvManageUsers_RowDeleting" OnRowCancelingEdit="gvManageUsers_RowCancelingEdit">
                        <Columns>
                            <asp:TemplateField HeaderText="User Id">
                                <ItemTemplate>
                                    <asp:Label ID="lblDonatorId" Visible="true" runat="server" Text='<%# Eval("DonatorId") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="User Full Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("FullName") %>' />
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="FullNameTextBox"
                                        Text='<%#Eval("FullName")%>'
                                        Width="90"
                                        runat="server" />
                                    <br />
                                    <asp:RequiredFieldValidator ID="FullNameRequiredValidator"
                                        ControlToValidate="FullNameTextBox"
                                        Display="Dynamic"
                                        Text="Please enter a full name."
                                        runat="server" />
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email">
                                <ItemTemplate>
                                    <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="EmailTextBox"
                                        Text='<%#Eval("Email")%>'
                                        Width="90"
                                        runat="server" />
                                    <br />
                                    <asp:RequiredFieldValidator ID="EmailRequiredValidator"
                                        ControlToValidate="EmailTextBox"
                                        Display="Dynamic"
                                        Text="Please enter a valid email."
                                        ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        runat="server" />
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Role">
                                <ItemTemplate>
                                    <asp:Label ID="lblRole" runat="server" Text='<%# Eval("Role") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:DropDownList ID="ddlRole" CssClass="form-control" SelectedValue='<%# Bind("Role") %>' runat="server">
                                        <asp:ListItem Value="-1">--Select--</asp:ListItem>
                                        <asp:ListItem Value="User">User</asp:ListItem>
                                        <asp:ListItem Value="Admin">Admin</asp:ListItem>
                                    </asp:DropDownList>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Created Date">
                                <ItemTemplate>
                                    <asp:Label ID="lblCreatedDate" runat="server" Text='<%# Bind("CreatedDate") %>'></asp:Label>
                                </ItemTemplate>
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
