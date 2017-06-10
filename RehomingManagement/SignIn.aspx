<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="RehomingManagement.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign In</title>
    <link href="Content/theme.css" rel="stylesheet" />
    <link href="Content/Custom.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css' />
    <link href='https://fonts.googleapis.com/css?family=Oxygen' rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.1/css/font-awesome.min.css" />
</head>
<body>
    <div class="container">
        <div class="row header">
            <div class="col-sm-5"></div>
            <div class="logo col-sm-4">
                <img src="images/logo4.jpg" align="middle" width="200" />

            </div>
            <div class="col-sm-3"></div>
        </div>

        <div class="row main">
            <div class="form col-sm-6">
                <form id="form1" runat="server">
                    <div>
                        <%-- <div class="form-group">
                            <label for="txtFullName">Full name</label>
                            <input type="text" class="form-control" id="txtFullName" placeholder="Enter Full Name" required="required" />
                        </div>--%>
                        <div class="form-group">
                            <label for="txtEmail">Email</label>
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-envelope fa"
                                    aria-hidden="true"></i></span>
                                <input type="text" class="form-control" id="txtEmail" placeholder="Enter Your Email" required="required" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtPassword">Password</label>
                             <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg"
                                    aria-hidden="true"></i></span>
                                <input type="password" class="form-control" id="txtPwd" placeholder="Select Password" required="required" runat="server" />
                           </div>
                        </div>
                        <asp:Button ID="btnSignin" class="btn btn-lg btn-primary btn-block" Text="Login" runat="server" OnClick="btnSignin_Click" />

                        <%--<input type="button" name="login" class="btn btn-primary" value="Login" />--%>
                        <p>New user? <a href="SignUpPage.aspx">Sign up</a></p>
                        <p><a href="UserDashBoard.aspx">Home</a></p>
                    </div>
                </form>
            </div>

            <div class="content col-sm-6">
                <h2>Welcome to Animal Rehoming Website!</h2>
                <p>Bringing a new foster pet into your home for the first time can sometimes be a little overwhelming.</p>
                <iframe width="560" height="315" src="https://www.youtube.com/embed/_CjTeCHJp30" frameborder="0" allowfullscreen></iframe>
            </div>
        </div>
    </div>

</body>
</html>
