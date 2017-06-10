<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="RehomingManagement.SignUpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link href="Content/theme.css" rel="stylesheet" />
    <link href="Content/Custom.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Oxygen' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.1/css/font-awesome.min.css">
</head>
<body>
    <div class="container">
        <div class="row header">
            <div class="col-sm-5"></div>
            <div class="logo col-sm-4">
                <img src="images/logo4.jpg" width="200" />

            </div>
            <div class="col-sm-3"></div>
        </div>

        <div class="row main">
            <div class="form col-sm-6">
                <form id="form1" runat="server">
                    <h2>User Register</h2>
                    <div>
                        <div class="form-group">
                            <label for="txtFullName">Your full name</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                    <input type="text" class="form-control" id="txtFullName" placeholder="Enter your full name" required="required" runat="server" />

                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail">Your email</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                    <input type="text" class="form-control" id="txtEmail" placeholder="Enter your email" required="required" runat="server" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtPassword">Your password</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                    <input type="password" class="form-control" id="txtPwd" placeholder="Enter your password" required="required" runat="server" />
                                </div>
                            </div>
                        </div>
                       <%-- <div class="form-group">
                            <label for="confirm" class="cols-sm-2 control-label">Confirm Password</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                    <input type="password" class="form-control" name="confirm" id="confirm" placeholder="Confirm your Password" required="required" runat="server" />
                                </div>
                            </div>
                        </div>--%>
                        <asp:Button ID="btnSignUp" Text="Submit" CssClass="btn btn-lg btn-primary btn-block" runat="server" OnClick="btnSignUp_Click" />


                        <p>Old user? <a href="SignIn.aspx">Sign In</a></p>
                        <p><a href="UserDashBoard.aspx">Home</a></p>
                    </div>
                </form>
            </div>

            <div class="content col-sm-6">
                <h2>Want to rescue those poor animals?</h2>
                <p>Bringing a new foster pet into your home for the first time can sometimes be a little overwhelming.
                     <br />
                <a class="btn btn-default" href="https://www.spcaauckland.org.nz/">Visit SPCA Auckland&raquo;</a> </p>
               
                <iframe width="560" height="315" src="https://www.youtube.com/embed/YDs3flPU0ng" frameborder="0" allowfullscreen></iframe>
            </div>
        </div>
    </div>

</body>
</html>
